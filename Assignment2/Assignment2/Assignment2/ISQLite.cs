using System;
using SQLite;

namespace Assignment2
{
	public interface ISQLite
	{
		SQLiteConnection GetConnection();
	}
}

