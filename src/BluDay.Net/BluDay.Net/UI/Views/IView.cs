﻿namespace BluDay.Net.UI.Views;

/// <summary>
/// Represents a view control.
/// </summary>
public interface IView
{
    /// <summary>
    /// Gets the id of the window the view control instance belongs to.
    /// </summary>
    Guid WindowId { get; }

    /// <summary>
    /// Sets the id of the window.
    /// </summary>
    /// <param name="value">
    /// The id of the window.
    /// </param>
    void SetWindowId(Guid value);
}