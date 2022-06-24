using System;
using System.Collections.Generic;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            var array = new int[50];
           

            Populater(array);

            
            Console.WriteLine($"First number in array: {array[0]}");

            Console.WriteLine($"Last number in array: {array[array.Length - 1]}");

            Console.WriteLine("All Numbers Original");
            
            NumberPrinter(array);
            Console.WriteLine("-------------------");

            

            Console.WriteLine("All Numbers Reversed:");
            

            Console.WriteLine("---------REVERSE CUSTOM------------");
            ReverseArray(array);
            NumberPrinter(array);

            Console.WriteLine("-------------------");

            
            Console.WriteLine("Multiple of three = 0: ");
            ThreeKiller(array);
            NumberPrinter(array);
            

            Console.WriteLine("-------------------");

           
            Array.Sort(array);
           
            Console.WriteLine("Sorted numbers:");
            NumberPrinter(array);


            Console.WriteLine("\n************End Arrays*************** \n");
            
            #region Lists
            Console.WriteLine("************Start Lists**************");

           
            var myIntList = new List<int>();

           
            Console.WriteLine($"myIntList Capacity: {myIntList.Capacity}");

                
            Populater(myIntList);
            NumberPrinter(myIntList);
            

            Console.WriteLine("---------------------");

          
            Console.WriteLine($"myIntList Capacity: {myIntList.Capacity}");

            Console.WriteLine("---------------------");

           

            Console.WriteLine("What number will you search for in the number list?");
            int userNumber;
            bool isANumber;

            do
            {
                isANumber = int.TryParse(Console.ReadLine(), out userNumber);

                if(!isANumber)
                {
                    Console.WriteLine("Incorrect input, please try again.");
                }

            } while (!isANumber); 

            NumberChecker(myIntList, userNumber);


            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
          
            NumberPrinter(myIntList);

            Console.WriteLine("-------------------");


           
            

            Console.WriteLine("Evens Only!!");

            OddKiller(myIntList);
            NumberPrinter(myIntList);

            Console.WriteLine("------------------");

            
            myIntList.Sort();
            NumberPrinter(myIntList);

            Console.WriteLine("Sorted Evens!!");
            
            Console.WriteLine("------------------");

            
            var myArray = myIntList.ToArray();


         

            myIntList.Clear();
            Console.WriteLine($"myIntList count: {myIntList.Count}");

            #endregion
        }

        private static void ThreeKiller(int[] numbers)

        {

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 3 == 0)
                {

                    numbers[i] = 0; 

                }
                
            }
        }

        

        private static void OddKiller(List<int> numberList)
        {
            for(int i = numberList.Count - 1; i >= 0; i--)
            {
                if (numberList[i] % 2 != 0)
                {
                    numberList.Remove(numberList[i]);
                }
            }


        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {

            if(numberList.Contains(searchNumber))
            {
                Console.WriteLine($"We have the number you are looking for");
            }

            else
            {
                Console.WriteLine($"Try again!");
                Console.WriteLine($"I'll look into it");
            }
            
        }

        private static void Populater(List<int> numberList)
        {
            
            for(int i = 0; i <= 50; i++)

            {
                Random rng = new Random();
                //var randomNumber = rng.Next(1, 50);
                numberList.Add(rng.Next(1, 50));
            }

          //  NumberPrinter(numberList);


        }

        private static void Populater(int[] numbers) 
        {
            Random rng = new Random();

            for(var i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rng.Next(1,50);

            }

        }        

        private static void ReverseArray(int[] array)
        {
            //Array.Reverse(array);
            var reversedArray = new int[array.Length];
            var counter = 0;

            for(var i = array.Length - 1; i >=0; i--)
            {
                reversedArray[counter++] = array[i];
                //counter++;

            }

            NumberPrinter(reversedArray);
        }


        
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
           
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
