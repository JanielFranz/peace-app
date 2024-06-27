using PeaceApp.API.IAM.Domain.Model.Commands;
using PeaceApp.API.IAM.Interfaces.REST.Resources;

namespace PeaceApp.API.IAM.Interfaces.REST.Transform;

public static class SignInCommandFromResourceAssembler
{
    public static SignInCommand ToCommandFromResource(SignInResource resource)
    {
        return new SignInCommand(resource.Username, resource.Password);
    }
}