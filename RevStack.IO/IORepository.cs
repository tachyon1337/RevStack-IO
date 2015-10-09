using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using RevStack.Pattern;

namespace RevStack.IO
{
    public class IORepository : IRepository<FileData, string>
    {
        private readonly IODataContext _context;
        public IORepository(IODataContext context)
        {
            _context = context;
        }

        public IEnumerable<FileData> Get()
        {
            return _context.Get();
        }

        public IQueryable<FileData> Find(Expression<Func<FileData, bool>> predicate)
        {
            return _context.Get().AsQueryable().Where(predicate);
        }

        public FileData Add(FileData entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(FileData entity)
        {
            throw new NotImplementedException();
        }

        public FileData Update(FileData entity)
        {
            throw new NotImplementedException();
        }
    }
}
