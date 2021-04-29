using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duello
{
    public class Expense : Budget
    {
        public Expense(string namaBudget, double jumlahUang) : base(namaBudget, jumlahUang)
        {
            
        }
        public override void LakukanPenjumlahanBudget()
        {
            tambahExpense(0, DateTime.Now, "");
        }
    }
}
