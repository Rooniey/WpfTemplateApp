using Caliburn.Micro;
using WpfProjectTemplate.Models;

namespace WpfProjectTemplate.ViewModels
{
    public class SampleViewModel
    {
    
        public SampleModel Model { get; set; }

        private ILog _logger = LogManager.GetLog(typeof(SampleViewModel));

        public SampleViewModel()
        {
            Model = new SampleModel();
        }

    }
}
