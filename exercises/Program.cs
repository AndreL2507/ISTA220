using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        private static void Menu()
        {
            Console.WriteLine("1) Find the Area and Circumference of Circle");
            Console.WriteLine("2) Find the Volume of a Hemisphere");
            Console.WriteLine("3) Find the Area of a Triangle using Heron's Formula");
            Console.WriteLine("4) Solve a Quadratic Formula in terms of 'x'");
            Console.WriteLine("Please choose one of the following options by selecting the appropriate number...");
            int menu = Convert.ToInt32(Console.ReadLine());


            try
            {
                if (menu == 1)
                {
                    Circle();

                }

                else if (menu == 2)
                {
                    Hems();
                }

                else if (menu == 3)
                {
                    Tri();
                }

                else if (menu == 4)
                {
                    Quad();
                }

                else
                {
                    Console.WriteLine("Entry Unavailable");
                    Menu();
                }
            }
            catch (FormatException fEx)
            {
                string result = fEx.Message;
                Console.WriteLine($"{result}");
                Optionmenu(menu);
            }
            catch (ArgumentOutOfRangeException outofRange)
            {
                Console.WriteLine("Error: {0}",  outofRange.Message);
                Optionmenu(menu);

            }
            finally
            {
                Console.WriteLine(" You have solved your queston");
                Menu();
            }


        }

        private static void Optionmenu(int menu)
        {
            try
            {
                if (menu == 1)
                {
                    Circle();

                }

                else if (menu == 2)
                {
                    Hems();
                }

                else if (menu == 3)
                {
                    Tri();
                }

                else if (menu == 4)
                {
                    Quad();
                }

                else
                {
                    Console.WriteLine("Entry Unavailable");

                }
            }
            catch (FormatException fEx)
            {
                string result = fEx.Message;
                Console.WriteLine($"{result}");
                Optionmenu(menu);
            }
            catch (ArgumentOutOfRangeException outofRange)
            {
                Console.WriteLine("Error: {0}", outofRange.Message);
                Optionmenu(menu);

            }

        }

        private static void Quad()
        {
           
            Console.WriteLine("We will solve a quadratic equation in terms of x");

         
            Console.WriteLine("Enter a");
            string variable1 = Console.ReadLine();
            double a = double.Parse(variable1);
            Console.WriteLine("Enter b");
            string variable2 = Console.ReadLine();
            double b = double.Parse(variable2);
            Console.WriteLine("Enter c");
            string variable3 = Console.ReadLine();
            double c = double.Parse(variable3);
            double x = (-b + Math.Sqrt((b * b) - 4 * a * c)) / (2 * a);
            double negx = (-b - Math.Sqrt((b * b) - 4 * a * c)) / (2 * a);
            Console.WriteLine($"The answer when adding is {x}");
            Console.WriteLine($"The answer when subtracting is {negx}"); ;

          
            

         
            
        }

        private static void Tri()
        {
           
            Console.WriteLine("Enter Side 1");
            string side1 = Console.ReadLine();
            float s1 = float.Parse(side1);
            if (s1 < 0)
            {
                throw new ArgumentOutOfRangeException("s1, Cannot have a negative side");
            }
            
            Console.WriteLine("Enter Side 2");
            string side2 = Console.ReadLine();
            float s2 = float.Parse(side2);
            if (s2 < 0)
            {
                throw new ArgumentOutOfRangeException("s2, Cannot have a negative side");
            }
            Console.WriteLine("Enter Side 3");
            string side3 = Console.ReadLine();
            float s3 = float.Parse(side3);
            if (s3 < 0)
            {
                throw new ArgumentOutOfRangeException("s3, Cannot have a negative side");
            }
            float p = (s1 + s2 + s3) / 2;
            double area2 = Math.Sqrt((p * (p - s1) * (p - s2) * (p - s3)));
            Console.WriteLine($"The area of the triangle is {area2}");
            

            
            

            
           
        }

        private static void Hems()
        {
            
            Console.WriteLine("Enter the radius of the hemisphere");
            string radius2 = Console.ReadLine();
            double r2 = double.Parse(radius2);
            if (r2 < 0)
            {
                throw new ArgumentOutOfRangeException("r2, Cannot have a negative radius");
            }
            double volume = ((Math.PI * (r2 * r2 * r2)) * 4 / 3) / 2;
            Console.WriteLine($"The volume of the hemisphere is {volume}");
            
            
           
            
        }

        private static void Circle()
        {
           
            Console.WriteLine("Enter the radius");
            string radius = Console.ReadLine();
            double r1 = double.Parse(radius);
            if (r1 < 0)
            {
                throw new ArgumentOutOfRangeException("r1, Cannot have a negative radius");
            }
            double circumference = 2 * Math.PI * r1;
            double area = Math.PI * r1 * r1;
            Console.WriteLine($"The circumference is {circumference}");
            Console.WriteLine($"The area is {area}");
            

           
            

        }
    }
}
