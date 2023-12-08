namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string brothersName = "Cliff";
            int brothersAge = 23;
            char brothersInitial = 'C';
            bool brotherIsMale = true;
            double brothersWeight = 154.25;
            decimal brothersPrice = 54.99m;
            Console.WriteLine($"Hi! I have brother named {brothersName}, who is {brothersAge} years old.");
            Console.WriteLine($"It is {brotherIsMale} that his sex is male. He also weighs {brothersWeight}lbs.");
            Console.WriteLine($"{brothersName}'s name starts with a {brothersInitial}. {brothersName} also sells custom desks starting at ${brothersPrice}.");
        }
    }
}
