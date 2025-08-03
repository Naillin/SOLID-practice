
namespace SolidPract.Order.Discount
{
	internal class FixedDiscount : Discount
	{
		private Order _order;

		public FixedDiscount(Order Order)
		{
			this._order = Order;
		}

		public override double GetDiscount()
		{
			double result = _order.GetSumm() * (Program.DISCOUNT_FIXED / 100);
			
			return result;
		}
	}
}
