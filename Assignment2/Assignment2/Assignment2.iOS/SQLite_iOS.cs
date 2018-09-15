using System;
using Xamarin.Forms;
using System.IO;
using SQLite;
using Assignment2.iOS;

[assembly: Dependency (typeof (SQLite_iOS))]

namespace Assignment2.iOS
{
	public class SQLite_iOS : ISQLite
	{
		public SQLite_iOS ()
		{
		}

		#region ISQLite implementation
		public SQLiteConnection GetConnection ()
		{
			var sqliteFilename = "ass2.db3";
			string documentsPath = Environment.GetFolderPath (Environment.SpecialFolder.Personal); // Documents folder
			string libraryPath = Path.Combine (documentsPath, "..", "Library"); // Library folder
			var path = Path.Combine(libraryPath, sqliteFilename);

			// This is where we copy in the prepopulated database
			Console.WriteLine (path);
			if (!File.Exists (path)) {
				File.Copy (sqliteFilename, path);
			}
				
			var conn = new SQLiteConnection(path);

			// Return the database connection 
			return conn;
		}
		#endregion
	}
}
