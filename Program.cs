using System;

namespace CompanyHierarchy
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the sales for Manager 1:");
            double sales1 = double.Parse(Console.ReadLine() ?? "0");
            double salary1 = CalculateSalary(sales1);

            Console.WriteLine("Enter the sales for Manager 2:");
            double sales2 = double.Parse(Console.ReadLine() ?? "0");
            double salary2 = CalculateSalary(sales2);

            Console.WriteLine("Enter the sales for Manager 3:");
            double sales3 = double.Parse(Console.ReadLine() ?? "0");
            double salary3 = CalculateSalary(sales3);

            // Визначаємо найкращого менеджера та даємо бонус
            double maxSales = Math.Max(Math.Max(sales1, sales2), sales3);
            double bonus = 200;

            if (maxSales == sales1) salary1 += bonus;
            if (maxSales == sales2) salary2 += bonus;
            if (maxSales == sales3) salary3 += bonus;

            // Вивести результати
            Console.WriteLine($"Manager 1: Sales = ${sales1}, Salary = ${salary1}");
            Console.WriteLine($"Manager 2: Sales = ${sales2}, Salary = ${salary2}");
            Console.WriteLine($"Manager 3: Sales = ${sales3}, Salary = ${salary3}");
        }

        static double CalculateSalary(double sales)
        {
            double baseSalary = 200;
            double commission = 0;

            if (sales <= 500)
            {
                commission = sales * 0.03;
            }
            else if (sales > 500 && sales <= 1000)
            {
                commission = sales * 0.05;
            }
            else if (sales > 1000)
            {
                commission = sales * 0.08;
            }

            return baseSalary + commission;
        }
    }
}