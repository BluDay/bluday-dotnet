﻿namespace BluDay.Net.UI.Windowing;

/// <summary>
/// Represents the control of a window.
/// </summary>
public interface IBluNavigableWindow : IBluWindow
{
    /// <summary>
    /// Gets the navigator instance for handling view navigation within the window.
    /// </summary>
    ViewNavigator ViewNavigator { get; }
}