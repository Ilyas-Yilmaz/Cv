using Dal.Repository.Abstract;
using Entity.Conrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.UnitOfWork.Abstract
{
    interface IUnitOfWork:IDisposable
    {
        IRepository<Holder> HolderRepository { get; }
        void Comit();
    }
}
