using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Models
{
    public class PersonModel : BaseModel
    {
        string _firstName = string.Empty;
        string _lastName = string.Empty;
        DateTime _birth = DateTime.Now;

        public int Id { get; set; }
        public string FirstName
        {
            get => _firstName;
            set
            {
                if (!value.Equals(_firstName))
                {
                    _firstName = value;
                    OnPropertyChanged(nameof(FirstName));
                }
            }
        }
        public string LastName
        {
            get => _lastName;
            set
            {
                if (!value.Equals(_lastName))
                {
                    _lastName = value;
                    OnPropertyChanged(nameof(LastName));
                }
            }
        }
        public DateTime Birth
        {
            get => _birth;
            set
            {
                if (value != _birth)
                {
                    _birth = value;
                    OnPropertyChanged(nameof(Birth));
                }
            }
        }
    }
}
