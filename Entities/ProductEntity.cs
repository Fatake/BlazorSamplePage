using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities{
    public class ProductEntity {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        public int TotalQuantity { get; set; }

        // Relacion con categoria
        public int CategoryId { get; set; }
        public CategoryEntity Cat { get; set; }


        // Relacion con Almacenamiento
        public ICollection<StorageEntity> Storages { get; set; }

        // Constructor
        public ProductEntity() { }
    }
}
