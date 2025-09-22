// See https://aka.ms/new-console-template for more information
using Bees;
using Bees.Model;
using Microsoft.Extensions.DependencyInjection;

var container = new ServiceCollection();
container.AddTransient<IPunishBees, BeePunisher>();

var bees = new List<BeeBase>();

for(int i = 0; i < 10; i++)
{
    bees.Add(new Drone());
    bees.Add(new Worker());
    bees.Add(new Queen());
}

Console.WriteLine($"We have {bees.Count} bees");


var punisher = container.

while (true)
{
    foreach (var bee in bees)
    {
        Console.WriteLine($"Bee type: {bee.GetType()} Health: {bee.Health}");
        if (bee.Dead)
        {
            Console.WriteLine("(The bee is dead)");
        }
    }

    Console.ReadKey();

    Console.Clear();

    punisher.Punish(bees);
}

