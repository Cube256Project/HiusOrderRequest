namespace Applications.HIUS.Interfaces.Sonnerie
{
    public class ObjectRecord : PostalLocation
    {
        /// <summary>
        /// Eidgenössische Gebäude Identifikation, optional.
        /// </summary>
        public string EGID;

        /// <summary>
        /// Objekt-Referenz Verwaltung.
        /// </summary>
        public string ID;

        /// <summary>
        /// Angabe Stockwerk, optional.
        /// </summary>
        public string Floor;

        /// <summary>
        /// Externe Objekt-Referenz, optional.
        /// </summary>
        public string ExternalObjectNumber;
    }
}
