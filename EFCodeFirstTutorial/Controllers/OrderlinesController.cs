using EFCodeFirstTutorial.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstTutorial.Controllers {
    public class OrderlinesController {

        private readonly AppDbContext _context;

        //default constructor
        public OrderlinesController() {
            _context = new AppDbContext();
        }

        //Get All
        public async Task<IEnumerable<Orderline>> GetAll() {
            return await _context.Orderlines.ToListAsync();
        }

        //Get by Primary Key
        public async Task<Orderline> GetByPk(int id) {
            return await _context.Orderlines.FindAsync(id);
        }

        //Insert /Create
        public async Task<Orderline> Create(Orderline orderline) {
            if (orderline == null) {
                throw new Exception("Input cannot be null");
            }

            if (orderline.Id != 0) {
                throw new Exception("Input must have Id set to zero");
            }
            _context.Orderlines.Add(orderline);
            var rowsAffected = await _context.SaveChangesAsync();
            if (rowsAffected != 1) {
                throw new Exception("Create Failed!");
            }
            return orderline;

        }


        //Delete/ Remove
        public async Task<Orderline> Remove(int id) {
            var orderline = await _context.Orderlines.FindAsync(id);
            if (orderline == null) {
                throw new Exception("Cannot be found!");
            }
            _context.Orderlines.Remove(orderline);
            var rowsAffected = await _context.SaveChangesAsync();
            if (rowsAffected != 1) {
                throw new Exception("Remove Failed");
            }
            return orderline;

        }








    }

    }

