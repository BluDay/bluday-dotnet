namespace BluDay.Net.Services;

/// <summary>
/// A service that manages view navigation within an app, for all active windows.
/// </summary>
public sealed class AppNavigationService : Service
{
    private readonly Dictionary<Guid, ViewNavigator> _windowIdToViewNavigatorMap = new();

    /// <summary>
    /// Initializes a new instance of the <see cref="AppNavigationService"/> class.
    /// </summary>
    /// <param name="messenger">
    /// The default <see cref="WeakReferenceMessenger"/> instance.
    /// </param>
    public AppNavigationService(WeakReferenceMessenger messenger) : base(messenger) { }

    /// <summary>
    /// Navigates to the specified view within a window of type <see cref="IBluWindow"/>.
    /// </summary>
    /// <typeparam name="TView"></typeparam>
    /// <param name="windowId">
    /// The id of the targeted window.
    /// </param>
    /// <exception cref="NotImplementedException">
    /// </exception>
    public void Navigate<TView>(Guid windowId) where TView : class
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Tries to navigate to the specified view within a window without throwing an exception.
    /// </summary>
    /// <inheritdoc cref="Navigate{TView}(Guid)"/>
    public bool TryNavigate<TView>(Guid windowId) where TView : class
    {
        throw new NotImplementedException();
    }
}