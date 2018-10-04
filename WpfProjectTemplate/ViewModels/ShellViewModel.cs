using Caliburn.Micro;

namespace WpfProjectTemplate.ViewModels
{
    public class ShellViewModel
    {
        private ILog _logger = LogManager.GetLog(typeof(ShellViewModel));

        public SampleViewModel SampleViewModel { get; set; } = new SampleViewModel();

        public ShellViewModel()
        {
            _logger.Info("Initializing shell view model");
        }
    }
}
