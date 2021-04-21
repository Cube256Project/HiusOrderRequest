using System;

namespace Applications.HIUS.Interfaces.Sonnerie
{
    /// <summary>
    /// P3313-06: HIUS Sonnerie Bestellung Request.
    /// </summary>
    public class OrderRequest
    {
        #region Elements

        /// <summary>
        /// Bestelldatum.
        /// </summary>
        public DateTime OrderDate;

        /// <summary>
        /// Bestellnummer.
        /// </summary>
        public string OrderID;

        /// <summary>
        /// Einzugstermin.
        /// </summary>
        public DateTime InstallationDate;

        /// <summary>
        /// Liegenschaft.
        /// </summary>
        public ObjectRecord Object;

        /// <summary>
        /// Mieter, Felder [FirstName] und [LastName] sind erforderlich.
        /// </summary>
        public Contact Tenant;

        /// <summary>
        /// Rechnungsadresse.
        /// </summary>
        public Contact InvoiceTo;

        /// <summary>
        /// Lieferadresse.
        /// </summary>
        public Contact DeliverTo;

        /// <summary>
        /// Adresse Hauswart.
        /// </summary>
        public Contact Janitor;

        /// <summary>
        /// Property manager information. 
        /// </summary>
        public Contact PropertyManager;

        /// <summary>
        /// Beschriftung Sonnerie-Elemente.
        /// </summary>
        public Panel[] Panels;

        #endregion
    }
}
