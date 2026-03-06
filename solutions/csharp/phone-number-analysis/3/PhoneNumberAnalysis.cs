public static class PhoneNumber
{
    public static (bool, bool, string) Analyze(string phone_number)
    {
        string[] result = phone_number.Split("-");
        bool has_code = result[0] == "212";
        bool is_fake = result[1] == "555";
        string last_digits = result[2];
        
        return (has_code, is_fake, last_digits);
    }

    public static bool IsFake((bool _has_code, bool is_fake, string _last_digits) analyzed_phone)
        => analyzed_phone.is_fake;
}