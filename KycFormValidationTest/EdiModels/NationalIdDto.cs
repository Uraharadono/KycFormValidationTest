using KycFormValidationTest.Models;

namespace KycFormValidationTest.EdiModels;

/// <summary>
/// Represents National Id (SSN, Passport, Driving license etc.)
/// </summary>
public class NationalIdDto
{
    /// <summary>
    /// Country of National ID.
    /// </summary>
    public string Country { get; set; }

    /// <summary>
    /// Type of ID number.
    /// </summary>
    public TypeOfIdNumberEnum TypeOfIdNumber { get; set; }

    /// <summary>
    /// If OTHER is selected in TypeOfIdNumber, this field should be populated.
    /// </summary>
    public string? TypeOfIdNumberOther { get; set; }

    /// <summary>
    /// ID number.
    /// </summary>
    public string IdNumber { get; set; }
}