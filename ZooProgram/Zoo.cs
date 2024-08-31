using ZooProgram.Interfaces;

namespace ZooProgram
{
	internal class Zoo
	{
		public Zoo()
		{
			Task.Run(RemoveAnimal);
		}
		public List<IMammal> Mammals { get; } = new();
		public List<IBird> Birds { get; } = new();
		public void AddAnimal(IAnimal animal)
		{
			if (CheckAnimalBeforeAdd(animal))
				AddToRightSpecies(animal);
			else
				throw new InvalidOperationException("Animal Age Is Greater Than 10 Or Dead");
		}
		private void RemoveAnimal()
		{
			while (true)
			{
				if (Mammals.Count > 0)
				{
					var animal = Mammals.ElementAt(0);
					if (!CheckAnimalBeforeAdd(animal))
						Mammals.RemoveAt(0);
				}

				if (Birds.Count > 0)
				{
					var animal = Birds.ElementAt(0);
					if (!CheckAnimalBeforeAdd(animal))
						Birds.RemoveAt(0);
				}

			}
		}

		private bool CheckAnimalBeforeAdd(IAnimal animal)
		=> animal.Age <= 10 && animal.IsAlive;
		private void AddToRightSpecies(IAnimal animal)
		{
			if (animal is IMammal)
				Mammals.Add((IMammal)animal);
			else
				Birds.Add((IBird)animal);
		}

	}
}
