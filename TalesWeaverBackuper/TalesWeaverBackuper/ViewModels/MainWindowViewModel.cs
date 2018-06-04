using CommonStyleLib.Models;
using CommonStyleLib.ViewModels;
using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using TalesWeaverBackuper.Models;

namespace TalesWeaverBackuper.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel(Window view, MainWindowModel model) : base(view, model)
        {
            this.model = model;



            LauncherRegisterBtClicked = new DelegateCommand(LauncherRegisterBt_Clicked);

            DoLoaded();
        }

        #region Fields
        private MainWindowModel model;
        #endregion

        #region Properties

        #endregion

        #region Event Properties
        public ICommand LauncherRegisterBtClicked { get; set; }
        #endregion

        #region Event Methods


        public void LauncherRegisterBt_Clicked()
        {
            model.ShowLauncherRegister();
        }
        #endregion
    }
}
