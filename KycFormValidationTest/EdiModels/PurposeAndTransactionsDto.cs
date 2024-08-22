using KycFormValidationTest.Models;

namespace KycFormValidationTest.EdiModels;

/// <summary>
/// Purpose of using Finshark product.
/// </summary>
public class PurposeAndTransactionsDto
{
    /// <summary>
    /// List of purposes of the business relationship.
    /// </summary>
    public List<BusinessPurposeEnum> BusinessPurposes { get; set; }

    /// <summary>
    /// If OTHER is selected in BusinessPurposes, this field should be populated.
    /// </summary>
    public string? BusinessPurposeOther { get; set; }

    /// <summary>
    /// Represents how often does the user intend to conduct transactions through Finshark.
    /// </summary>
    public PrivateTransactionFrequencyEnum TransactionFrequency { get; set; }

    /// <summary>
    /// If OVER_TWELVE is selected in TransactionFrequency, this field should be populated.
    /// </summary>
    public int? TransactionFrequencyOther { get; set; }

    /// <summary>
    /// Represents how much does the user intend to transfer or pay each month.
    /// </summary>
    public PrivateMonthlyTransferAmountEnum MonthlyTransferAmount { get; set; }

    /// <summary>
    /// If OVER_10000_EUR OR OVER_100000_SEK is selected in MonthlyTransferAmount, this field should be populated.
    /// </summary>
    public decimal? MonthlyTransferAmountOther { get; set; }
}