using System.Text.RegularExpressions;

namespace KursovayaOOP.Services
{
	internal class Validation
	{
		private string _str;

		public Validation(string str)
		{
			_str = str;
		}

		public bool CheckingNumberOfCharacters(int lenght)
			=> _str.Length >= lenght;

		public bool CorrectnessPassword()
			=> new Regex(@"[0-9a-zA-Z]{8}").IsMatch(_str);

		public bool CorrectnessOfEnteredPhoneNumber()
			=> new Regex(@"^((\+375)[\- ]?)?((33|29|25|44)?[\- ]?)?[\d\- ]{7}$").IsMatch(_str);

		public bool CorrectnessOfReceivedString()
			=> new Regex(@"[a-zA-Zа-яА-Я]").IsMatch(_str);
		public bool CorrectnessOfRecivedInt()
			=> new Regex(@"[0-9]").IsMatch(_str);
		public bool CorrectnessOfDecimal()
			=> new Regex(@"^[0-9]*(?:\,[0-9]*)?$").IsMatch(_str);
	}
}
