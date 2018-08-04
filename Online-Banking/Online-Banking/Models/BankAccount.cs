using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Online_Banking.Models
{
    public class BankAccount
    {
        public int Id { get; set; }
        public int Balance { get; set; }

        public int TypeId { get; set; }
        [ForeignKey("TypeId")]
        public TypeAccount TypeAccount { get; set; }

        public int CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public Customer Customer;
    }
}