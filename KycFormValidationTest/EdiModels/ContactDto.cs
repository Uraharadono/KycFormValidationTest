using KycFormValidationTest.Models;

namespace KycFormValidationTest.EdiModels;

/// <summary>
/// Contact information.
/// </summary>
public class ContactDto
{
    /// <summary>
    /// Email.
    /// </summary>
    public string Email { get; set; }

    /// <summary>
    /// Telephone.
    /// </summary>
    public string TelephoneNumber { get; set; }

    /// <summary>
    /// Role enum.
    /// </summary>
    public RolesEnum Role { get; set; }

    /// <summary>
    /// If OTHER is selected on Role, this field should be populated.
    /// </summary>
    public string? RoleOther { get; set; }

    /// <summary>
    /// Home page.
    /// </summary>
    public string? Homepage { get; set; }
}