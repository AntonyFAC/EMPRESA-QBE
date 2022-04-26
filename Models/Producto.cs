using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMPRESA_QBE.Models
{
    public class Producto
    {
        [Table("t_producto")]
   
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }
        public string Name { get; set; }

        public string Descripcion { get; set; }

        public Decimal Precio { get; set; }

        public String Categoria { get; set; }

        public String ImageName { get; set; }

        public String Marca { get; set; }
    
    }
}