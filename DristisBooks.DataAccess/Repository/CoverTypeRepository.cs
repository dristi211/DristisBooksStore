/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
*/
using System.Threading.Tasks;
using DristisBooks.DataAccess.Repository.IRepository;
using DristisBooks.Models;
using DristisBooksStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DristisBooks.DataAccess.Repository
{
  /*public class CoverTypeRepository : Repository<CoverType>, ICoverTypeRepository
    {
        private readonly ApplicationDbContext _db;

        public CoverTypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(CoverType coverType)
        {
            var objFromDb = _db.CoverTypes.FirstOrDefault(s => s.Id == coverType.Id);
            if (objFromDb != null)  //save changes if not null
            {
                objFromDb.Name = coverType.Name;
                //_db.SaveChanges();                  //as instructed to remove
            }
        }

    }*/
}

