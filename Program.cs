
internal class Program
{
    static void Main(string[] args)
    {
        string DayOfWeek = "unknown";
        string Time = "unknown";

        Console.WriteLine("Enter the number of the day of the week");
        int DayOfWeekV = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the hour");
        int Hour = Convert.ToInt32(Console.ReadLine());

        switch (DayOfWeekV)
        {
            case 1:
                DayOfWeek = Convert.ToString(days_of_the_week.Monday);
                break;
            case 2:
                DayOfWeek = Convert.ToString(days_of_the_week.Tuesday);
                break;
            case 3:
                DayOfWeek = Convert.ToString(days_of_the_week.Wednesday);
                break;
            case 4:
                DayOfWeek = Convert.ToString(days_of_the_week.Thursday);
                break;
            case 5:
                DayOfWeek = Convert.ToString(days_of_the_week.Friday);
                break;
            case 6:
                DayOfWeek = Convert.ToString(days_of_the_week.Saturday);
                break;
            case 7:
                DayOfWeek = Convert.ToString(days_of_the_week.Sunday);
                break;
            default:
                Console.WriteLine("There are only 7 days of the week");
                break;
        }

        if (Hour >= 7 && Hour <= 12)
        {
            Time = Convert.ToString(DayTime.Morning);
        }
        else if (Hour >= 13 && Hour <= 18)
        {
            Time = Convert.ToString(DayTime.Afternoon);
        }
        else if (Hour >= 19 && Hour <= 23)
        {
            Time = Convert.ToString(DayTime.Evening);
        }
        else if (Hour >= 0 && Hour <= 6)
        {
            Time = Convert.ToString(DayTime.Night);
        }
        else
        {
            Console.WriteLine("There are 24 hours in a day from 0 to 23");
        }

        Console.WriteLine($"Now {DayOfWeek}, {Time}");
        Console.ReadLine();
    }
    enum days_of_the_week
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    enum DayTime
    {
        Morning,
        Afternoon,
        Evening,
        Night
    }
}