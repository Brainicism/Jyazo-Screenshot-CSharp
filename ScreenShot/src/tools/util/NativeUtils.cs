﻿using System;
using System.Runtime.InteropServices;
using System.Text;
// ReSharper disable UnusedMember.Global

namespace ScreenShot.src.tools.util
{
    public static class NativeUtils
    {
        [DllImport("user32.dll")]
        public static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

        [DllImport("user32.dll")]
        public static extern bool GetWindowRect(IntPtr hwnd, ref Rect rectangle);

        public struct Rect
        {
            public int Left { get; set; }

            public int Top { get; set; }

            public int Right { get; set; }

            public int Bottom { get; set; }
        }
    }
}
