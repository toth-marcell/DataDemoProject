namespace DataDemoProject.Models
{
    public class CarEventArgs
    {
        public Car Car { get; set; }
        public CarEventArgs(Car car)
        {
            Car = car;
        }
    }
}
