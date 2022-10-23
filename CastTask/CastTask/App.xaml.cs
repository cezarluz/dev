using CastTask.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace CastTask
{
    public enum Direction { UP, DOWN, LEFT, RIGHT };
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public CastAppModel _castApp; 

        public App()
        {
            _castApp = new CastAppModel();  
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow()
            {
                DataContext = new ViewModels.ViewModelMain(_castApp)
            };

            MainWindow.Show();
            base.OnStartup(e);
        }
    }
}
