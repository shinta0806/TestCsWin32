namespace TestCsWin32.Contracts.Services;

public interface IActivationService
{
    Task ActivateAsync(object activationArgs);
}
