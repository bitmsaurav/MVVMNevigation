using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmApp.Models;

//https://www.youtube.com/watch?v=USn6hgk-tLU

namespace MvvmApp.Services
{
    class PersonService
    {
        public List<Person> GetPersons()
        {
            var list = new List<Person>
            {
                new Person
                {

                    Name = "Simon Di",
                    BirthDay = DateTime.Today
                },
                 new Person
                {

                    Name = "Mello Di",
                    BirthDay = DateTime.Today
                }
            };
            return list;
        }
    }
}
