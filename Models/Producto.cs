using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace EMPRESA_QBE.Models
{
    [Table("t_producto")]
    public class Producto
    {
        
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("Name")]
        public string Name { get; set; }

        [Column("Descripcion")]
        public string Descripcion { get; set; }

        [Column("Precio")]
        public Decimal Precio { get; set; }

        [Column("ImageName")]
        public String ImageName { get; set; }

        [Column("Marca")]
        public String Marca { get; set; }
    
    }
}