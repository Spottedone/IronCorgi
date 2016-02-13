namespace IronCorgi.Model
{
	/// <summary>
	/// A representation for mail account data.
	/// </summary>
	public class Account
	{
		public string Name { get; set; }
		public string Server { get; set; }
		public string Login { get; set; }
		public string Password { get; set; }
		public int Port { get; set; }
		public bool UseSSL { get; set; }

		public Account()
		{

		}

		public Account(string name, string server, string login, string password, int port, bool useSSL = true)
		{
			Name = name;
			Server = server;
			Login = login;
			Password = password;
			Port = port;
			UseSSL = useSSL;
		}
	}
}