using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursovayaOOP.Services
{
	internal static class ControlOverInputData
	{
		public static Validation Rules(this TextBox textBox) => new Validation(textBox.Text);
	}
}
