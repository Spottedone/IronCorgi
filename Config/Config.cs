using IronCorgi.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;

namespace IronCorgi.Config
{
	/// <summary>
	/// Description of Config.
	/// </summary>
	public static class Config
	{
		private static List<Account> _accounts = new List<Account>();
		private static SQLiteConnection _connection;
		private const string DbName = "ICConfig.db";
		private static bool _initialized = false;

		public static List<Account> Accounts
		{
			get
			{
				return _accounts;
			}
		}

		public static bool Initialized
		{
			get
			{
				return _initialized;
			}
		}

		public static void InitDatabase()
		{
			try
			{
				var path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
				_connection = new SQLiteConnection(Path.Combine(path, DbName));
				_connection.CreateTable<Account>();
				// load accounts
				var table = _connection.Table<Account>();
				foreach(var acc in table)
				{
					_accounts.Add(acc);
				}
				_initialized = true;
			}
			catch (Exception)
			{
				_initialized = false;
				throw;
			}
		}

		public static void Save()
		{
			var table = _connection.Table<Account>();
			_connection.DeleteAll<Account>();
			_connection.InsertAll(_accounts);
		}
	}
}