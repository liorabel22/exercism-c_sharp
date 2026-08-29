public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        string[] splitNumber = phoneNumber.Split('-');
        bool isNewYork = splitNumber[0] is "212";
        bool isFake = splitNumber[1] is "555";
        string localNumber = splitNumber[2];
        return (IsNewYork: isNewYork, IsFake: isFake, LocalNumber: localNumber);
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        return phoneNumberInfo.IsFake;
    }
}
