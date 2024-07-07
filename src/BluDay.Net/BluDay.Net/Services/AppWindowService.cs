﻿namespace BluDay.Net.Services;

/// <summary>
/// A service that manages windows within an app.
/// </summary>
public sealed class AppWindowService
{
    private readonly WeakReferenceMessenger _messenger;

    private readonly HashSet<IWindow> _windows;

    /// <summary>
    /// Gets the main window.
    /// </summary>
    public IWindow? MainWindow => _windows.FirstOrDefault();

    /// <summary>
    /// Gets the count of all windows.
    /// </summary>
    public int WindowCount => _windows.Count;

    /// <summary>
    /// Gets an enumerable of all windows.
    /// </summary>
    public IEnumerable<IWindow> Windows => _windows;

    /// <summary>
    /// Initializes a new instance of the <see cref="AppWindowService"/> class.
    /// </summary>
    /// <param name="messenger">
    /// The event messenger instance.
    /// </param>
    public AppWindowService(WeakReferenceMessenger messenger)
    {
        _messenger = messenger;

        _windows = new HashSet<IWindow>();
    }

    /// <summary>
    /// Creates a new window instance of type <see cref="IWindow"/>.
    /// </summary>
    /// <returns>
    /// The window instance.
    /// </returns>
    /// <exception cref="NotImplementedException"></exception>
    public IWindow CreateWindow()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Gets a value indicating whether the provided window instance exists and if it
    /// has been registered within the service.
    /// </summary>
    /// <param name="window">
    /// The window instance.
    /// </param>
    /// <returns>
    /// <c>true</c> if the window exists, <c>false</c> otherwise.
    /// </returns>
    /// <exception cref="NotImplementedException"></exception>
    public bool HasWindow(IWindow window)
    {
        throw new NotImplementedException();
    }
}