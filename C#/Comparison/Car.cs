using System.Collections;

namespace Comparison
{
    public class Car:IComparable<Car>
    {
        public int Year { get; set; }
        public string Make { get; set; }
        public Car(string Make, int Year)
        {
            this.Year = Year;
            this.Make= Make;
        }
        //Method of IComparable interface, provide default sort order
        public int CompareTo(Car obj)
        {
            Car c = (Car)obj;
            return String.Compare(this.Make, c.Make);
        }
        //Nested class - class within class
        // to do ascending sort on year property of Car class
        class SortYearAscendingHelper : IComparer
        {
            public int Compare(object x, object y)
            {
                Car c1 = (Car)x;
                Car c2 = (Car)y;
                if (c1.Year > c2.Year)
                    return 1;
                if (c1.Year < c2.Year)
                    return -1;
                else  
                    return 0;
            }
        }
        // to do Descending sort on year property of Car class
        class SortYearDescendingHelper : IComparer
        {
            public int Compare(object x, object y)
            {
                Car c1 = (Car)x;
                Car c2 = (Car)y;
                if (c1.Year < c2.Year)
                    return 1;
                if (c1.Year > c2.Year)
                    return -1;
                else
                    return 0;
            }
        }

 
        // to do Descending sort on make property of Car class
        class SortMakeDescendingHelper : IComparer
        {
            public int Compare(object x, object y)
            {
                Car c1 = (Car)x;
                Car c2 = (Car)y;
                return String.Compare(c2.Make, c1.Make);
            }
        }
        // Method to return IComparer object for sort helper
        public static IComparer SortYearAscending()
        {
            return (IComparer) new SortYearAscendingHelper();
        }
        public static IComparer SortYearDescending()
        {
            return (IComparer)new SortYearDescendingHelper();
        }
        public static IComparer SortMakeDescending()
        {
            return (IComparer)new SortMakeDescendingHelper();
        }
    }
}