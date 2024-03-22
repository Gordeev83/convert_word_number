namespace convert_word_number
{ 
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите слово от 0 до 9:");
        string word = Console.ReadLine().ToLower();

        int number;
        switch (word)
        {
            case "zero":
                number = 0;
                break;
            case "one":
                number = 1;
                break;
            case "two":
                number = 2;
                break;
            case "three":
                number = 3;
                break;
            case "four":
                number = 4;
                break;
            case "five":
                number = 5;
                break;
            case "six":
                number = 6;
                break;
            case "seven":
                number = 7;
                break;
            case "eight":
                number = 8;
                break;
            case "nine":
                number = 9;
                break;
            default:
                Console.WriteLine("Некорректный ввод!");
                return;
        }

        Console.WriteLine(number);
    }
}
}
