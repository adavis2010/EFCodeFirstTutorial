using System;
using EFCodeFirstTutorial.Models;
using System.Linq;
using System.Threading.Tasks;
using EFCodeFirstTutorial.Controllers;

namespace EFCodeFirstTutorial {
    class Program {
        //Add async to make it Asynchronous
        public static async Task Main(string[] args) {

            //Add data to customers table
            var Customer = new Customer[]{
                new Customer {Id = 1, Code ="AMZ", Name = "Amazon", IsNational = true, Sales = 987654, Created = new DateTime(2021, 3, 2)},

                new Customer {Id = 2, Code ="WAL", Name = "Walmart", IsNational = true, Sales = 123456, Created = new DateTime(2021,3,1)}

                
            };


            //Get All for Customers Controller
            //var custc = new CustomersController();
           // var customers = await custc.GetAll();
            //foreach (var c in customers) {
              //  Console.WriteLine($" {c.Id} {c.Code} {c.Name} {c.IsNational} {c.Sales} {c.Created}");
           // }

        }








    }
}






