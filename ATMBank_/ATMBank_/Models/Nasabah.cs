using System.ComponentModel.DataAnnotations;

namespace ATMBank_.Models
{
    public class Nasabah
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string? NamaNasabah { get; set; }

        [Required]
        [Range(111, 999)]
        public int NoRekening{ get; set; }

        [Required]
        public int Saldo { get; set; }
    }
}
