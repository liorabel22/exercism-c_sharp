public static class Leap
{
    public static bool IsLeapYear(int year)
    {
        if (year % 100 is 0 && year % 400 is 0)
        {
            return true;
        }
        else if (year % 100 is not 0 && year % 4 is 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}