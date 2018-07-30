using CommonStyleLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalesWeaverBackuper.Models
{
    public class MainWindowModel : ModelBase
    {

        public void ShowLauncherRegister()
        {
            var register = new Views.LauncherMover();
            register.Show();
        }
    }
}
