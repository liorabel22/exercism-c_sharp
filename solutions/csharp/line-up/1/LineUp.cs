public static class LineUp
{
    public static string Format(string name, int number)
    {
        string numberSufix = "th";
        int lastDigit = number % 10;
        int twoLastDigits = number % 100;
        if (lastDigit is 1 && twoLastDigits is not 11)
        {
            numberSufix = "st";
        }
        else if (lastDigit is 2 && twoLastDigits is not 12)
        {
            numberSufix = "nd";
        }
        else if (lastDigit is 3 && twoLastDigits is not 13)
        {
            numberSufix = "rd";
        }

        return $"{name}, you are the {number}{numberSufix} customer we serve today. Thank you!";
    }
}
