namespace ArrayExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] friends = new string[5];

            for (int i = 0; i < friends.Length; i++)
            {
                Console.WriteLine("Add a new friend");
                string input = Console.ReadLine();
                friends[i] = input;
            }

            Console.WriteLine("\n");

            foreach(string friend in friends)
            {
                Console.WriteLine($"Greetings to {friend}");
            }
        }
    }
}