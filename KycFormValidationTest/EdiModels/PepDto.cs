using KycFormValidationTest.Models;

namespace KycFormValidationTest.EdiModels;

/// <summary>
/// Politically exposed person information.
/// </summary>
public class PepDto
{
    /// <summary>
    /// Is politically exposed person.
    /// </summary>
    public bool IsPEP { get; set; }

    /// <summary>
    /// Relationship to pep.
    /// </summary>
    public RelationshipToPepTypeEnum? RelationshipToPep { get; set; }

    /// <summary>
    /// Position enum.
    /// </summary>
    public PepPositionEnum? Position { get; set; }

    /// <summary>
    /// Country.
    /// </summary>
    public string? Country { get; set; }
}