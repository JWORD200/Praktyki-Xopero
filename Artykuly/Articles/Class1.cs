using Microsoft.Data.Sqlite;
using Microsoft.Data;
using System;

public class DatabaseActions
{
	public DatabaseActions()
	{
		if (File.Exists("artykuly.db"))
		{
			
		}
		else
		{

		}
	}

	public Connector GetArticleDetails()
	{

	}

}

public class Connector
{
	private static string dbPath = @"Data source=C:\Users\Xopero\Documents\Praktyki\Github\Artykuly\Articles\artykuly.db";
	public Connector(string querry)
	{
        SqliteConnection connection = new SqliteConnection(dbPath);
		connection.Open();
		SqliteCommand command = connection.CreateCommand();
		command.CommandText = querry;
		SqliteDataReader
		

    }
}
