using System;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrA = new int[6] { 0, 2, 4, 6, 8, 10 };
            int[] arrB = new int[5] { 1, 3, 5, 7, 9 };
            int[] arrC = new int[12] { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };
            double avg = 0.0;
            int sum = 0;

            Console.WriteLine("Array A:");
            for (int i = 0; i < arrA.Length; i++)
            {
                Console.Write(arrA[i] + ", ");
                sum += arrA[i];
                double count = arrA.Length;
                avg = sum / count;
            }

            Console.WriteLine();
            Console.WriteLine($"The Sum of Array A is {sum}");
            Console.WriteLine($"The Average of Array A is {avg}");
            Console.WriteLine("Array A in reverse is:");
            Reverse(arrA);
            Console.WriteLine();
            Console.WriteLine("Array A 2 places to the right:");
            Rotate(arrA, "right", 2);
            Console.WriteLine();
            Console.WriteLine("Array A in ascending order: ");
            Sort(arrA);
            Console.WriteLine("Array B:");

            for (int i = 0; i < arrB.Length; i++)
            {
                Console.Write(arrB[i] + ", ");
                sum += arrB[i];
                double count = arrB.Length;
                avg = sum / count;
            }
            Console.WriteLine();
            Console.WriteLine($"The Sum of Array B is {sum}");
            Console.WriteLine($"The Average of Array B is {avg}");
            Console.WriteLine("Array B in reverse is:");
            Reverse2(arrB);
            Console.WriteLine();
            Console.WriteLine("Array B 4 places to the left:");
            Rotate(arrB, "left", 4);
            Console.WriteLine();
            Console.WriteLine("Array B in ascending order: ");
            Sort(arrB);
            Console.WriteLine();
            Console.WriteLine("Array C:");
            


            for (int i = 0; i < arrC.Length; i++)
            {
                Console.Write(arrC[i] + ", ");
                sum += arrC[i];
                double count = arrC.Length;
                avg = sum / count;
            }
            Console.WriteLine();
            Console.WriteLine($"The Sum of Array C is {sum}");
            Console.WriteLine($"The Average of Array C is {avg}");
            Console.WriteLine("Array C in reverse is:");
            Reverse3(arrC);
            Console.WriteLine();
            Console.WriteLine("Array C 3 places to the left:");
            Rotate(arrB, "left", 3);
            Console.WriteLine();
            Console.WriteLine("Array C in ascending order: ");
            Sort(arrC);
            Console.WriteLine();
        }

        private static void Sort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            for (int k = 0; k < array.Length; k++)
            {
                Console.Write(array[k] + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("Array in descending order: ");
           

            for (int l = 0; l < array.Length; l++)
            {
                for (int m = 0; m < array.Length; m++)
                {
                    if (array[l] > array[m])
                    {
                        int temp = array[l];
                        array[l] = array[m];
                        array[m] = temp;
                    }
                }
            }
            for (int n = 0; n < array.Length; n++)
            {
                Console.Write(array[n] + ", ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        

        

        private static void Rotate(int[] array, string dir, int v)
        {
            if (dir == "left")
            {
                foreach (int i in array)
                {

                    int k = (v % array.Length);
                    v++;
                    Console.Write(array[k] + ", ");



                }
            }


            else
            {
                int v2 = (array.Length - v);
                foreach (int i in array)
                {
                    int k = (v2 % array.Length);
                    v2++;
                    Console.Write(array[k] + ", ");
                }
            }
            
        }
                
        


                    
                   

                
              
                      
                

                
        

        private static void Reverse3(int[] arrC)
        {
            for (int j = arrC.Length - 1; j >= 0; j--)
            {
                Console.Write(arrC[j] + ", ");
            }
        }

        private static void Reverse2(int[] arrB)
        {
            for (int j = arrB.Length - 1; j >= 0; j--)
            {
                Console.Write(arrB[j] + ", ");
            }
        }

        private static void Reverse(int[] arrA)
        {
            for (int j = arrA.Length - 1; j >= 0; j--)
            {
                Console.Write(arrA[j] + ", ");
            }
        }
    }
}
