namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");
            string userFavSub = Console.ReadLine();

            switch (userFavSub)
            {
                case ("math"):
                    Console.WriteLine($"Here's a joke about {userFavSub}:");
                    Console.WriteLine("Why are obtuse angles so depressed? Because they're never right.");
                    break;
                case ("science"):
                    Console.WriteLine($"Here's a joke about {userFavSub}:");
                    Console.WriteLine("Don't trust atoms... They make up eveything...");
                    break;
                case ("english" or "English"):
                    Console.WriteLine($"Here's a joke about {userFavSub}:"); 
                    Console.WriteLine("The past present and future walked into a bar. It was tense...");
                    break;
                case ("history" or "social studies"):
                    Console.WriteLine($"Here's a joke about {userFavSub}:");
                    Console.WriteLine("Do teachers tell american civil war jokes? General Lee.");
                    break;
                case ("spanish"):
                    Console.WriteLine($"Here's a joke about {userFavSub}:");
                    Console.WriteLine("What happened to the Spanish captain who said yes too much? He got si-sick.");
                    break;
                default:
                    Console.WriteLine("input not recognized");
                    break;
            }
        }
    }
}