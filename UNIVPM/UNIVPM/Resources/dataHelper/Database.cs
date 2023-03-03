using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using UNIVPM.Resources.Model;
using SQLite;

namespace UNIVPM.Resources.DataHelper
{
    class Database
    {
        string folder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
        public bool createDatabase()
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(System.IO.Path.Combine(folder, "SQLite.db3")))
                {
                    connection.CreateTable<UNIVPM.Resources.Model.Eventi>();
                    return true;
                }
            }
            catch (SQLiteException ex)
            {
                Log.Info("SQLiteEx", ex.Message);
                return false;
            }
        }

        public bool insertIntoTableEventi(Model.Eventi evento)
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "SQLite.db3")))
                {
                    connection.Insert(evento);
                    return true;
                }
            }
            catch (SQLiteException ex)
            {
                Log.Info("SQLiteEx", ex.Message);
                return false;
            }
        }

        public List<Model.Eventi> selectTableEventi()
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "SQLite.db3")))
                {
                    return connection.Table<Model.Eventi>().ToList();

                }
            }
            catch (SQLiteException ex)
            {
                Log.Info("SQLiteEx", ex.Message);
                return null;
            }
        }

        public bool deleteTableEventi()
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "SQLite.db3")))
                {
                    connection.DropTable<UNIVPM.Resources.Model.Eventi>();
                    return true;
                }
            }
            catch (SQLiteException ex)
            {
                Log.Info("SQLiteEx", ex.Message);
                return false;
            }
        }

    }
}