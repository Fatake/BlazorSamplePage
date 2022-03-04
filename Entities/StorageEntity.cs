using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities {
    public class StorageEntity {
        [Key]
        public int Id { get; set; }
        public DateTime LastUpdate { get; set; }

        public int PartialQuantity { get; set; }


        // Relacion con produtos
        public int ProductId { get; set; }
        public ProductEntity Product { get; set; }


        // Relacion con bodegas
        public int WarehouseID { get; set; }
        public WarehouseEntity Warehouse { get; set; }


        // Relación con movimientos
        public ICollection<InOutsEntity> InOuts { get; set; }

    }
}
