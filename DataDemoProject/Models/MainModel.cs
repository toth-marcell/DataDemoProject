using System;

namespace DataDemoProject.Models
{
    public class MainModel
    {
        public event EventHandler<CarEventArgs> CarGenerated;
        readonly Random rng = new();
        static readonly string[] makes = { "MMM", "AAA", "ŰŰŰ" };
        static readonly string[] models = { "abc", "TrafficLightIgnorer", "speaker on wheels" };
        static readonly string[] types = { "normal car", "not normal car", "too big car" };
        public void GenerateCars(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Car car = new(makes[rng.Next(0, makes.Length)], models[rng.Next(0, models.Length)], rng.Next(1950, 2025), types[rng.Next(0, types.Length)]);
                CarGenerated?.Invoke(this, new(car));
            }
        }
    }
}
