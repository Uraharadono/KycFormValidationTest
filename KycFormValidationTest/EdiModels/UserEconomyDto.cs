using KycFormValidationTest.Models;

/// <summary>
/// User economy information.
/// </summary>
public class UserEconomyDto
{
    /// <summary>
    /// Employment status.
    /// </summary>
    public EmploymentStatusEnum Employment { get; set; }

    /// <summary>
    /// Salary.
    /// </summary>
    public decimal Salary { get; set; }

    /// <summary>
    /// Currency.
    /// </summary>
    public string Currency { get; set; }

    /// <summary>
    /// Represents the main sources for the funds used for payments/payments through Finshark.
    /// </summary>
    public List<MainSourceFundsEnum> MainFundSources { get; set; }

    /// <summary>
    /// If OTHER is selected in MainFundSources, this field should be populated.
    /// </summary>
    public string? FundSourceOther { get; set; }
}