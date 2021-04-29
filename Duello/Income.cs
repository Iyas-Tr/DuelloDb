using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duello
{
    public class Income : Budget
    {
        public Income(string namaBudget, double jumlahUang) : base(namaBudget, jumlahUang)
        {

        }
         
        public override void LakukanPenjumlahanBudget()
        {
            tambahIncome(0, DateTime.Now, "");
        }
    }
}
