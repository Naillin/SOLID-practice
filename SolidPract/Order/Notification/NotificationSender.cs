using System;

namespace SolidPract.Order.Notification
{
	internal class NotificationSender : INotificationSender
	{
		private readonly Order _order;
		public NotificationSender(Order order)
		{
			this._order = order;
		}

		public void SendNotification()
		{
			Console.WriteLine("Отправка письма клиенту.");
		}
	}
}
