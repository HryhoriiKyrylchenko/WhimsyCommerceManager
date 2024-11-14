namespace Whimsy_WebAPI.Services.Business.Finance
{
    /// <summary>
    /// Provides methods for encrypting and decrypting sensitive bank account information.
    /// </summary>
    public interface IBankAccountService
    {
        /// <summary>
        /// Decrypts an encrypted IBAN string to its original form.
        /// </summary>
        /// <param name="encryptedIban">The encrypted IBAN to decrypt.</param>
        /// <returns>The decrypted IBAN as a plain string.</returns>
        string DecryptIBAN(string encryptedIban);

        /// <summary>
        /// Encrypts an IBAN string to securely store in the database.
        /// </summary>
        /// <param name="iban">The plain IBAN string to encrypt.</param>
        /// <returns>The encrypted version of the IBAN.</returns>
        string EncryptIBAN(string iban);
    }
}