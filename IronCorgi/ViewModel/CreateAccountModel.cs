using GalaSoft.MvvmLight.Command;
using System.Windows;

namespace IronCorgi.ViewModel
{
	public class CreateAccountModel
	{
		public string UserName { get; set; }
		public string EmailAddress { get; set; }
		public string Password { get; set; }

		public RelayCommand<Window> AddAccountCommand
		{
			get
			{
				return new RelayCommand<Window>(w => { });
			}
		}

		public RelayCommand<Window> CancelCommand
		{
			get
			{
				return new RelayCommand<Window>(w => 
				{
					w.Close();
				});
			}
		}
	}
}
