using CustomerUnit = SolidPract.Customer.Customer;

namespace SolidPract.Order.OrderFactory
{
	internal interface IOrderFactory
	{
		Order Create(CustomerUnit customer);
	}
}
