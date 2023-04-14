namespace ConsoleApp1;

public class Program
{
    public static void Main(string[] args)
    {
        
    }

    public static bool MinFromTwoNumbers(int a, int b)
    {
        if (a > b) return true;
        return false;
    }

    public static float MetersToCentimeters(float a)
    {
        return (a * 100);
    }
    
    public static bool AuthorizationMetod1(string login,string password)
    {
        if (login != password && !string.IsNullOrEmpty(login) && !string.IsNullOrEmpty(password))
        {
            return true;
        }
        return false;
    }

    public static bool AuthorizationMetod2(string login, string password, string email, string date)
    {
        DateTime date1;
        if(!string.IsNullOrEmpty(login) && !string.IsNullOrEmpty(password)
                                        && !string.IsNullOrEmpty(email)
                                        && email.Contains("@gmail.com")
                                        && DateTime.TryParse(date,out date1))
        {
            return true;
        }

        return false;
    }

    public static bool TestDate(string date)
    {
        DateTime date1;
        if (DateTime.TryParse(date, out date1))
        {
            return true;
        }
        return false;
    }
}