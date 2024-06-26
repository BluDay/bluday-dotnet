namespace BluDay.Net.Services;

/// <summary>
/// The service that handles the activation and deactivation of an app.
/// </summary>
public sealed class AppActivationService : IAppActivationService
{
    private bool _isActivated;

    private readonly IMessenger _messenger;

    public bool IsActivated => _isActivated;

    public AppActivationService(IMessenger messenger)
    {
        _messenger = messenger;
    }

    public void Activate()
    {
        _messenger.Send<AppActivatingMessage>();
    }
}