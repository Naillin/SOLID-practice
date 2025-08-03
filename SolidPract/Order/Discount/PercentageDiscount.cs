using System;
using ProductUnit = SolidPract.Product.Product;

namespace SolidPract.Order.Discount
{
	internal class PercentageDiscount : Discount
	{
		private Order _order;

		public PercentageDiscount(Order Order)
		{
			this._order = Order;
		}

		public override double GetDiscount()
		{
			double result = 1.0;
			
			try
			{
				ProductUnit accent = _order.Products[0];
				foreach (ProductUnit product in _order.Products)
					if (accent.Count < product.Count)
						accent = product;

				while (result >= 1.0)
					result = (accent.Count * accent.Cost) / 100;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}

			return result;
		}
	}
}
