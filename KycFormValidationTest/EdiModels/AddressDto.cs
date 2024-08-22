namespace KycFormValidationTest.EdiModels;

/// <summary>
/// Address DTO.
/// </summary>
public class AddressDto
{
    /// <summary>
    /// Street address.
    /// </summary>
    public string Street { get; set; }

    /// <summary>
    /// Post code.
    /// </summary>
    public string Postcode { get; set; }

    /// <summary>
    /// City.
    /// </summary>
    public string City { get; set; }

    /// <summary>
    /// Country.
    /// </summary>
    public string Country { get; set; }
}