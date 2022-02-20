using Dal.PostGre;
using Dal.Repository.Abstract;
using Dal.Repository.Concrete;
using Dal.UnitOfWork.Abstract;
using Entity.Conrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.UnitOfWork.Concrete
{
   public class UnitOfWork:IUnitOfWork
    {
        private Context _context;
        public UnitOfWork(Context context)
        {
            _context = context;
            HolderRepository = new HolderRepository(_context);
        }
        public IRepository<Holder> HolderRepository { get; private set; }
        public void Comit()
        {
            _context.SaveChanges();
        }
      
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
