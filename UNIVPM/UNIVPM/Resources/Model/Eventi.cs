using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite;

namespace UNIVPM.Resources.Model
{
    public class Eventi
    {
        [PrimaryKey, AutoIncrement]
        public int CodEv { get; set; }
        public string Descrizione { get; set; }
        public string Data { get; set; }
    }
}