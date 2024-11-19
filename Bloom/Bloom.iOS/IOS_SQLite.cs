using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xamarin.Forms;
using SQLite;
using Bloom.iOS;
using Bloom;
[assembly: Dependency(typeof(IOS_SQLite))]
namespace Bloom.iOS
{
    public class IOS_SQLite : ISQLite
    {
        public SQLiteConnection GetConnection()
        {
            var dbName = "MyDB.db3";
            string dbPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal); 
            string libraryPath = Path.Combine(dbPath, "..", "Library"); 
            var path = Path.Combine(libraryPath, dbName);
            var conn = new SQLite.SQLiteConnection(path);
            return conn;
        }
    }
}