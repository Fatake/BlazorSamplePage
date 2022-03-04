using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities {
    public class InOutsEntity {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime Date { get; set; }

        public int Quantity { get; set; }
        public bool IsInput { get; set; }

        // Relacion con almacenamiento
        public int StorageID { get; set; }
        public StorageEntity Storage { get; set; }
    }
}
