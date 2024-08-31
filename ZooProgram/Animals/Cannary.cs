using ZooProgram.Interfaces;

namespace ZooProgram.Animals
{
	internal class Cannary : IBird
	{
		public string Name { get; set; }
		public int Age { get; set; }
		public Sexual Type { get; set; }
		public bool IsAlive { get; set; } = true;
	}
}
