using System;
using System.Reflection;
using task_3;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter signals of traffic lights = ");
        string[] initialSignals = Console.ReadLine().Split();
        Line();
        Console.Write("Enter amount of command = ");
        int commandsAmount = int.Parse(Console.ReadLine());
        Line();

        TrafficLight[] trafficLights = new TrafficLight[initialSignals.Length];
        for (int i = 0; i < initialSignals.Length; i++)
        {
            trafficLights[i] = new TrafficLight(initialSignals[i]);
        }

        for (int i = 0; i < commandsAmount; i++)
        {
            for (int j = 0; j < trafficLights.Length; j++)
            {
                trafficLights[j].ChangeSignal();
                Console.Write(trafficLights[j].GetCurrentSignal() + " ");
            }
            Console.WriteLine();
        }
    }

    public static void Line()
    {
        Console.WriteLine("=======================================");
    }
}
