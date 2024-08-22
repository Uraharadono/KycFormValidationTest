
using KycFormValidationTest.Models;

namespace KycFormValidationTest.EdiModels;

/// <summary>
/// Represents citizenship and connections to countries.
/// </summary>
public class CitizenshipDto
{
    /// <summary>
    /// Country of citizenship.
    /// </summary>
    public string Country { get; set; }

    /// <summary>
    /// List of connections to citizenship country.
    /// </summary>
    public List<ConnectionToCountryEnum> ConnectionToCountry { get; set; }
}