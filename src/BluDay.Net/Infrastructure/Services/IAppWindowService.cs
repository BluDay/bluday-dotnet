﻿namespace BluDay.Net.Services;

public interface IAppWindowService
{
    IWindow? MainWindow { get; }

    int WindowCount { get; }

    IEnumerable<IWindow> Windows { get; }

    IWindow CreateWindow();

    bool HasWindow(IWindow window);
}