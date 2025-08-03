
namespace SolidPract.Order.Discount
{
	internal abstract class Discount : IDiscount
	{
		public abstract double GetDiscount();

		public override string ToString()
		{
			return GetDiscount().ToString();
		}
	}
}
