using Dal.PostGre;
using Dal.Repository.Abstract;
using Entity.Conrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Repository.Concrete
{
    class HolderRepository:BaseRepository<Holder>,IHolderRepository
    {
        public HolderRepository(Context db):base(db)
        {

        }
    }
}
