using DristisBooks.DataAccess.Repository.IRepository;
using DristisBooks.Models;
using DristisBooksStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DristisBooks.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork  //make the method public to access the class
    {
        private readonly ApplicationDbContext _db;      //the using statemnet

        public UnitOfWork(ApplicationDbContext db)      //constructor to use DI and inject in to the repositories
        {
            _db = db;
            Category = new CategoryRepository(_db);

            CoverType = new CoverTypeRepository(_db);

            Product = new ProductRepository(_db);

            SP_Call = new SP_Call(_db);


        }

        public ICategoryRepository Category { get; private set; }
        public ISP_Call SP_Call { get; private set; }

       public IProductRepository Product { get; private set; }
        public ICoverTypeRepository CoverType { get; private set; }


       

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()
        {
            _db.SaveChanges();        //all changes will be saved when the Save method is called at the 'parent' level
        }
    }
}
