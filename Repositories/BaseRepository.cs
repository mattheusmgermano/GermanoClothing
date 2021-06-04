using GermanoClothing.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GermanoClothing.Repositories
{
    public class BaseRepository<T> where T : BaseModel
    {
        protected readonly ApplicationContext _context;
        protected readonly DbSet<T> dbSet;
        public BaseRepository(ApplicationContext context)
        {
            _context = context;
            dbSet = _context.Set<T>();
        }

    }
}
