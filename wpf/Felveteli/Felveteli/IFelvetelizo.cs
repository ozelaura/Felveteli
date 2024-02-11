using System;

namespace Felveteli
{
    internal interface IFelvetelizo
    {
        string OM_Azonosito { get; set; }
        string Nev { get; set; }
        string ErtesitesiCim { get; set; }
        string Email { get; set; }
        DateTime SzuletesiDatum { get; set; }
        int Matematika { get; set; }
        int Magyar { get; set; }
        string CSVSortAdVissza();
        void ModositCSVSorral(string csvString);
    }
}
