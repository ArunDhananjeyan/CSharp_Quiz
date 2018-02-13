using system;

namespace Symc.Globalizaion.Localization
{
    class CSharpBasics
    {

        /// <summary>
        /// Write a program and ask the user to enter the width and height of an image. Then tell if the image 
        /// is landscape or portrait.
        /// </summary>
        /// 
        public void ToFindLandscapeOrPortrait()
        {
           int Length;
           int Breath;
            
           Console.WriteLine("Enter length of your image:");
           Length = int.Parse(Console.ReadLine());
           Console.WriteLine("Enter Breath of your image:");
           Breath = int.Parse(Console.ReadLine());
           if (Length < Breath)
           {
               Console.WriteLine("Your image is Landscape");
           }
            elseif (Lenght > Breath)
            {
                Console.WriteLine("Your image is Portrait");
            }
            else
            {
                Console.WriteLine("Your image is square");
            }
        }
            
        /// <summary>
        /// Write a program which takes a single argument from the console, computes the factorial and prints the 
        /// value on the console. For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 
        /// and display it as 5! = 120.
        /// </summary>
        /// 
        
        public void ToFindFractionOfANumber()
        {
            int i, Number, Fact;
            Console.WriteLine("Enter the Number");
            Number = int.Parse(Console.ReadLine());
            Fact = Number;
            for (i = Number - 1; i >= 1; i--)
            {
                Fact = Fact * i;
            }
            Console.WriteLine("Factorial Of Given Number Is:{0} ", Fact);  
        }
        
        /// <summary>
        /// Ask the user to enter their name. Use an array to reverse the name and then store the result in a new string. 
        /// Display the reversed name on the console.
        /// </summary>
        /// 
        
        public void StringReverse()
        {
            string Str, ReverseString = "";
            int Length;
            Console.WriteLine("Enter A String : ");
            Str = Console.ReadLine();
            Length = Str.Length - 1;
            while (Length >= 0)
            {
                ReverseString = reversestring + Str[Length];
                Length--;
            }
            Console.WriteLine("Reverse  String  Is  {0}", reversestring);
        }


        /// <summary>
        /// Write a program and ask the user to enter a few numbers separated by a hyphen. Work out 
        /// if the numbers are consecutive. For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", 
        /// display a message: "Consecutive"; otherwise, display "Not Consecutive".
        /// </summary>
        /// 

        pubic void ToFindConsecutiveNumber ()
        {
            string NumberSequnce;
            Console.WriteLine("Enter Few Numbers which seperated by Hyphen(-):");
            NumberSequnce = Console.ReadLine();
            List<string> NumberSequnceList = NumberSequnce.Split('-').ToList();
            bool broken = false;
 
            if (NumberSequnce != null) 
               {
                var sequenceAsList = NumberSequnce.ToList();
 
                if (sequenceAsList.Any())
                   {
                        int lastValue = NumberSequnce.First();
 
                        broken = NumberSequnce.Any(value =>;
                                    {
                                        if ((value - lastValue) > 1)
                                            return true;
 
                                            lastValue = value;
 
                                            return false;
                                    }); 
                        Console.WriteLine("Squence is not Broken");
                     }
                 }
 
                 Console.WriteLine("Squence is Broken");
             }

    }
}
