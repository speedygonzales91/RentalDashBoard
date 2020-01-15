using System;

namespace RentalDashBoard.Core
{
    /// <summary>
    /// Számlát kezelő osztály
    /// Tulajdonságok: 
    ///     - Adott időpecséttell döntöm el melyik hónapra vonatkozik
    ///     - Típus enumban tárolva
    ///     - Megjegyzés: szöveges hozzáfűznivaló rögzítésére
    ///     - Link: itt lehet tárolni a számlához tartozó fényképet.
    /// </summary>
    public class Bill
    {
        public int Id { get; set; }

        public BillType BillType { get; set; }

        public string Comment { get; set; }

        public string Link { get; set; }
    }
}
