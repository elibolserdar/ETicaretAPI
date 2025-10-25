using MediatR;

namespace ETicaretAPI.Application.Features.Commands.AppUser.LoginUser
{
    public class LoginUserCommandRequest: IRequest<LoginUserCommandRequest>
    {
        public string UsernameOrEmail { get; set; }
        public string Password { get; set; }
    }
}
