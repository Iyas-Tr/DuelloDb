using System;
using System.Linq;
using Duello.Data;
using Microsoft.EntityFrameworkCore;

namespace Duello
{
    class Program
    {
        static void Main(string[] args)
        {
            using BudgetDatabase context = new BudgetDatabase();

            Console.WriteLine("Selamat datang di aplikasi budgeting anak kos Duello\nSilakan masukkan nama budget anda");
            string namaBudget = Console.ReadLine();
            Console.WriteLine("Silakan masukkan jumlah uang dari budget anda");
            double jumlahUang = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Budget dengan nama {namaBudget} dan jumlah {jumlahUang} IDR sudah dibuat!");
            var budget1 = new Budget(namaBudget, jumlahUang);
            budget1.tambahIncome(jumlahUang, DateTime.Now, "inisialisasi budget");
            context.Budgets.Add(budget1);
            context.SaveChanges();

            Console.WriteLine("Selamat datang di menu utama. Silakan pilih apa yang ingin anda lakukan");
            bool Exit = false;
            while (!Exit)
            {
                Console.WriteLine("Masukkan 1 untuk tambah income.\n2 untuk tambah expense.");
                Console.WriteLine("3 untuk melihat seluruh income dan expense.\n4 untuk keluar dari aplikasi.");
                int i = Convert.ToInt32(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        Console.WriteLine("Masukkan nama income");
                        string namaIncome = Console.ReadLine();
                        Console.WriteLine("Masukkan jumlah income");
                        double jumlahIncome = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"Income {namaIncome} dengan jumlah {jumlahIncome} IDR sudah dimasukkan");
                        budget1.tambahIncome(jumlahIncome, DateTime.Now, namaIncome);
                        var income = new Income(namaIncome, jumlahIncome);
                        context.SaveChanges();
                        Exit = false;
                        break;

                    case 2:
                        Console.WriteLine("Masukkan nama expense");
                        string namaExpense = Console.ReadLine();
                        Console.WriteLine("Masukkan jumlah expense");
                        double jumlahExpense = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"Expense {namaExpense} dengan jumlah {jumlahExpense} IDR sudah dimasukkan");
                        budget1.tambahExpense(jumlahExpense, DateTime.Now, namaExpense);
                        var expense = new Expense(namaExpense, jumlahExpense);
                        context.SaveChanges();
                        Exit = false;
                        break;

                    case 3:
                        Console.WriteLine(budget1.GetBudgetHistory());
                        Exit = false;
                        break;

                    case 4:
                        Console.WriteLine("Selamat tinggal");
                        Exit = true;
                        break;
                }
            }
        }
    }
}
