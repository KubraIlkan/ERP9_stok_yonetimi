using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Sy.Core.Entities;
using Sy.Core.ComplexTypes;
using Sy.Core.Abstracts;

namespace Sy.DataAccess
{
   public class StokDbContext: DbContext
    {
        public StokDbContext()
            : base (nameOrConnectionString: "name= MyCon")
        {  
        }
        public override int SaveChanges()
        {
            if (StockSettings.UserInfo != null)
            {
                var selectedEntityList = ChangeTracker.Entries().Where(x => x.Entity is AuditBase && x.State == EntityState.Added);
                foreach (var item in selectedEntityList)
                {
                    ((AuditBase) item.Entity).CreatedUser = StockSettings.UserInfo.Email;
                    ((AuditBase)item.Entity).CreatedDate = DateTime.Now;
                }
                selectedEntityList = ChangeTracker.Entries().Where(x => x.Entity is AuditBase && x.State == EntityState.Modified);
                foreach (var item in selectedEntityList)
                {
                    ((AuditBase)item.Entity).UpdatedUser = StockSettings.UserInfo.Email;
                    ((AuditBase)item.Entity).UpdatedDate = DateTime.Now;
                }
            }
            return base.SaveChanges();
        }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
    }
}
