namespace KycFormValidationTest.EdiModels;

/// <summary>
/// Private user information.
/// </summary>
public class PrivateUserInfoDto
{
    /// <summary>
    /// First name.
    /// </summary>
    public string Firstname { get; set; }

    /// <summary>
    /// Last name.
    /// </summary>
    public string Lastname { get; set; }

    /// <summary>
    /// Address information.
    /// </summary>
    public AddressDto Address { get; set; }

    /// <summary>
    /// List of countries which are tied to tax residency.
    /// </summary>
    public List<string> TaxResidency { get; set; }

    /// <summary>
    /// List of citizenship and connections to the countries.
    /// </summary>
    public List<CitizenshipDto> Citizenships { get; set; }

    /// <summary>
    /// Politically exposed person information.
    /// </summary>
    public PepDto PepInfo { get; set; }
}