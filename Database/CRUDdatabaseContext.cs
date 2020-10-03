using System;
using CRUD.Models;
using Microsoft.EntityFrameworkCore;
namespace CRUD.Database
{
    public class CRUDdatabaseContext : DbContext
    {
        public CRUDdatabaseContext() : base()
        {
        }

        public CRUDdatabaseContext(DbContextOptions<CRUDdatabaseContext> options) : base(options)
        {

        }

        public DbSet<Data> Datas { get; set; }

    }
}
