using System.ComponentModel.DataAnnotations;

namespace KycFormValidationTest.EdiModels;

/// <summary>
/// Request to save corporate user form to database.
/// </summary>
public class SaveCorporateFormRequest
{
    /// <summary>
    /// Information about company.
    /// </summary>
    public AboutCompanyDto AboutCompany { get; set; }

    /// <summary>
    /// Information about using finshark product.
    /// </summary>
    [Required]
    public PurposeDto PurposeDto { get; set; }

    /// <summary>
    /// Information about the user which filled the form.
    /// </summary>
    public FilledByDto FilledBy { get; set; }

    /// <summary>
    /// Flag to determine if the corporate user has beneficial owners.
    /// If false, user can have alternative beneficial owners (it's optional).
    /// </summary>
    public bool HasBeneficialOwner { get; set; }

    /// <summary>
    /// List of beneficial owners
    /// If has beneficial owners is false and the list is not empty, those are alternative beneficial owners.
    /// </summary>
    public List<BeneficialOwnerDto>? BeneficialOwners { get; set; }
}