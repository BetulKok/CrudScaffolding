using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudScaffolding.Models
{
    public class Sehir
    {
        public int Id { get; set; }
        [Required, MaxLength(50)]
        public string  Ad { get; set; }

        public List<Calisan> Calisanlar { get; set; }


    }
}
