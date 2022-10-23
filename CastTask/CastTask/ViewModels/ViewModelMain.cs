using CastTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CastTask.ViewModels
{
    public class ViewModelMain : ViewModelBase
    {
        public ViewModelBase CurrentViewModel { get; }

        public ViewModelMain(CastAppModel castApp)
        {
            CurrentViewModel = new ViewModelControls(castApp);
        }

    }
}
