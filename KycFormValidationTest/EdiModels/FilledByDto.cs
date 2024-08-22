namespace KycFormValidationTest.EdiModels;

/// <summary>
/// Information about the user which filled the form.
/// </summary>
public class FilledByDto
{
    /// <summary>
    /// This is to ensure that the information submitted is correct and complete.
    /// </summary>
    public bool ConfirmationOfCorrectData { get; set; }

    /// <summary>
    /// First name.
    /// </summary>
    public string FirstName { get; set; }

    /// <summary>
    /// Last name.
    /// </summary>
    public string LastName { get; set; }

    /// <summary>
    /// Work role.
    /// </summary>
    public string WorkRole { get; set; }

    /// <summary>
    /// Email.
    /// </summary>
    public string Email { get; set; }

    /// <summary>
    /// Telephone number.
    /// </summary>
    public string TelephoneNumber { get; set; }

    /// <summary>
    /// Represents the list of National Ids (SSN, Passport, Driving license etc.)
    /// </summary>
    public List<NationalIdDto> NationalIds { get; set; }
}