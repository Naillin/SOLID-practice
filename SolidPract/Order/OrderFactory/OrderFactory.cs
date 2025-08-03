using CustomerUnit = SolidPract.Customer.Customer;

namespace SolidPract.Order.OrderFactory
{
	internal class OrderFactory : IOrderFactory
	{
		public Order Create(CustomerUnit customer)
		{
			return new Order(customer);
		}
	}
}
