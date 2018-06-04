using CommonStyleLib.Models;
using CommonStyleLib.ViewModels;
using Prism.Commands;
using Reactive.Bindings;
using Reactive.Bindings.Extensions;
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
    public class LauncherMoverViewModel : ViewModelBase
    {
        public LauncherMoverViewModel(Window view, LauncherMoverModel model) : base(view, model)
        {
            this.model = model;

            ExecutablePathText = model.ToReactivePropertyAsSynchronized(m => m.ExecutablePathText);
            RootPathText = model.ToReactivePropertyAsSynchronized(m => m.RootPathText);
            IconPathText = model.ToReactivePropertyAsSynchronized(m => m.IconPathText);

            GetExecutablePathBtClicked = new DelegateCommand(GetExecutablePathBt_Clicked);
            SaveBtClicked = new DelegateCommand(SaveBt_Clicked);

            base.DoLoaded();
        }

        #region Fields
        private LauncherMoverModel model;
        #endregion

        #region Properties
        public ReactiveProperty<string> ExecutablePathText { get; set; }
        public ReactiveProperty<string> RootPathText { get; set; }
        public ReactiveProperty<string> IconPathText { get; set; }
        #endregion

        #region Event Properties
        public ICommand GetExecutablePathBtClicked { get; set; }
        public ICommand SaveBtClicked { get; set; }
        #endregion

        #region Event Methods
        protected override void MainWindow_Loaded()
        {
            model.UpdateRegistoryValues();
        }


        public void GetExecutablePathBt_Clicked()
        {
            model.SetExecutablePath();
        }

        public void SaveBt_Clicked()
        {
            model.SaveRegistory();
        }
        #endregion
    }
}
