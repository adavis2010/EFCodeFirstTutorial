using EFCodeFirstTutorial.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstTutorial.Controllers {
    class OrdersController {

        private readonly AppDbContext _context;

        //default constructor
        public OrdersController() {
            _context = new AppDbContext();
        }
        //Get All
        public async Task<IEnumerable<Order>> GetAll() {
            return await _context.Orders.ToListAsync();
        }

        //Get by Primary Key
        public async Task<Order> GetByPk(int id) {
            return await _context.Orders.FindAsync(id);
        }

        //Insert /Create
        public async Task<Order> Create(Order order) {
            if (order == null) {
                throw new Exception("Input cannot be null");
            }

            if (order.Id != 0) {
                throw new Exception("Input must have Id set to zero");
            }
            _context.Orders.Add(order);
            var rowsAffected = await _context.SaveChangesAsync();
            if (rowsAffected != 1) {
                throw new Exception("Create Failed!");
            }
            return order;

        }

        //Update/ Change
        public async Task Change(Order order) {
            if (order == null) {
                throw new Exception("Input cannot be null");
            }
            if (order.Id == 0) {
                throw new Exception("Input must have Id greater than zero");
            }
            _context.Entry(order).State = EntityState.Modified;
            var rowsAffected = await _context.SaveChangesAsync();
            if (rowsAffected != 1) {
                throw new Exception("Change Failed!");
            }

            return;

        }


        //Delete/ Remove
        public async Task<Order> Remove(int id) {
            var order = await _context.Orders.FindAsync(id);
            if (order == null) {
                throw new Exception("Cannot be found!");
            }
            _context.Orders.Remove(order);
            var rowsAffected = await _context.SaveChangesAsync();
            if (rowsAffected != 1) {
                throw new Exception("Remove Failed");
            }
            return order;

        }



















    }

}
