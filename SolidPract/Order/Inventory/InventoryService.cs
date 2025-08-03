using System;

namespace SolidPract.Order.Inventory
{
	internal class InventoryService : IInventoryService
	{

		private readonly Order _order;

		public InventoryService(Order order)
		{
			_order = order;
		}

		public void CheckInventory()
		{
			Console.WriteLine("Работа с базой данных инвентаря!");
		}
	}
}
