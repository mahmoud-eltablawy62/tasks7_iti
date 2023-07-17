namespace printDays
{

    enum days
    {
        saturday,
        sunday,
        monday,
        tuesday,
        wednesday,
        thursday,
        friday,
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
             
            bool IsFound = false;
            do
            {
                Console.WriteLine("enter the number of day ===> ");
                int num_day = int.Parse(Console.ReadLine());
                switch (num_day)
                {
                    case 1:
                        Console.WriteLine("day===>" + days.saturday);
                        IsFound = false;
                        break;
                    case 2:
                        Console.WriteLine("day===>" + days.sunday);
                        IsFound = false;
                        break;
                    case 3:
                        Console.WriteLine("day===>" + days.monday);
                        IsFound = false;
                        break;
                    case 4:
                        Console.WriteLine("day===>" + days.tuesday);
                        IsFound = false;
                        break;
                    case 5:
                        Console.WriteLine("day===>" + days.wednesday);
                        IsFound = false;
                        break;
                    case 6:
                        Console.WriteLine("day===>" + days.thursday);
                        IsFound = false;
                        break;
                    case 7:
                        Console.WriteLine("day===>" + days.friday);
                        IsFound = false;
                        break;
                    default:
                        Console.WriteLine("enter answer number");
                        IsFound = true;
                        break;
                }
            } while (IsFound == true);

        }
    }
}