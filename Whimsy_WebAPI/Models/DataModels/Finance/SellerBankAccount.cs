using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Whimsy_WebAPI.Models.DataModels.UserManagement;
using Whimsy_WebAPI.Services.Business.Finance;

namespace Whimsy_WebAPI.Models.DataModels.Finance
{
    /// <summary>
    /// Represents a bank account for a seller, storing sensitive data in an encrypted format.
    /// </summary>
    /// <remarks>
    /// Initializes a new instance of the <see cref="SellerBankAccount"/> class.
    /// </remarks>
    /// <param name="bankAccountService">The service used for encrypting and decrypting the IBAN.</param>
    [Table("SellerBankAccounts")]
    public class SellerBankAccount(BankAccountService bankAccountService)
    {
        private readonly BankAccountService _bankAccountService = bankAccountService;

        /// <summary>
        /// Gets or sets the unique identifier for the bank account.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the ID of the associated seller.
        /// </summary>
        [Required]
        public string SellerId { get; set; } = null!;

        /// <summary>
        /// Navigation property for the associated seller.
        /// </summary>
        [ForeignKey(nameof(SellerId))]
        public virtual Seller Seller { get; set; } = null!;

        /// <summary>
        /// Gets or sets the encrypted IBAN of the bank account.
        /// This is stored in the database but is decrypted and exposed via the <see cref="IBAN"/> property.
        /// </summary>
        [Required]
        private string EncryptedIBAN { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the decrypted IBAN of the bank account.
        /// The IBAN is encrypted before being stored in the database and decrypted upon retrieval.
        /// </summary>
        [NotMapped]
        public string IBAN
        {
            get => _bankAccountService.DecryptIBAN(EncryptedIBAN);
            set => EncryptedIBAN = _bankAccountService.EncryptIBAN(value);
        }

        /// <summary>
        /// Gets or sets the currency code for the bank account.
        /// </summary>
        [Required]
        [MaxLength(3)]
        public string Currency { get; set; } = "EUR";

        /// <summary>
        /// Gets or sets the date the bank account was created.
        /// </summary>
        [Required]
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// Gets or sets a value indicating whether the bank account is active.
        /// </summary>
        [Required]
        public bool IsActive { get; set; } = true;

        /// <summary>
        /// Gets or sets optional notes related to the bank account.
        /// </summary>
        [MaxLength(1000)]
        public string? Notes { get; set; }
    }
}
