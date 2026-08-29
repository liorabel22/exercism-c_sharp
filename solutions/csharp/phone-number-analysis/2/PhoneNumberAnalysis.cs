public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        bool isNewYork = false;
        bool isFake = false;
        string localNumber = "";

        if (phoneNumber.Split('-') is [string ny, string fake, string local])
        {
            isNewYork = ny is "212";
            isFake = fake is "555";
            localNumber = local;
        }
        return (IsNewYork: isNewYork, IsFake: isFake, LocalNumber: localNumber);
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        return phoneNumberInfo.IsFake;
    }
}
