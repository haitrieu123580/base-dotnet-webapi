using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace s002API.Models
{
    public class Supplier
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(80)]
        public string Name { get; set; }
        public string Code { get; set; }
        public string DebtCode { get; set; }
        [StringLength(10)]
        public string Phone { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Ward { get; set; }
        public string Address { get; set; }
        public string Status { get; set; }
        public ICollection<SupplierCategory> SupplierCategories { get; set; }
    }
}