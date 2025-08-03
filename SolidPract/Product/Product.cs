
namespace SolidPract.Product
{
	internal class Product
	{
		private string _name;
		public string Name { get { return _name; } set { _name = value; } }

		private double _cost;
		public double Cost { get { return _cost; } set { _cost = value; } }

		private int _count;
		public int Count { get { return _count; } set { _count = value; } }

		public Product(string Name, double Cost, int Count)
		{
			this.Name = Name;
			this.Cost = Cost;
			this.Count = Count;
		}
	}
}
