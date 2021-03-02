
using EFCodeFirstTutorial.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstTutorial.Controllers {
    public class CustomersController {

        private readonly AppDbContext _context;

        //default constructor
        public CustomersController() {
            _context = new AppDbContext();
        }

        //Get All
        public async Task<IEnumerable<Customer>> GetAll() {
            return await _context.Customers.ToListAsync();
        }

        //Get by Primary Key
        public async Task<Customer> GetByPk(int id) {
            return await _context.Customers.FindAsync(id);
        }

        //Insert /Create
        public async Task<Customer> Create(Customer customer) {
            if (customer == null) {
                throw new Exception("Input cannot be null");
            }

            if (customer.Id != 0) {
                throw new Exception("Input must have Id set to zero");
            }
            _context.Customers.Add(customer);
            var rowsAffected = await _context.SaveChangesAsync();
            if (rowsAffected != 1) {
                throw new Exception("Create Failed!");
            }
            return customer;

        }

        //Update/ Change
        public async Task Change(Customer customer) {
            if (customer == null) {
                throw new Exception("Input cannot be null");
            }
            if (customer.Id == 0) {
                throw new Exception("Input must have Id greater than zero");
            }
            _context.Entry(customer).State = EntityState.Modified;
            var rowsAffected = await _context.SaveChangesAsync();
            if (rowsAffected != 1) {
                throw new Exception("Change Failed!");
            }

            return;

        }









    }







}





