using System.ComponentModel.DataAnnotations;
using WpfProjectTemplate.Base;

namespace WpfProjectTemplate.Models
{
    public class SampleModel : ValidatableBindableBase
    {
        [Required]
        [StringLength(10)]
        private string _name;

        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }

        [Required]
        [EmailAddress]
        private string _email;

        public string Email
        {
            get => _email;
            set => SetProperty(ref _email, value);
        }

    }
}
