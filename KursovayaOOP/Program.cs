using KursovayaOOP.Forms.AdministratorForm;
using KursovayaOOP.Forms.CommodityExpertForms;
using KursovayaOOP.Forms.DirectorForms;
using KursovayaOOP.Forms.DispatcherForms;
using System;
using System.Windows.Forms;

namespace KursovayaOOP
{
	internal static class Program
	{
		/// <summary>
		/// Главная точка входа для приложения.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new DirectorWindow());
		}
	}
}
