using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OswalMRA.DAL
{
    public class DBRepository
    {
        readonly DBContext _context;

        public DBRepository(DBContext context)
        {
            _context = context;            
        }
    }
}
