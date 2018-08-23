using System;

namespace Exercise2Part3
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Grades. To STOP type -1");

            double count = 0;
            double sum = 0;
            get_sum(count, sum);


       
        }

        private static void get_sum(double count, double sum)
        {
            //throw new NotImplementedException();
            string grade = Console.ReadLine();
            double g = double.Parse(grade);
            count = count + 1;
            sum = sum + g;

            if (g == -1)
            {
                Console.WriteLine($"The final sum is: ({sum + 1})");
                get_avg(count, sum);
            }

            else if (count > -1)
            {
                get_sum(count, sum);
            }
        }

        private static void get_avg(double count, double sum)
        {
            //throw new NotImplementedException();
            double avg = ((sum + 1) / (count - 1));
            Console.WriteLine($"The average is {avg}");
            char lettergrade = getletter(avg);
            Console.WriteLine($" The grade is {lettergrade}");
        }

        private static char getletter(double avg)
        {
            //throw new NotImplementedException();
            if (avg >= 90) return 'A';
            else if (avg >= 80) return 'B';
            else if (avg >= 70) return 'C';
            else if (avg >= 60) return 'D';
            else return 'F';
        }
    }
}
