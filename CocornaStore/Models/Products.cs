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
        public double Price { get; set; }
        [Required]
        public DateTime DateUpdate { get; set; }
    }

}
