using MyFinances.Logic.Enams;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinances.Logic.Models {
    internal class AccountsFinanseModel {

        public int Id { get; set; }

        public string Name { get; set; } //Name accounts finanse has the string length is 150 characters

        public string Currency { get; set; } 

        public decimal Balance { get; set; }

        public ClientsFinanseType Type { get; set; } // List types in "Enam/ClientsFinanseType"

    }
}
