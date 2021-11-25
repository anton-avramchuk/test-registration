using Microsoft.AspNetCore.Identity;
using Registration.Domain.Identity;
using Registration.MediatR.Common;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Registration.Core.Exceptions;

namespace Registration.Web.Application.Command.Identity
{
    public class RegistrationCommand : ICommand
    {
        public string Login { get; }
        public string Email { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public string FatherName { get; }
        public string Password { get; }
        public string Phone { get; }
        public DateTime BirthDay { get; }

        public RegistrationCommand(string login, string email, string firstName, string lastName, string fatherName,
            string password, string phone, DateTime birthDay)
        {
            Login = login ?? throw new ArgumentNullException(nameof(login));
            Email = email ?? throw new ArgumentNullException(nameof(email));
            FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
            LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
            FatherName = fatherName ?? throw new ArgumentNullException(nameof(fatherName));
            Password = password ?? throw new ArgumentNullException(nameof(password));
            Phone = phone ?? throw new ArgumentNullException(nameof(phone));
            BirthDay = birthDay;
        }

        class RegistrationCommandHandler : ICommandHandler<RegistrationCommand>
        {
            private readonly UserManager<User> _userManager;

            public RegistrationCommandHandler(UserManager<User> userManager)
            {
                _userManager = userManager ?? throw new ArgumentNullException(nameof(userManager));
            }

            public async Task<object> Handle(RegistrationCommand request, CancellationToken cancellationToken)
            {
                if (request == null) throw new ArgumentNullException(nameof(request));

                var user = new User()
                {
                    UserName = request.Login,
                    FirstName = request.FirstName,
                    LastName = request.LastName,
                    Email = request.Email,
                    BirthDay = request.BirthDay,
                    FatherName = request.FatherName,
                    PhoneNumber = request.Phone
                };
                var result = await _userManager.CreateAsync(user, request.Password);
                if (!result.Succeeded)
                {
                    throw new ApplicationExecutionException(result.Errors.Select(q => q.Description).ToArray());
                }
                return null;
            }
        }

    }
}