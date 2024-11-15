using Microsoft.AspNetCore.DataProtection;

namespace Whimsy_WebAPI.Services.Business.Finance
{
    /// <summary>
    /// Service for securely encrypting and decrypting IBAN strings.
    /// Utilizes data protection to ensure sensitive data is stored securely.
    /// </summary>
    /// <remarks>
    /// Initializes a new instance of the <see cref="BankAccountService"/> class with a specified data protection provider.
    /// </remarks>
    /// <param name="provider">The data protection provider used to create a data protector.</param>
    public class BankAccountService(IDataProtectionProvider provider) : IBankAccountService
    {
        private readonly IDataProtector _protector = provider.CreateProtector("Whimsy.IBANProtector");

        /// <summary>
        /// Encrypts a plain IBAN string for secure storage.
        /// </summary>
        /// <param name="iban">The IBAN to encrypt.</param>
        /// <returns>An encrypted version of the IBAN.</returns>
        public string EncryptIBAN(string iban)
        {
            return _protector.Protect(iban);
        }

        /// <summary>
        /// Decrypts an encrypted IBAN string to its original form.
        /// </summary>
        /// <param name="encryptedIban">The encrypted IBAN to decrypt.</param>
        /// <returns>The decrypted, plain-text IBAN.</returns>
        public string DecryptIBAN(string encryptedIban)
        {
            return _protector.Unprotect(encryptedIban);
        }
    }
}
