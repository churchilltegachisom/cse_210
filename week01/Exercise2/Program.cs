using System; // ✅ This goes at the very top

namespace Exercise2 // Or whatever the namespace is
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your grade percentage: ");
            string input = Console.ReadLine();
            int percentage = int.Parse(input);

            string letter = "";
            string sign = "";

            if (percentage >= 90)
            {
                letter = "A";
            }
            else if (percentage >= 80)
            {
                letter = "B";
            }
            else if (percentage >= 70)
            {
                letter = "C";
            }
            else if (percentage >= 60)
            {
                letter = "D";
            }
            else
            {
                letter = "F";
            }

            int lastDigit = percentage % 10;

            if (letter != "F")
            {
                if (lastDigit >= 7 && percentage < 100)
                {
                    sign = "+";
                }
                else if (lastDigit < 3)
                {
                    sign = "-";
                }

                if (letter == "A" && sign == "+")
                {
                    sign = "";
                }
            }

            Console.WriteLine($"Your letter grade is: {letter}{sign}");

            if (percentage >= 70)
            {
                Console.WriteLine("Congratulations! You passed the course.");
            }
            else
            {
                Console.WriteLine("Don't give up! Better luck next time.");
            }
        }
    }
}
