using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bank_transection_using_crud.Models
{
    public class Transection
    {
        internal readonly int id;

        [Key]
        public int  Transectionid { get; set; }
        [Column( TypeName = "varchar(100)")]
        [Required]
        public string Accountnumber { get; set; }
        [Column( TypeName = "varchar(100)")]
        [Required]
        public string Beneficiaryname { get; set; }
        [Column( TypeName = "varchar(100)")]
        [Required]
        public string Bankname { get; set; }
        [Column( TypeName = "varchar(100)")]
        [Required]
        public string Swiftcode { get; set; }
        [Column( TypeName = "varchar(100)")]
        [Required]
        public int Amount { get; set; }
        [Column( TypeName = "varchar(100)")]
        [Required]
        public DateTime Date { get; set; }
    }
}
