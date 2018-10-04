using Caliburn.Micro;
using WpfProjectTemplate.Base;
using WpfProjectTemplate.Utility;
using WpfProjectTemplate.ViewModels;

namespace WpfProjectTemplate
{
    public class AppBootstrapper : AutofacBootstrapper
    {

        private ILog _logger = LogManager.GetLog(typeof(AppBootstrapper));

        static AppBootstrapper()
        {
            LogManager.GetLog = type => new DebugLogger(type);
        }

        public AppBootstrapper() {
            _logger.Info("Initializing AppBootstrapper");
            Initialize();
        }

        protected override void OnStartup(object sender, System.Windows.StartupEventArgs e) {
            DisplayRootViewFor<ShellViewModel>();
        }
    }
}