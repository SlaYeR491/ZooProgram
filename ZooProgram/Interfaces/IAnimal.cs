namespace ZooProgram.Interfaces
{
	public interface IAnimal
	{
		public string Name { get; set; }
		public int Age { get; set; }
		public Sexual Type { get; set; }
		public bool IsAlive { get; set; }
	}
	public enum Sexual
	{
		Male = 1,
		Female = 2
	}
}
