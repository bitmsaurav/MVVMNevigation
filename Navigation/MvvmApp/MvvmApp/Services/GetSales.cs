using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmApp.Models;
using MvvmApp.ViewModels;

//https://www.youtube.com/watch?v=USn6hgk-tLU

namespace MvvmApp.Services
{
    class SalesService
    {
        public List<Sales> GetSales()
        {
            var list = new List<Sales>
            {
                new Sales
                {
                    Id = 1,
                    Name = "Milk"
                },
                new Sales
                {
                    Id = 1,
                    Name = "Milk"
                },
                new Sales
                {
                    Id = 1,
                    Name = "Milk"
                },
                new Sales
                {
                    Id = 1,
                    Name = "Milk"
                }
            };
            return list;
        }
    }
}
