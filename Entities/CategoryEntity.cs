using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities {
    public class CategoryEntity {
        [Key]// data Notaton
        public int Id { get; set; }

        
        [Required]
        [StringLength(150)]
        public string Name { get; set; }

        // Relacion con productos
        public ICollection<ProductEntity> Products { get; set; }

        public CategoryEntity() { }
    }
}
