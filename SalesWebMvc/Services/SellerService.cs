using SalesWebMvc.Data;
using SalesWebMvc.Models;
using System.Collections.Generic;
using System.Linq;
<<<<<<< HEAD
using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Services.Exceptions;
=======
>>>>>>> 779b3ce9d6109d8ca99ec419388397b61fb13beb

namespace SalesWebMvc.Services
{
    public class SellerService
    {
        private readonly SalesWebMvcContext _context;

        public SellerService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public Seller FindById(int id)
        {
<<<<<<< HEAD
            return _context.Seller.Include(obj => obj.Department).FirstOrDefault(obj => obj.Id == id);
=======
            return _context.Seller.FirstOrDefault(obj => obj.Id == id);
>>>>>>> 779b3ce9d6109d8ca99ec419388397b61fb13beb
        }

        public void Remove(int id)
        {
            var obj = _context.Seller.Find(id);
            _context.Seller.Remove(obj);
            _context.SaveChanges();
        }
<<<<<<< HEAD

        public void Update(Seller obj)
        {
            if (!_context.Seller.Any(x => x.Id == obj.Id))
            {
                throw new NotFoundException("Id not found");
            }
            try
            {
                _context.Update(obj);
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
        }
    }
}

=======
    }
}
>>>>>>> 779b3ce9d6109d8ca99ec419388397b61fb13beb
