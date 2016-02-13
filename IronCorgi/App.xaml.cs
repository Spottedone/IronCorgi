using System;
using System.Windows;
using System.Data;
using System.Xml;
using System.Configuration;
using IronCorgi.Config;
using IronCorgi.Model;
using System.Linq;
using System.Windows.Threading;

namespace IronCorgi
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
		private void Application_Startup(object sender, StartupEventArgs e)
		{
			Config.Config.InitDatabase();
			var mainWnd = new MainWindow();
			mainWnd.Show();

			if (!Config.Config.Accounts.Any())
			{
				var testAccount = new Account();
				var accWnd = new AccountProperties();
				var result = accWnd.ShowDialog();
				if (!result.HasValue || result.Value == false)
				{
					// bail out
					ShowMessage("No accounts created, exiting.");
					Shutdown();
				}
			}
		}

		private void Application_Exit(object sender, ExitEventArgs e)
		{
			Config.Config.Save();
		}

		public void ShowMessage(string text)
		{
			MessageBox.Show(text);
		}

		private void Application_DispatcherUnhandledException(object sender, 
			DispatcherUnhandledExceptionEventArgs e)
		{
			ShowMessage(e.Exception.Message);
		}
	}
}