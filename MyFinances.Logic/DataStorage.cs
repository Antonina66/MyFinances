using MyFinances.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinances.Logic {
    public class DataStorage {

        private Dictionary<int, TransactionCategoryModel> _transactionCategories;
        private Dictionary<int, AccountsFinanseModel> _accountsFinanses;
        private Dictionary<int, ExpensesFinanseModel> _expensesFinanses;

        private int _transactionCategoryLastId;
        private int _accountsFinansesLastId;
        private int _expensesFinansesLastId;

        public DataStorage() {

            _transactionCategories = new Dictionary<int, TransactionCategoryModel>();
            _accountsFinanses = new Dictionary<int, AccountsFinanseModel>();
            _expensesFinanses = new Dictionary<int, ExpensesFinanseModel>();

            _transactionCategoryLastId = 1;
            _accountsFinansesLastId = 1;
            _expensesFinansesLastId = 1;
        }


        //Category Transaction (Категории транзакций)
        public void AddCategory(TransactionCategoryModel category) {

            category.Id = _transactionCategoryLastId;

            _transactionCategories.Add(category.Id, category);
            _transactionCategoryLastId++;

        }

        public void DatachCateroryById(int id) {

            _transactionCategories.Remove(id);

        }

        public TransactionCategoryModel GetTransactionCategoryById(int id) {

            return _transactionCategories[id];
        }

        public List<TransactionCategoryModel> GetAllTransactionCategories() {

            return _transactionCategories.Values.ToList();
        }


        //Account Finanse (Финансовые счета)
        public void AddAccount(AccountsFinanseModel account) {

            account.Id = _accountsFinansesLastId;

            _accountsFinanses.Add(account.Id, account);
            _accountsFinansesLastId++;

        }

        public void DatachAccountById(int id) {

            _accountsFinanses.Remove(id);
        }

        public AccountsFinanseModel GetAccountsFinanseModelById(int id) {

            return _accountsFinanses[id];
        }

        public List<AccountsFinanseModel> GetAllAccountsFinanse() {

            return _accountsFinanses.Values.ToList();
        }


        //Expense Finanses (Траты)
        public void AddExpenses(ExpensesFinanseModel expenses) {

            expenses.Id = _expensesFinansesLastId;

            _expensesFinanses.Add(expenses.Id, expenses);
            _expensesFinansesLastId++;
        }

        public void DatachExpensesById(int id) {

            _expensesFinanses.Remove(id);
        }

        public ExpensesFinanseModel GetExpensesFinanseModelById(int id) {

            return _expensesFinanses[id];
        }

        public List<ExpensesFinanseModel> GetAllExpensesFinanses() {

            return _expensesFinanses.Values.ToList();
        }

    }
}
