namespace SelStatementsDemoCSharp_47
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //if-else

            bool condition = true;

            if(condition == false)
            {
                Console.WriteLine("If statement scope");
            }
            else
            {
                Console.WriteLine("Else scope");
            }

            Console.WriteLine("Past the selection statement");

            int a = 2001;
            int b = 20;

            if(a == b)
            {
                Console.WriteLine("A and B are the same.");
            }
            else if(a == 200)
            {
                Console.WriteLine("A is 200");
            }
            else
            {
                Console.WriteLine("Neither of these were true");
            }

            //Ternary operator (inline if)

            int i = -1;
            string message = i > 0 ? "Positive" : "Negative";
            Console.WriteLine(message);

            //string message;

            //if(i > 0)
            //{
            //    message = "Positive";
            //}
            //else
            //{
            //    message = "Negative";
            //}


            //switch case

            string today = "SuNdAy";

            switch(today.ToLower())
            {
                case "sunday":
                    Console.WriteLine("It is Sunday!");
                    break;
                case "monday":
                    Console.WriteLine("It is Monday!");
                    break;
                case "tuesday":
                    Console.WriteLine("It is Tuesday!");
                    break;
                case "wednesday":
                    Console.WriteLine("It is Wednesday, my dudes!");
                    break;
                case "thursday":
                    Console.WriteLine("It is Thursday!");
                    break;
                case "friday":
                    Console.WriteLine("It is Friday!");
                    break;
                case "saturday":
                    Console.WriteLine("It is Monday!");
                    break;
                default:
                    Console.WriteLine("That is not a day of the week.");
                    break;
            }

        }
    }
}
