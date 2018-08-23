using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the Grade");
            double grade = Convert.ToDouble(Console.ReadLine());
            char LetterGrade = letterGrade(grade);
            Console.WriteLine($"The Grade is {LetterGrade}");

           
         
           
            

           
            
        }

        private static char letterGrade(double grade)
        {
            char letter = 'f';
                

            //throw new NotImplementedException();
             if (grade >= 90) 
            {
                letter = 'A';
            }
             else if(grade >= 80 && grade < 90)
            {
                letter = 'B';
            }
             else if (grade >= 70 && grade < 80)
            {
                letter = 'C';
            }
             else if (grade >= 60 && grade < 70)
            {
                letter = 'D';
            
            }
             else if (grade > 0 && grade < 60)
            {
                letter = 'F';
            }

            return letter;
        }
    }
}
