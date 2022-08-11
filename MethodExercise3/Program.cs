using System;

namespace MethodExercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Before we start we need to set a number value, Please pick a number between 1-5: ");
            var num = int.Parse(Console.ReadLine());   // you will use Parse to convert a string into a int.

            Console.WriteLine("Thank you, now I must ask, What is your age?");
            var age = int.Parse(Console.ReadLine());

            Console.WriteLine("Awesome, Okay so you are going to see a bunch  of random numbers, that is the Exercise requirements");

            // PrintRange(1000, -1000);   // this is how you call the method by using the varible name.

            //PrintThree();
            IsEqual(num, 5);
            Console.WriteLine(Vote(age));
            Console.WriteLine(Range(num));
            Console.WriteLine();
            Console.WriteLine();

            Mtable(num);

        }

        public static void PrintRange(int ceiling, int floor) // 5 things that make a method: 1=public static 2=void 3=PrintThousand 4=(var,var)
                                                              // 5={scope} ... writing this way makes the code more dymanic.
        {
            for (int i = ceiling; i >= floor; i--)  // for (initializer, Conditional, increment) {Scope} -- ( this is the Formating)
            {
                Console.WriteLine(i);
            }
        }

        public static void PrintThree()  // if the question ask for a return or produce change void to a return type (Return types are Strings or Int)
        {
            for (int i = 3; i <= 999; i+= 3) // this can also be seen i=i+3
            {
                Console.WriteLine(i);  // how this work is it checks Conditional first(i<999) then checks Scope(CWl)
                                       // then checks increment (K+=3) then back to checking conditional. This will continue until conditional is met. 
            }

        }

        public static void IsEqual (int a, int b)
        {
            if (a == b)
            {
                Console.WriteLine($"{a} is equal to {b}");
                // could just write: return true; then under } Return false; 
            }
            else Console.WriteLine($"{a} is not equal to {b}");  
        }
       
        

        public static string EvenOdd(int num)
        {
            if (num % 2 == 0)
            
                return "Even";
            else
                return "Odd";


        }

        public static string MakeNeg (int num)
        {
            if (num > 0)
            {
                return "Postive";

            }
            return "Negative";
        }

        public static string Vote(int age) // "Pass it in" means to add values to the () part. 
        {
            if (age >= 18)
            {

                return "You can Vote";

            }
            return " You can not vote yet";
        }

        public static string Range(int num)
        {

            if (num <= 10 && num >= -10)
            {
                return "Your number fits in the range";
            }
            return "Sorry you number didn't fit inside the range";
        }

        public static void Mtable(int num)
        {
            int multiplier;

            for ( multiplier =1; multiplier <= 12; multiplier++ )
            {
                Console.WriteLine("{0}*{1}={2}", num, multiplier, (num * multiplier)); 

            }



        }
}
}

 