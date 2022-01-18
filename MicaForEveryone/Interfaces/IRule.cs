﻿using Vanara.PInvoke;

using MicaForEveryone.Models;

namespace MicaForEveryone.Interfaces
{
    public interface IRule
    {
        string Name { get; }
        
        bool IsApplicable(HWND windowHandle);

        TitlebarColorMode TitlebarColor { get; set; }
        BackdropType BackdropPreference { get; set; }
        bool ExtendFrameIntoClientArea { get; set; }
    }
}