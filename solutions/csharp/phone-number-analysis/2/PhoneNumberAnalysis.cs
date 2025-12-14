public static class PhoneNumber
{
    private const int NewYorkPrefix = 212;
    private const int FakeNumberPrefix = 555;
    
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        (bool isNewYork, bool isFake, string localNumber) phoneNumberInfo = new();
        
        var phoneNumberParts = phoneNumber.Split('-');
        
        if (int.Parse(phoneNumberParts[0]) == NewYorkPrefix)
        {
            phoneNumberInfo.isNewYork = true;
        }

        if (int.Parse(phoneNumberParts[1]) == FakeNumberPrefix)
        {
            phoneNumberInfo.isFake = true;
        }

        phoneNumberInfo.localNumber = phoneNumberParts[2];

        return phoneNumberInfo;
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo) => phoneNumberInfo.IsFake;
}