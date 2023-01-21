using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovayaOOP.Modals
{
	internal static class Bank
	{
		public static bool CheckingAvailabilityMoneyOnTheCard(this long numberCard)
			=> new Random().Next(0, 2) == 1;

		public static bool CheckingExistenceCard(this long numberCard)
		   => new Random().Next(0, 2) == 1;
	}
}
