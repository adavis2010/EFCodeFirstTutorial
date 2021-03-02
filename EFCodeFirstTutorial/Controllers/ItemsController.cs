using EFCodeFirstTutorial.Models;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstTutorial.Controllers {

    public class ItemsController {

        private readonly AppDbContext _context;
        //default constructor


        public ItemsController() {
            _context = new AppDbContext();
        }


        //GetAll
        public async Task<IEnumerable<Item>> GetAll() {
            return await _context.Items.ToListAsync();
        }


        //Get by Primary Key
        public async Task<Item> GetByPk(int id) {
            return await _context.Items.FindAsync(id);
        }

        //Insert/ Create
        public async Task<Item> Create(Item item) {
            if (item == null) {
                throw new Exception("Input cannot be null");
            }
            if (item.Id != 0) {
                throw new Exception("Input must have Id set to zero");
            }
            _context.Items.Add(item);
            var rowsAffected = await _context.SaveChangesAsync();
            if (rowsAffected != 1) {
                throw new Exception("Create Failed!");
            }
            return item;
        }
        // Update / Change
        public async Task<Item> Change(Item item) {
            if (item == null) {
                throw new Exception("Input cannot be null");
            }
            if (item.Id != 0) {
                throw new Exception("Input must have Id greater than zero");
            }
            _context.Entry(item).State = EntityState.Modified;
            var rowsAffected = await _context.SaveChangesAsync();
            if (rowsAffected != 1) {
                throw new Exception("Change Failed!");
            }
            return item;
            //Delete / Remove
            public async Task<Item> Remove(int id) {
                var itm = await _context.Items.FindAsync(id);
                if (itm == null) {
                    throw new Exception("Cannot be found!");
                }
                _context.Items.Remove(itm);
                var rowsAffected = await _context.SaveChangesAsync();
                if (rowsAffected != 1) {
                    throw new Exception("Remove Failed");
                }
                return itm;
























            }

















        }
    }
}
