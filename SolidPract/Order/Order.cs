using System.Collections.Generic;

using ProductUnit = SolidPract.Product.Product;
using CustomerUnit = SolidPract.Customer.Customer;

namespace SolidPract.Order
{
	internal class Order : IOrder
	{
		public enum Statuses
		{
			NONE = 0,
			UNPAYED = 1,
			PAYED = 2,
		}

		private readonly int _id;
		public int Id { get { return _id; } }

		private readonly CustomerUnit _customer;
		public CustomerUnit Customer { get { return _customer; } }

		private List<ProductUnit> _products;
		public List<ProductUnit> Products { get { return _products; } }


		private Statuses _status = Statuses.NONE;
		public Statuses Status { get { return _status; } set { _status = value; } }

		public Order(CustomerUnit Customer, Statuses Status = Statuses.UNPAYED)
		{
			this._id = 0;
			this._customer = Customer;
			this._products = new List<ProductUnit>();
			this.Status = Status;
		}

		public double GetSumm()
		{
			double result = 0.0;

			foreach (ProductUnit product in _products)
				result = (double)(result + product.Cost * product.Count);

			return result;
		}
	}
}
