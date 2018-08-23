using System;

namespace Exercise2Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tell the user to enter 10 grades 
            Console.WriteLine("Enter Grades 1-10");
            
            //get an average from the 10 grades
            string grade1 = Console.ReadLine();
            double g1 = double.Parse(grade1);
            string grade2 = Console.ReadLine();
            double g2 = double.Parse(grade2);
            string grade3 = Console.ReadLine();
            double g3 = double.Parse(grade3);
            string grade4 = Console.ReadLine();
            double g4 = double.Parse(grade4);
            string grade5 = Console.ReadLine();
            double g5 = double.Parse(grade5);
            string grade6 = Console.ReadLine();
            double g6 = double.Parse(grade6);
            string grade7 = Console.ReadLine();
            double g7 = double.Parse(grade7);
            string grade8 = Console.ReadLine();
            double g8 = double.Parse(grade8);
            string grade9 = Console.ReadLine();
            double g9 = double.Parse(grade9);
            string grade10 = Console.ReadLine();
            double g10 = double.Parse(grade10);


        // get the average
            double avg = (g1 + g2 + g3 + g4 + g5 + g6 + g7 + g8 + g9 + g10)/ 10;
            Console.WriteLine($"The average is {avg}");
           

            // assign a letter grade to the average
           
           char lettergrade = letterGrade(avg);
            Console.WriteLine($"The average is an {lettergrade}");



            
        }

        private static char letterGrade(double avg)
            
        
        {
            //throw new NotImplementedException();
            if (avg >= 90) return 'A';
            else if (avg >= 80) return 'B';
            else if (avg >= 70) return 'C';
            else if (avg >= 60) return 'D';
            else  return 'F';
            


        }
    }
}
