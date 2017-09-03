using System;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmApp.Models;
using MvvmApp.Services;


namespace MvvmApp.ViewModels
{
    class PersonViewModel
    {
        private List<Person> _personList;
        public List<Person> PersonList
        {
            get { return _personList; }
            set {
                _personList = value;
                OnPerpertyChanged();
            }
        }

        public PersonViewModel()
        {
            var personServices = new PersonService();

            PersonList = personServices.GetPersons();
        }

        public event PropertyChangedEventHandler PerpertyChanged;

        public virtual void OnPerpertyChanged([CallerMemberName] string PropertyName = null)
        {
            PerpertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }

    }
}
