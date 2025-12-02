using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.Input;
using DataDemoProject.Models;

namespace DataDemoProject.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public string Type { get; set; }
    public RelayCommand AddCommand { get; set; }
    public ObservableCollection<Car> Cars { get; set; }
    readonly MainModel MainModel;
    public MainViewModel() { }
    public MainViewModel(MainModel model)
    {
        MainModel = model;
        MainModel.CarGenerated += MainModel_CarGenerated;
        Cars = [];
        AddCommand = new(AddCar);
        MainModel.GenerateCars(10);
    }
    private void MainModel_CarGenerated(object? sender, CarEventArgs e)
    {
        e.Car.DeleteCommand = new(() => Cars.Remove(e.Car));
        Cars.Add(e.Car);
    }
    void AddCar()
    {
        Car car = new(Make, Model, Year, Type);
        car.DeleteCommand = new(() => Cars.Remove(car));
        Cars.Add(car);
    }
}
