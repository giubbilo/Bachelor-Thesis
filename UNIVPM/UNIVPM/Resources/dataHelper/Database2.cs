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
    class Database2
    {
        string folder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
        public bool createDatabase()
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(System.IO.Path.Combine(folder, "SQLite1.db3")))
                {
                    connection.CreateTable<UNIVPM.Resources.Model.Docenti>();
                    return true;
                }
            }
            catch (SQLiteException ex)
            {
                Log.Info("SQLiteEx", ex.Message);
                return false;
            }
        }

        public bool insertIntoTableDocenti(Model.Docenti docente)
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "SQLite1.db3")))
                {
                    connection.Insert(docente);
                    return true;
                }
            }
            catch (SQLiteException ex)
            {
                Log.Info("SQLiteEx", ex.Message);
                return false;
            }
        }

        public List<Model.Docenti> selectTableDocenti(string value)
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "SQLite1.db3")))
                {
                    return connection.Query<Model.Docenti>("SELECT * FROM Docenti Where Cognome=?", value).ToList();
                }
            }
            catch (SQLiteException ex)
            {
                Log.Info("SQLiteEx", ex.Message);
                return null;
            }
        }

        public bool deleteTableDocenti()
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "SQLite1.db3")))
                {
                    connection.DropTable<UNIVPM.Resources.Model.Docenti>();
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