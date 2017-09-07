using System;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Collections.Generic;
using Rg.Plugins.Popup.Services;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmApp.Models;
using MvvmApp.Services;
using MvvmApp.Views;
using Xamarin.Forms;


namespace MvvmApp.ViewModels
{
    class PersonViewModel
    {
        private List<Person> _personList;
        private readonly ModalDatePickerView _modalDatePicker;

        public Command ShowMyDatePicker { get; set; }

        public Person Simon { get; set; }

        public List<Person> PersonList
        {
            get { return _personList; }

            set
            {
                if (_personList != value)
                {
                    _personList = value;
                    OnPropertyChanged();
                }
            }
        }

        public PersonViewModel()
        {
            var personServices = new PersonService();
            PersonList = personServices.GetPersons();

            ShowMyDatePicker = new Command(async () =>
            {
                await ShowDatePicker(() => Simon.BirthDay?? DateTime.Now,
                    d => Simon.BirthDay = d);
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged([CallerMemberName] string PropertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }

        private async Task ShowDatePicker(Func<DateTime> getter, Action<DateTime> setter)
        {
            var viewModel = (ModalDatePickerViewModel)_modalDatePicker.BindingContext;
            viewModel.SelectedDate = getter.Invoke();
            viewModel.Command = new Command(async () =>
            {
                setter.Invoke(viewModel.SelectedDate);
                OnPropertyChanged(nameof(Simon));
                await PopupNavigation.PopAsync();
            });
            await PopupNavigation.PushAsync(_modalDatePicker);
        }
    }
}
