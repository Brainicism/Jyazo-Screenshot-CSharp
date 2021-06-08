﻿using System;
using System.IO;

namespace ScreenShot.src.tools
{
    public static class Constants
    {
        private static readonly string SAVE_DIRECTORY = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\" + CREATOR + "\\" + PROGRAM_NAME + "\\";

        private const string PROGRAM_NAME = "Jyazo";

        private const string CREATOR = "ArkaPrime";

        public const string GITHUB = "https://github.com/sabihismail/Jyazo-Screenshot/tree/master/server";

        public const string DEFAULT_IMAGE_SHORTCUT = "Ctrl Shift C";

        public const string DEFAULT_GIF_SHORTCUT = "Ctrl Shift G";

        public static readonly string DEFAULT_ALL_IMAGES_FOLDER = SAVE_DIRECTORY + "All Images\\";

        public static readonly string SETTINGS_FILE =
#if DEBUG
            Directory.GetCurrentDirectory() + "\\settings.json";
#else
            SAVE_DIRECTORY + "settings.json"
#endif

        public static readonly string CONFIG_FILE =
#if DEBUG
            Directory.GetCurrentDirectory() + "\\config.json";
#else
            SAVE_DIRECTORY + "config.json"
#endif


        public const string API_ENDPOINT_IS_AUTHORIZED = "isAuthorized";

        public const string API_ENDPOINT_UPLOAD_SCREENSHOT = "uploadScreenShot";

        public const string USER_AGENT = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/90.0.4430.212 Safari/537.36 Edg/90.0.818.66";
    }
}
