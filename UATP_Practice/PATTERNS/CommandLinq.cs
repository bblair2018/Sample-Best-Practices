using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace UATP_Practice.PATTERNS
{
    // Command interface
    public interface IDbLinqCommand<T>
    {
        IEnumerable<T> Execute();
    }

    // Concrete Command class
    public class LinqQueryCommand<T> : IDbLinqCommand<T>
    {
        private readonly DbContextOptions _dbContextOptions;

        //Delegate type that represents a method accepting a DbContext parameter and returning an IEnumerable<T> result.
        private readonly Func<DbContext, IEnumerable<T>> _linqQuery;

        public LinqQueryCommand(DbContextOptions dbContextOptions, Func<DbContext, IEnumerable<T>> linqQuery)
        {
            _dbContextOptions = dbContextOptions;
            _linqQuery = linqQuery;
        }

        public IEnumerable<T> Execute()
        {
            using (DbContext dbContext = new DbContext(_dbContextOptions))
            {
                return _linqQuery.Invoke(dbContext);
            }
        }
    }

    // Customer entity
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        // Other properties...
    }

    // DbContext
    public class MyDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        public MyDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
