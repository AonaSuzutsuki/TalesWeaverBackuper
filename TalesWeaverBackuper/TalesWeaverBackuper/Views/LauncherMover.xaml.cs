using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TalesWeaverBackuper.Views
{
    /// <summary>
    /// LauncherMover.xaml の相互作用ロジック
    /// </summary>
    public partial class LauncherMover : Window
    {
        public LauncherMover()
        {
            InitializeComponent();

            var model = new Models.LauncherMoverModel();
            var vm = new ViewModels.LauncherMoverViewModel(this, model);
            DataContext = vm;
        }
    }
}
