using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Caliburn.Micro;

namespace WpfProjectTemplate.Base
{
    public class ValidatableBindableBase : PropertyChangedBase, INotifyDataErrorInfo
    {
        private readonly Dictionary<string, List<string>> _errors = new Dictionary<string, List<string>>();
        public bool HasErrors => _errors.Count > 0;

        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged = delegate { };

        public ValidatableBindableBase()
        {

        }

        private void ValidateProperty<T>(string propertyName, T value)
        {
            var results = new List<ValidationResult>();
            ValidationContext context = new ValidationContext(this) { MemberName = propertyName };
            Validator.TryValidateProperty(value, context, results);

            if (results.Any())
            {
                _errors[propertyName] = results.Select(c => c.ErrorMessage).ToList();
            }
            else
            {
                _errors.Remove(propertyName);
            }
            ErrorsChanged(this, new DataErrorsChangedEventArgs(propertyName));
        }

        public System.Collections.IEnumerable GetErrors(string propertyName)
        {
            if (string.IsNullOrEmpty(propertyName))
            {
                return null;
            }

            return _errors.ContainsKey(propertyName) ? _errors[propertyName] : null;
        }

        public override bool Set<T>(ref T oldValue, T newValue, [System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            bool toReturn = base.Set(ref oldValue, newValue, propertyName);
            ValidateProperty(propertyName, newValue);
            return toReturn;
        }
    }
}
