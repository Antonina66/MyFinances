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
        private Dictionary<int, ExpenseFinanseModel > _expenseFinanses;

        private int _transactionCategoryLastId =1;

        private int _accountsFinansesLastId = 1;

        public DataStorage() {

            _transactionCategories = new Dictionary<int, TransactionCategoryModel>();
            _accountsFinanses = new Dictionary<int, AccountsFinanseModel>();
            _expenseFinanses = new Dictionary<int, ExpenseFinanseModel>();
        }


        //Category
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

        //AccountFinanse
        public void AddAccountFinanse(AccountsFinanseModel account) {
            account.Id = _accountsFinansesLastId;

            _accountsFinanses.Add(_accountsFinansesLastId, account);
            _accountsFinansesLastId++;
        }
}

    
}
