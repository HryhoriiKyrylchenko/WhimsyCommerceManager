namespace Whimsy_WebAPI.Enums.Inventory
{
    /// <summary>
    /// Specifies the type of label used for identifying or tracking items.
    /// </summary>
    public enum LabelType
    {
        /// <summary>
        /// Represents a label with a barcode.
        /// </summary>
        Barcode,

        /// <summary>
        /// Represents a label with a QR code.
        /// </summary>
        QRCode,

        /// <summary>
        /// Represents a label with an RFID (Radio Frequency Identification) tag.
        /// </summary>
        RFID,

        /// <summary>
        /// Represents any other type of label not specifically listed.
        /// </summary>
        Other
    }
}
