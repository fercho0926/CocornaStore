using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CocornaStore.Models
{
    public class Products

    {
        [Key] public int Id { get; set; }

        [Required, StringLength(80), Display(Name = "Nombre")]
        public string Name { get; set; }

        [Required, StringLength(80), Display(Name = "Marca")]
        public string Brand { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:N0} "), Display(Name = "Precio")]
        public double Price { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy -  HH:mm:ss}"), Display(Name = "Fecha Actualizacion")]
        public DateTime DateUpdate { get; set; }
    }
}