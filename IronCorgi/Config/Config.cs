using System;
using System.Collections.Generic;
using IronCorgi.Model;

namespace IronCorgi.Config
{
	/// <summary>
	/// Description of Config.
	/// </summary>
	public class Config
	{
		private List<Account> _accounts = new List<Account>();

		public List<Account> Accounts 
		{
			get {
				return _accounts;
			}
		}
		
		private void InitDatabase()
		{
			//
		}
		
		public Config()
		{
			InitDatabase();
		}
	}
}
