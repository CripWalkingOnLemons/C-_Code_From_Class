namespace week_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the month number: ");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter the year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            int daysInMonth;

            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    daysInMonth = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    daysInMonth = 30;
                    break;
                case 2:
                    daysInMonth = IsLeapYear(year) ? 29 : 28;
                    break;
                default:
                    daysInMonth = -1;
                    break;
            }

            Console.WriteLine($"The number of days in the month is: {daysInMonth}");

            
            bool IsLeapYear(int year)
            {
                return (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;
            }



        }
    }
}
