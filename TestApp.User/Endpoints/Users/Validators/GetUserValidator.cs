using FastEndpoints;
using FluentValidation;
using TestApp.User.Endpoints.Users.Models;

namespace TestApp.Endpoints.Users.Validators;

public class GetUserValidator : Validator<GetUsersRequest>
{
    public GetUserValidator()
    {
        RuleFor(x => x.Count).NotEmpty();
        RuleFor(x => x.Count).InclusiveBetween(1, 10);
    }
}