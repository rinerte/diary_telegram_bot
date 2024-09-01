using DataLayer.Interfaces;

namespace DataLayer.Services
{
    public partial class DBService : IDBService
    {
        DBContext _context;
        public DBService(DBContext context)
        {
            _context = context;
        }

        public void Dispose()
        {
            try
            {
                _context.Dispose();
            }
            catch { }
        }
    }
}
