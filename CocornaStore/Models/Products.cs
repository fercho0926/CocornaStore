using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CocornaStore.Models
{
    public class Products

    {


        [Key]
        public int Id { get; set; }
        [Required, StringLength(80)]
        public string Name { get; set; }

        [Required, StringLength(80)]
        public string Brand { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:N0} ")]
        public double Price { get; set; }
        [Required]

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy -  HH:mm:ss}")]
        public DateTime DateUpdate { get; set; }
    }

}
