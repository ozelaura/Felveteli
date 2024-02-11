using System;

namespace Felveteli
{
    internal class Felvetelizo
    {
        private string _om_Azonosito;

        public string OM_Azonosito
        {
            get { return _om_Azonosito; }
            set { _om_Azonosito = value; }
        }

        private string _nev;

        public string Nev
        {
            get { return _nev; }
            set { _nev = value; }
        }

        private string _ertesitesiCim;

        public string ErtesitesiCim
        {
            get { return _ertesitesiCim; }
            set { _ertesitesiCim = value; }
        }


        private DateTime _szuletesiDatum;
        public DateTime SzuletesiDatum
        {
            get { return _szuletesiDatum; }
            set { _szuletesiDatum = value; }
        }

        private string _email;
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        private int _magyarPontok;
        public int MagyarPontok
        {
            get { return _magyarPontok; }
            set { _magyarPontok = value; }
        }

        private int _matekPontok;
        public int MatekPontok
        {
            get { return _matekPontok; }
            set { _matekPontok = value; }
        }

        public Felvetelizo(string azonosito, string nev, string ertesitesiCim, DateTime szuletesiDatum, string email, int matekPontok, int magyarPontok)
        {
            this._om_Azonosito = azonosito;
            this._nev = nev;
            this._ertesitesiCim = ertesitesiCim;
            this._szuletesiDatum = szuletesiDatum;
            this._email = email;
            this._matekPontok = matekPontok;
            this._magyarPontok = magyarPontok;
        }
    }
}
