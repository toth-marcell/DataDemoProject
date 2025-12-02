using CommunityToolkit.Mvvm.Input;

namespace DataDemoProject.Models
{
    public class Car
    {
        public string Make { get; private set; }
        public string Model { get; private set; }
        public int Year { get; private set; }
        public string Type { get; private set; }
        public RelayCommand DeleteCommand { get; set; }
        public Car(string make, string model, int year, string type)
        {
            Make = make;
            Model = model;
            Year = year;
            Type = type;
        }
    }
}
