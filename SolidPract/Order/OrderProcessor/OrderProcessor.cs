using SolidPract.Order.Inventory;
using SolidPract.Order.Notification;
using System;

namespace SolidPract.Order.Processor
{
	internal class OrderProcessor : IOrderProcessor
	{
		private readonly Order _order;
		private readonly IDiscount _discount;
		private readonly IInventoryService _inventoryService;
		private readonly INotificationSender _notificationSender;

		public OrderProcessor(Order Order, IDiscount Discount, IInventoryService inventoryService, INotificationSender notificationSender)
		{
			this._order = Order;
			this._discount = Discount;
			this._inventoryService = inventoryService;
			this._notificationSender = notificationSender;
		}

		public void ProcessOrder()
		{
			double price = _order.GetSumm() - _discount.GetDiscount();
			_inventoryService.CheckInventory();
			_notificationSender.SendNotification();

			Console.WriteLine($"Оформлен чек. Стоимость: {price.ToString()}. Скидка: {_discount.ToString()} руб.");
		}
	}
}
