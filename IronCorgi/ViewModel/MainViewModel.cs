using GalaSoft.MvvmLight;
using IronCorgi.Model;
using System.Collections.Generic;

namespace IronCorgi.ViewModel
{
	/// <summary>
	/// This class contains properties that the main View can data bind to.
	/// <para>
	/// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
	/// </para>
	/// <para>
	/// You can also use Blend to data bind with the tool's support.
	/// </para>
	/// <para>
	/// See http://www.galasoft.ch/mvvm
	/// </para>
	/// </summary>
	public class MainViewModel : ViewModelBase
	{
		public List<Message> Messages { get; set; }

		/// <summary>
		/// Initializes a new instance of the MainViewModel class.
		/// </summary>
		public MainViewModel()
		{
			Messages = new List<Message>();
		}

		public async void Refresh()
		{
			var accounts = Config.Config.Accounts;
			//var msgList = await _mailService.GetMessages(accounts.First());
			//Messages.AddRange(msgList);
		}
	}
}