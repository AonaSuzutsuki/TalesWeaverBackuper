using CommonExtentionLib.Extentions;
using CommonStyleLib.File;
using CommonStyleLib.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalesWeaverBackuper.Models
{
    public class LauncherMoverModel : ModelBase
    {
        #region Properties
        public string ExecutablePathText
        {
            get => executablePathText;
            set => SetProperty(ref executablePathText, value);
        }

        public string RootPathText
        {
            get => rootPathText;
            set => SetProperty(ref rootPathText, value);
        }

        public string IconPathText
        {
            get => iconPathText;
            set => SetProperty(ref iconPathText, value);
        }
        #endregion

        #region Fields
        private string executablePathText;
        private string rootPathText;
        private string iconPathText;
        #endregion



        public void SetExecutablePath()
        {
            var filePath = FileSelector.GetFilePath(@"C:\", "実行可能ファイル (*.exe)|*.exe", "", FileSelector.FileSelectorType.Read);
            ExecutablePathText = filePath;
            RootPathText = Path.GetDirectoryName(filePath);
            IconPathText = "{0},0".FormatString(filePath);
        }

        public void UpdateRegistoryValues()
        {
            var regInfo = Registory.LauncherRegister.GetLauncherRegistoryInfo();
            ExecutablePathText = regInfo.Executable ?? "NULL";
            RootPathText = regInfo.RootPath ?? "NULL";
            IconPathText = regInfo.Icon ?? "NULL";
        }

        public void SaveRegistory()
        {
            var regInfo = new Registory.LauncherRegistoryInfo()
            {
                Executable = ExecutablePathText,
                RootPath = RootPathText,
                Icon = IconPathText
            };

            Registory.LauncherRegister.SetLauncherRegistoryInfo(regInfo);
        }
    }
}
