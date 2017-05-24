namespace Lean.Test.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Users")]
    public partial class ProductInvoice
    {
        [Key]
        public int? UserID { get; set; }

        [StringLength(200)]
        public string FullName { get; set; }

        [StringLength(20)]
        public string UserName { get; set; }

        [StringLength(20)]
        public string PassWord { get; set; }

        public DateTime? Modified { get; set; }
    }
}

