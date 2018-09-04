using System;

namespace Farm
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Menu();
           


        }

        

        private static void Menu()
        {
            Console.WriteLine("Please choose one of the following menu options..");
            Console.WriteLine("1) Horse");
            Console.WriteLine("2) Pig");
            Console.WriteLine("3) Duck");
            Console.WriteLine("4) Cow");
            int menu = Convert.ToInt32(Console.ReadLine());

            if (menu == 1)
            { 
                Animal1();
                Menu2(menu);


            }
            else if (menu == 2)
            {
                Animal2();
                Menu3(menu);
            }
            else if (menu == 3)
            {
                Animal3();
                Menu4(menu);
            }
            else if (menu == 4)
            {
                Animal4();
                Menu5(menu);
            }
            else
            {
                Console.WriteLine("Invalid Entry");
                Menu();
            }

        }

        private static void Menu5(int menu)
        {
            int menu5 = Convert.ToInt32(Console.ReadLine());

            if (menu5 == 1)
            {
                Cow cow1 = new Cow();
                cow1.Speak();
                Animal4();
                Menu5(menu);
            }
            else if (menu5 == 2)
            {
                Cow cow1 = new Cow();
                cow1.Eat();
                Animal4();
                Menu5(menu);
            }
            else if (menu5 == 3)
            {
                Cow cow1 = new Cow();
                cow1.Run();
                Animal4();
                Menu5(menu);
            }
            else if (menu5 == 4)
            {
                Cow cow1 = new Cow();
                cow1.Attack();
                Animal4();
                Menu5(menu);
            }
            else
            {
                Menu();
            }
        }

        private static void Menu4(int menu)
        {
            int menu4 = Convert.ToInt32(Console.ReadLine());

            if (menu4 == 1)
            {
                Duck duck1 = new Duck();
                duck1.Speak();
                Animal3();
                Menu4(menu);
            }
            else if (menu4 == 2)
            {
                Duck duck1 = new Duck();
                duck1.Eat();
                Animal3();
                Menu4(menu);
            }
            else if (menu4 == 3)
            {
                Duck duck1 = new Duck();
                duck1.Run();
                Animal3();
                Menu4(menu);
            }
            else if (menu4 == 4)
            {
                Duck duck1 = new Duck();
                duck1.Attack();
                Animal3();
                Menu4(menu);
            }
            else
            {
                Menu();
            }
        }

        private static void Menu3(int menu)
        {
            int menu3 = Convert.ToInt32(Console.ReadLine());

            if (menu3 == 1)
            {
                Pig pig1 = new Pig();
                pig1.Speak();
                Animal2();
                Menu3(menu);
            }
            else if (menu3 == 2)
            {
                Pig pig1 = new Pig();
                pig1.Eat();
                Animal2();
                Menu3(menu);
            }
            else if (menu3 == 3)
            {
                Pig pig1 = new Pig();
                pig1.Run();
                Animal2();
                Menu3(menu);
            }
            else if (menu3 == 4)
            {
                Pig pig1 = new Pig();
                pig1.Attack();
                Animal2();
                Menu3(menu);
            }
            else
            {
                Menu();
            }
        }

        private static void Menu2(int menu)
        {
            int menu2 = Convert.ToInt32(Console.ReadLine());
            
            if (menu2 == 1)
            {
                Horse horse1 = new Horse();
                horse1.Speak();
                Animal1();
                Menu2(menu);
            }
            else if (menu2 == 2)
            {
                Horse horse1 = new Horse();
                horse1.Eat();
                Animal1();
                Menu2(menu);
            }
            else if (menu2 == 3)
            {
                Horse horse1 = new Horse();
                horse1.Run();
                Animal1();
                Menu2(menu);
            }
            else if (menu2 == 4)
            {
                Horse horse1 = new Horse();
                horse1.Attack();
                Animal1();
                Menu2(menu);
            }
            else 
            {
                Menu();
            }
        }

        

        private static void Animal1()
        {
            Console.WriteLine("Choose an option");
            Console.WriteLine("1) Speak");
            Console.WriteLine("2) Eat");
            Console.WriteLine("3) Run");
            Console.WriteLine("4) Attack");
            
            



        }

        private static void Animal2()
        {
            Console.WriteLine("Choose an option");
            Console.WriteLine("1) Speak");
            Console.WriteLine("2) Eat");
            Console.WriteLine("3) Run");
            Console.WriteLine("4) Attack");

            


        }
        private static void Animal3()
        {
            Console.WriteLine("Choose an option");
            Console.WriteLine("1) Speak");
            Console.WriteLine("2) Eat");
            Console.WriteLine("3) Run");
            Console.WriteLine("4) Attack");
        }
        private static void Animal4()
        {
            Console.WriteLine("Choose an option");
            Console.WriteLine("1) Speak");
            Console.WriteLine("2) Eat");
            Console.WriteLine("3) Run");
            Console.WriteLine("4) Attack");
        }



    }
}
