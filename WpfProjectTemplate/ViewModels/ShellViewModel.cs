using Caliburn.Micro;
using System.ComponentModel.DataAnnotations;
using WpfProjectTemplate.Base;

namespace WpfProjectTemplate {
    public class ShellViewModel : ValidatableBindableBase
    {
        private readonly ILog _log = LogManager.GetLog(typeof(ShellViewModel));


        private string _name;

        [Required]
        [StringLength(10)]
        public string Name
        {
            get => _name;
            set
            {
                Set(ref _name, value);
            }

        }

        public ShellViewModel()
        {
            _log.Info("ShellViewModel created");
        }

    }
}