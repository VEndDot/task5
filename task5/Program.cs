namespace task5
{
    class StartElyphan
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Press 1 for Lloyd, 2 for Lucinda, 3 to swap");

            string userInput = ""; 

            Elephant lloyd = new Elephant() { Name = "Lloyd", EarSize = 40 };
            Elephant lucinda = new Elephant() { Name = "Lucinda", EarSize = 33 };

            while (userInput != "0")
            {
                Console.Write("You pressed ");
                userInput = Console.ReadLine(); 
                
                switch (userInput)
                {
                    case "1":
                        lloyd.WhoAmI();
                        break;
                    case "2":
                        lucinda.WhoAmI();
                        break;
                    case "3":
                        SwapElephant(ref lloyd, ref lucinda);
                        break;
                }
            }
            


        }

        public static void SwapElephant(ref Elephant object_1,ref Elephant object_2) { 
            Console.WriteLine("References have been swapped");
            Elephant tmpLloyd = object_1;

            object_1 = object_2;
            object_2 = tmpLloyd;
        }
    }
}