namespace KycFormValidationTest.EdiModels;

/// <summary>
/// Request to save private user form to database.
/// </summary>
public class SavePrivateFormRequest
{
    /// <summary>
    /// Private user information.
    /// </summary>
    public PrivateUserInfoDto PrivateUserInfo { get; set; }

    /// <summary>
    /// User economy information.
    /// </summary>
    public UserEconomyDto UserEconomy { get; set; }

    /// <summary>
    /// Purpose of using Finshark product.
    /// </summary>
    public PurposeAndTransactionsDto PurposeAndTransactions { get; set; }
}