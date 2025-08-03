
namespace SolidPract.Customer
{
	internal class Customer
	{
		private string _name = string.Empty;
		public string Name { get { return _name; } set { _name = value; } }

		private string _email = string.Empty;
		public string Email { get { return _email; } set { _email = value; } }

		private string _address = string.Empty;
		public string Address { get { return _address; } set { _address = value; } }

		public Customer(string Name, string Email, string Address)
		{
			this.Name = Name;
			this.Email = Email;
			this.Address = Address;
		}
	}
}
