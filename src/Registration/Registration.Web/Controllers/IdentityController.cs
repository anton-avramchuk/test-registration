using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Registration.Core.Exceptions;
using Registration.MediatR.Common;
using Registration.Web.Application.Command.Identity;
using Registration.Web.Models.Identity;

namespace Registration.Web.Controllers
{
    public class IdentityController : Controller
    {
        private readonly ILogger<IdentityController> _logger;
        private readonly IMediatorService _mediatorService;

        public IdentityController(ILogger<IdentityController> logger,IMediatorService mediatorService)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _mediatorService = mediatorService ?? throw new ArgumentNullException(nameof(mediatorService));
        }

        [HttpGet]
        public IActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Registration(RegistrationViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _mediatorService.SendCommand(new RegistrationCommand(model.Login, model.Email,
                        model.FirstName, model.LastName, model.FatherName, model.Password, model.PhoneNumber,
                        model.BirthDay.Value));
                    return RedirectToAction("RegistrationSuccess");
                }
                catch (ApplicationExecutionException e)
                {
                    foreach (var message in e.Messages)
                    {
                        ModelState.AddModelError(string.Empty, message);
                    }
                    
                }
                catch (Exception e)
                {
                    ModelState.AddModelError(string.Empty, "Operation failed");
                    _logger.LogError(e, e.Message);
                }
            }

            return View(model);
        }



        public IActionResult RegistrationSuccess()
        {
            return View();
        }
    }
}
