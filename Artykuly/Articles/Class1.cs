using System.Data.SQLite;
using Microsoft.Data;
using System;
using System.Data;

namespace Articles
{
	public class DatabaseActions
	{
		private static string dbPath = @"Data source=C:\Users\Xopero\Documents\Praktyki\Github\Artykuly\Articles\artykuly.db";

		public static DataTable ExecuteQuery(String query)
		{

			SQLiteConnection connection = new SQLiteConnection(dbPath);
			connection.Open();
			SQLiteCommand command = new SQLiteCommand(query, connection);
			SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
			DataTable dataTable = new DataTable();

			adapter.Fill(dataTable);
			return dataTable;
		}

		public static int ExecuteNonQuery(String query)
		{
			SQLiteConnection connection = new SQLiteConnection(dbPath);
			connection.Open();
			SQLiteCommand command = new SQLiteCommand(query, connection);
			command.CommandText = query;
			command.CommandType = CommandType.Text;
			
			return command.ExecuteNonQuery();
		}
	}
}