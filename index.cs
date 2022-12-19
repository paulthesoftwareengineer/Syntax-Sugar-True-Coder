namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var answer = 4;
            string response = (answer < 9) ? "is less than nine" : " is greater than or equal to nine";
            Console.WriteLine($"Hello, Your anwer is {response}");
        }

    }
}
