using System;

namespace VOYAGER
{
	class SQLConnectionClass
	{
		public static string conReturn()
		{
			// Modify the connection string to connect to an online MySQL database
			string serverAddress = "sql6.freemysqlhosting.net";
			string databaseName = "sql6686661";
			string username = "sql6686661";
			string password = "uZlIiDl1bZ";
			int port = 3306; // MySQL default port number

			return $"Server={serverAddress};Port={port};Database={databaseName};Uid={username};Pwd={password};";
		}
	}
}
