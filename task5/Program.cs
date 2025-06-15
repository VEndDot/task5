namespace task5
{
    class StartElyphan
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Press 1 for Lloyd, 2 for Lucinda, 3 to swap");

            string userInput = ""; 

            Elephant lloyd = new Elephant();
            lloyd.Name = "Lloyd";
            lloyd.EarSize = 40;

            Elephant lucinda = new Elephant();
            lucinda.Name = "Lucinda";
            lucinda.EarSize = 33;

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
                        Console.WriteLine("References have been swapped");
                        Elephant tmpLloyd = lloyd;

                        lloyd = lucinda;
                        lucinda = tmpLloyd;
                        break;
                }
            }
            


        }
    }
}