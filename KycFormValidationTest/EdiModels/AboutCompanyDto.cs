using KycFormValidationTest.Models;

namespace KycFormValidationTest.EdiModels;

/// <summary>
/// Information about company.
/// </summary>
public class AboutCompanyDto
{
    /// <summary>
    /// Company name.
    /// </summary>
    public string CompanyName { get; set; }

    /// <summary>
    /// Country in which the company has been registered.
    /// </summary>
    public string CountryOfRegistration { get; set; }

    /// <summary>
    /// Organization number.
    /// </summary>
    public string OrganizationNumber { get; set; }

    /// <summary>
    /// Company form enum.
    /// </summary>
    public CompanyFormEnum CompanyForm { get; set; }

    /// <summary>
    /// If OTHER is selected from company form this field should be populated.
    /// </summary>
    public string? CompanyFormOther { get; set; }

    /// <summary>
    /// Multi-select field for company revenues.
    /// </summary>
    public List<CompanyRevenueEnum> CompanyRevenues { get; set; }

    /// <summary>
    /// If OTHER is selected from company revenue this field should be populated.
    /// </summary>
    public string CompanyRevenueOther { get; set; }

    /// <summary>
    /// Company address information.
    /// </summary>
    public AddressDto CompanyAddress { get; set; }

    /// <summary>
    /// Company contact information.
    /// </summary>
    public ContactDto CompanyContact { get; set; }
}