namespace PalindromeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, remainder, reverse = 0, temp;
            Console.WriteLine("Enter a number: ");
            num = int.Parse(Console.ReadLine());

            temp = num;
            while(temp > 0)
            {
                remainder = temp % 10;
                reverse = 10 * reverse + remainder;
                temp = temp / 10;
            }

            if(reverse == num)
            {
                Console.WriteLine(num + " is a Palindrome number");
            } else
            {
                Console.WriteLine(num + " is not a Palindrome number");
            }

        }
    }
}
