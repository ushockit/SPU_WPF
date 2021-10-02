using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Commands;
using WpfApp1.Models;

namespace WpfApp1.ViewModels
{
    public class MainWindowViewModel : BaseModel
    {
        PersonModel _selectedPerson;
        bool _btnRemoveIsEnabled = false;


        ActionCommand _removeCommand;
        ActionCommand _addCommand;

        public ActionCommand RemoveCommand
        {
            get
            {
                return _removeCommand ?? (_removeCommand = new ActionCommand((obj) =>
                {
                    PersonModel person = obj as PersonModel;
                    People.Remove(person);
                }));
            }
        }

        public ActionCommand AddCommand
        {
            get
            {
                return _addCommand ?? (_addCommand = new ActionCommand((obj) =>
                {
                    // TODO: Add a new person
                }));
            }
        }


        public ObservableCollection<PersonModel> People { get; set; } = new ObservableCollection<PersonModel>
        {
            new PersonModel
            {
                Id = 1,
                FirstName = "First name 1",
                LastName = "Last name 1",
                Birth = new DateTime(1990, 10, 10)
            },
            new PersonModel
            {
                Id = 2,
                FirstName = "First name 2",
                LastName = "Last name 2",
                Birth = new DateTime(1979, 02, 22)
            },
            new PersonModel
            {
                Id = 3,
                FirstName = "First name 3",
                LastName = "Last name 3",
                Birth = new DateTime(1983, 06, 11)
            }
        };
        public bool BtnRemoveIsEnabled
        {
            get => _btnRemoveIsEnabled;
            set
            {
                if (value != _btnRemoveIsEnabled)
                {
                    _btnRemoveIsEnabled = value;
                    OnPropertyChanged(nameof(BtnRemoveIsEnabled));
                }
            }
        }

        public PersonModel SelectedPerson
        {
            get => _selectedPerson;
            set
            {
                BtnRemoveIsEnabled = value is not null;
                _selectedPerson = value;
                OnPropertyChanged(nameof(SelectedPerson));
            }
        }
    }
}
