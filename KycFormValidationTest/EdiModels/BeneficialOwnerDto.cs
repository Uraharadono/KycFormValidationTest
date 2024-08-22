
using KycFormValidationTest.Models;

namespace KycFormValidationTest.EdiModels;

/// <summary>
/// Information about beneficial owner of the company.
/// It iss also used for alternative beneficial owner.
/// </summary>
public class BeneficialOwnerDto
{
    /// <summary>
    /// First name.
    /// </summary>
    public string FirstName { get; set; }

    /// <summary>
    /// Last name.
    /// </summary>
    public string LastName { get; set; }

    /// <summary>
    /// Date of birth.
    /// </summary>
    public DateTime DateOfBirth { get; set; }

    /// <summary>
    /// Role in company.
    /// </summary>
    public RolesEnum? Role { get; set; }

    /// <summary>
    /// If OTHER is selected in Role field, this field should be populated.
    /// </summary>
    public string? RoleOther { get; set; }

    /// <summary>
    /// Address of the beneficial owner.
    /// </summary>
    public AddressDto Address { get; set; }

    /// <summary>
    /// Represents the list of National Ids (SSN, Passport, Driving license etc.).
    /// </summary>
    public List<NationalIdDto> NationalIDs { get; set; }

    /// <summary>
    /// Represents the list of citizenship and connections to those countries.
    /// </summary>
    public List<CitizenshipDto> Citizenships { get; set; }

    /// <summary>
    /// List of countries which are tied to tax residency.
    /// </summary>
    public List<string> TaxResidency { get; set; }

    /// <summary>
    /// Ownership of the company details.
    /// </summary>
    public OwnershipDto Ownership { get; set; }

    /// <summary>
    /// Represents if the person own the company/organization together with one or more family members.
    /// </summary>
    public bool IsJointlyOwned { get; set; }

    /// <summary>
    /// Politically exposed person information.
    /// </summary>
    public PepDto Pep { get; set; }
}
