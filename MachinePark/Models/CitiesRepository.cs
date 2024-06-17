namespace MachinePark.Models
{
    public class CitiesRepository
    {
        private static List<string> cities = new List<string>
        { 
            
            "Paris",
            "London",
            "NewYork",
            "Stockholm",
            "Rom"
        };

        public static List<string> GetCities() => cities;

    }
}
