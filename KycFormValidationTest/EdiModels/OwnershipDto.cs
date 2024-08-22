using KycFormValidationTest.Models;

namespace KycFormValidationTest.EdiModels;

/// <summary>
/// Ownership of the company details.
/// </summary>
public class OwnershipDto
{
    /// <summary>
    /// Ownership type enum.
    /// </summary>
    public OwnershipTypeEnum OwnershipType { get; set; }

    /// <summary>
    /// Control type enum.
    /// </summary>
    public ControlTypeEnum? ControlType { get; set; }

    /// <summary>
    /// Ownership percentage.
    /// This should be populated when the ControlType is SHAREHOLDERS or RIGHT_TO_VOTE.
    /// </summary>
    public decimal? OwnershipPercentage { get; set; }
}