using ZooProgram.Interfaces;

namespace ZooProgram
{
	internal class Zoo
	{
		public Zoo()
		{
			Thread t = new Thread(RemoveAnimal);
			t.IsBackground = true;
			t.Start();
		}
		public List<IMammal> Mammals { get; } = new();
		public List<IBird> Birds { get; } = new();
		public void AddAnimal(IAnimal animal)
		{
			if (CheckAnimalAge(animal.Age))
				AddToRightSpecies(animal);
			else
				throw new InvalidOperationException("Animal Age Is Greater Than 10");
		}
		private void RemoveAnimal()
		{
			while (true)
			{
				if (Mammals.Count() > 0)
				{
					var animal = Mammals.ElementAt(0);
					if (!CheckAnimalAge(animal.Age) || !animal.IsAlive)
						Mammals.RemoveAt(0);
				}

				if (Birds.Count() > 0)
				{
					var animal = Birds.ElementAt(0);
					if (!CheckAnimalAge(animal.Age) || !animal.IsAlive)
						Birds.RemoveAt(0);
				}

			}
		}

		private bool CheckAnimalAge(int age)
		=> age <= 10;
		private void AddToRightSpecies(IAnimal animal)
		{
			if (animal is IMammal)
				Mammals.Add((IMammal)animal);
			else
				Birds.Add((IBird)animal);
		}

	}
}
