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
    public class Docenti
    {
        [PrimaryKey, AutoIncrement]
        public int CodDoc { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Settore { get; set; }
        public string Ruolo { get; set; }
        public string Struttura { get; set; }
        public string Indirizzo { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
    }
}