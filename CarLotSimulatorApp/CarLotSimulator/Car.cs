using System;
using System.Globalization;

namespace CarLotSimulator;

public class Car
{
    public int Year { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public string EngineNoise { get; set; }
    public string HonkNoise { get; set; }
    public bool IsDrivable { get; set; }

    public Car()
    {
        
    }

    public Car(int year, string make, string model, string engineNoise, string honkNoise, bool isDrivable)
    {
        Year = year;
        Make = make;
        Model = model;
        EngineNoise = engineNoise;
        HonkNoise = honkNoise;
        IsDrivable = isDrivable;
    }

    public static void MakeEngineNoise(string EngineNoise)
    {
        Console.WriteLine(EngineNoise);
    }

    public static void MakeHonkNoise(string HonkNoise)
    {
        Console.WriteLine(HonkNoise);
    }
}