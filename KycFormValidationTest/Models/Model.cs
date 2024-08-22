using System.ComponentModel.DataAnnotations;

namespace KycFormValidationTest.Models
{
    public class SaveCorporateFormRequest
    {
        [Required]
        public AboutCompanyDto AboutCompany { get; set; }

        [Required]
        public PurposeDto PurposeDto { get; set; }

        [Required]
        public FilledByDto FilledBy { get; set; }

        public bool HasBeneficialOwner { get; set; }

        public List<BeneficialOwnerDto>? BeneficialOwners { get; set; }
    }

    public class AboutCompanyDto
    {
        [Required]
        public string CompanyName { get; set; }

        [Required]
        public string CountryOfRegistration { get; set; }

        [Required]
        public string OrganizationNumber { get; set; }

        [Required]
        [EnumDataType(typeof(CompanyFormEnum))]
        public CompanyFormEnum CompanyForm { get; set; }

        public string? CompanyFormOther { get; set; }

        [Required]
        public List<CompanyRevenueEnum> CompanyRevenues { get; set; }

        public string? CompanyRevenueOther { get; set; }

        [Required]
        public AddressDto CompanyAddress { get; set; }

        [Required]
        public ContactDto CompanyContact { get; set; }
    }

    public class AddressDto
    {
        [Required]
        public string Street { get; set; }

        [Required]
        public string Postcode { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string Country { get; set; }
    }

    public class ContactDto
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Phone]
        public string TelephoneNumber { get; set; }

        [Required]
        public RolesEnum Role { get; set; }

        public string? RoleOther { get; set; }

        public string? Homepage { get; set; }
    }

    public class PurposeDto
    {
        [Required]
        public string PurposeOfBusinessRelationship { get; set; }

        [Required]
        public CorporateTransactionFrequencyEnum TransactionFrequency { get; set; }

        public decimal? TransactionFrequencyOther { get; set; }

        [Required]
        public CorporateMonthlyTransferAmountEnum MonthlyTransferAmount { get; set; }

        public decimal? MonthlyTransferAmountOther { get; set; }
    }

    public class FilledByDto
    {
        [Required]
        public bool ConfirmationOfCorrectData { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string WorkRole { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Phone]
        public string TelephoneNumber { get; set; }

        [Required]
        public List<NationalIdDto> NationalIds { get; set; }
    }

    public class NationalIdDto
    {
        [Required]
        public string Country { get; set; }

        [Required]
        public TypeOfIdNumberEnum TypeOfIdNumber { get; set; }

        public string? TypeOfIdNumberOther { get; set; }

        [Required]
        public string IdNumber { get; set; }
    }

    public class BeneficialOwnerDto
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        public RolesEnum? Role { get; set; }

        public string? RoleOther { get; set; }

        [Required]
        public AddressDto Address { get; set; }

        [Required]
        public List<NationalIdDto> NationalIDs { get; set; }

        [Required]
        public List<CitizenshipDto> Citizenships { get; set; }

        [Required]
        public List<string> TaxResidency { get; set; }

        [Required]
        public OwnershipDto Ownership { get; set; }

        public bool IsJointlyOwned { get; set; }

        [Required]
        public PepDto Pep { get; set; }
    }

    public class CitizenshipDto
    {
        [Required]
        public string Country { get; set; }

        [Required]
        public List<ConnectionToCountryEnum> ConnectionToCountry { get; set; }
    }

    public class OwnershipDto
    {
        [Required]
        public OwnershipTypeEnum OwnershipType { get; set; }

        public ControlTypeEnum? ControlType { get; set; }

        public decimal? OwnershipPercentage { get; set; }
    }

    public class PepDto
    {
        [Required]
        public bool IsPEP { get; set; }

        public RelationshipToPepTypeEnum? RelationshipToPep { get; set; }

        public PepPositionEnum? Position { get; set; }

        public string? Country { get; set; }
    }


    // ===========================
    // Private form stuff
    // ===========================


    public class SavePrivateFormRequest
    {
        [Required]
        public PrivateUserInfoDto PrivateUserInfo { get; set; }

        [Required]
        public UserEconomyDto UserEconomy { get; set; }

        [Required]
        public PurposeAndTransactionsDto PurposeAndTransactions { get; set; }
    }

    public class PrivateUserInfoDto
    {
        [Required]
        public string Firstname { get; set; }

        [Required]
        public string Lastname { get; set; }

        [Required]
        public AddressDto Address { get; set; }

        [Required]
        public List<string> TaxResidency { get; set; }

        [Required]
        public List<CitizenshipDto> Citizenships { get; set; }

        public PepDto PepInfo { get; set; }
    }

    public class UserEconomyDto
    {
        [Required]
        public EmploymentStatusEnum Employment { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Salary must be a positive number.")]
        public decimal Salary { get; set; }

        [Required]
        public string Currency { get; set; }

        [Required]
        public List<MainSourceFundsEnum> MainFundSources { get; set; }

        public string? FundSourceOther { get; set; }
    }

    public class PurposeAndTransactionsDto
    {
        [Required]
        public List<BusinessPurposeEnum> BusinessPurposes { get; set; }

        public string? BusinessPurposeOther { get; set; }

        [Required]
        public PrivateTransactionFrequencyEnum TransactionFrequency { get; set; }

        public int? TransactionFrequencyOther { get; set; }

        [Required]
        public PrivateMonthlyTransferAmountEnum MonthlyTransferAmount { get; set; }

        public decimal? MonthlyTransferAmountOther { get; set; }
    }
}
