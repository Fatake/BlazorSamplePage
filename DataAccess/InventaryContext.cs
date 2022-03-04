using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess {
    public class InventaryContext:DbContext {
        // Capa de acceso a datos

        // Referencia de las tablas y Entidades
        public DbSet<ProductEntity> T_Products { get; set; }
        public DbSet<CategoryEntity> T_Categories { get; set; }
        public DbSet<InOutsEntity> T_InOuts { get; set; }
        public DbSet<StorageEntity> T_Storages { get; set; }
        public DbSet<WarehouseEntity> T_Warehouses { get; set; }

    }
}
