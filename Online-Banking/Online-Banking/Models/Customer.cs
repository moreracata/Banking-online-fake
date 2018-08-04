using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Online_Banking.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }


        public ApplicationUser User;
        public List<BankAccount> BankAccounts { get; set; }
    }
}