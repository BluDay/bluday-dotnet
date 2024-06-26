namespace BluDay.Net.UI.Navigation;

/// <summary>
/// Represents a view navigator for managing navigation between views.
/// </summary>
public interface IViewNavigator
{
    /// <summary>
    /// Gets a value indicating whether navigation to the previous view is possible.
    /// </summary>
    bool CanGoBack { get; }

    /// <summary>
    /// Gets a value indicating whether navigation to the next view is possible.
    /// </summary>
    bool CanGoForward { get; }

    /// <summary>
    /// Gets the unique identifier associated with the window.
    /// </summary>
    Guid WindowId { get; }

    /// <summary>
    /// Gets the view type at the top of the current view type stack.
    /// </summary>
    Type? CurrentView { get; }

    /// <summary>
    /// Gets an enumerable of types for all displayed views.
    /// </summary>
    IEnumerable<Type> CurrentViews { get; }

    /// <summary>
    /// Removes the top view from the navigation stack.
    /// </summary>
    /// <returns>
    /// <c>true</c> if successful, <c>false</c> if the stack is empty.
    /// </returns>
    bool Pop();

    /// <summary>
    /// Pushes a new view onto the navigation stack based on the specific view model type.
    /// </summary>
    /// <param name="viewModelType">
    /// The type of the view model associated with the view.
    /// </param>
    void Push(Type viewModelType);

    /// <summary>
    /// Pushes a new view onto the navigation stack based on the specific view model type.
    /// </summary>
    /// <typeparam name="TViewModel">
    /// The type of the view model associated with the view.
    /// </typeparam>
    void Push<TViewModel>() where TViewModel : IViewModel;

    /// <summary>
    /// Resets the view navigation stack.
    /// </summary>
    void Reset();
}