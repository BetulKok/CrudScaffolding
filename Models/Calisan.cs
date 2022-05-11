using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CrudScaffolding.Models
{
    public class Calisan
    {
        public int Id { get; set; }
        [Required , MaxLength(50)]
        public string Ad { get; set; }
        [Required, MaxLength(50)]
        public string Soyad { get; set; }
        [ForeignKey("DogumYeri")]
        public int DogumYeriId { get; set; }

        public Sehir DogumYeri { get; set; }
    }
}
