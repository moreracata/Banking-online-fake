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
        public TypeAccount TypeAccount { get; set; }

        public int CustomerID { get; set; }
        [ForeignKey("CustomerID")]
        public Customer Customer;
    }
}