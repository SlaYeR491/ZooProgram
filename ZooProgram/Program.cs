using ZooProgram;
using ZooProgram.Animals;
using ZooProgram.Interfaces;

static void ShowMammals(Zoo zoo)
{
	foreach (var mammal in zoo.Mammals)
		Console.WriteLine($"Name:{mammal.Name} Sexual:{mammal.Type} Age:{mammal.Age}");
}

static void ShowBirds(Zoo zoo)
{
	foreach (var bird in zoo.Birds)
		Console.WriteLine($"Name:{bird.Name} Sexual:{bird.Type} Age:{bird.Age}");
}

var l = new Lion
{
	Age = 9,
	Name = "Lion321",
	Type = Sexual.Male
};
var b = new Cannary
{
	Age = 5,
	Name = "Tweety",
	Type = Sexual.Male
};

var zoo = new Zoo();

zoo.AddAnimal(b);
zoo.AddAnimal(l);

ShowMammals(zoo);
Console.WriteLine("********************************");
ShowBirds (zoo);

//After Change The Lion Age
l.Age = 11;
try
{
	Thread.Sleep(1000);
	ShowMammals(zoo);
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}