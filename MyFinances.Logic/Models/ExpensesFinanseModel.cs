using MyFinances.Logic.Enams;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinances.Logic.Models {
    public class ExpensesFinanseModel {

        public int Id { get; set; }

        public string Name { get; set; } //Name accounts finanse has the string length is 150 characters

        public TransactionType TransactionType { get; set; } // Is true "+" and is false "-"

        public decimal Sum { get; set; }

        public DateTime Date { get; set; }

        public int AccountsFinanseId { get; set; }

        public int CategoryId { get; set; }
    }
}
