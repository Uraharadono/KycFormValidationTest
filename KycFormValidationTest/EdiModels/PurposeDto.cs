using KycFormValidationTest.Models;

/// <summary>
/// Purpose of using Finshark product.
/// </summary>
public class PurposeDto
{
    /// <summary>
    /// Purpose of the business relationship.
    /// </summary>
    public string PurposeOfBusinessRelationship { get; set; }

    /// <summary>
    /// Represents how often does the company intend to carry out transactions through Finshark.
    /// </summary>
    public CorporateTransactionFrequencyEnum TransactionFrequency { get; set; }

    /// <summary>
    /// If OTHER is selected in TransactionFrequency, this field should be populated.
    /// </summary>
    public decimal? TransactionFrequencyOther { get; set; }

    /// <summary>
    /// Represents how much does the company intend to transfer or pay each month.
    /// </summary>
    public CorporateMonthlyTransferAmountEnum MonthlyTransferAmount { get; set; }

    /// <summary>
    /// If OTHER is selected in MonthlyTransferAmount, this field should be populated.
    /// </summary>
    public decimal? MonthlyTransferAmountOther { get; set; }
}