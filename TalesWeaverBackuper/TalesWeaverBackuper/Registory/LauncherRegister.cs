using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalesWeaverBackuper.Registory
{
    public class LauncherRegistoryInfo
    {
        public string Executable { get; set; }
        public string RootPath { get; set; }
        public string Icon { get; set; }
    }

    public class LauncherRegister
    {
        private const string subKey = @"SOFTWARE\Nexon\TalesWeaver";
        private const string executableKey = "Executable";
        private const string rootPathKey = "RootPath";
        private const string iconKey = "Icon";

        public static LauncherRegistoryInfo GetLauncherRegistoryInfo()
        {
            var executable = RegistoryManager.GetRegistory(subKey, executableKey, RegistryHive.LocalMachine, RegistryView.Registry32);
            var rootPath = RegistoryManager.GetRegistory(subKey, rootPathKey, RegistryHive.LocalMachine, RegistryView.Registry32);
            var icon = RegistoryManager.GetRegistory(subKey, iconKey, RegistryHive.LocalMachine, RegistryView.Registry32);

            var regInfo = new LauncherRegistoryInfo()
            {
                Executable = executable,
                RootPath = rootPath,
                Icon = icon
            };

            return regInfo;
        }

        public static void SetLauncherRegistoryInfo(LauncherRegistoryInfo regInfo)
        {
            RegistoryManager.SetRegistory(subKey, executableKey, RegistryHive.LocalMachine, RegistryView.Registry32, regInfo.Executable);
            RegistoryManager.SetRegistory(subKey, rootPathKey, RegistryHive.LocalMachine, RegistryView.Registry32, regInfo.RootPath);
            RegistoryManager.SetRegistory(subKey, iconKey, RegistryHive.LocalMachine, RegistryView.Registry32, regInfo.Icon);
        }
    }
}
