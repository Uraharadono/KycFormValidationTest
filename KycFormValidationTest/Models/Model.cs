using KycFormValidationTest.EdiModels;
using System.ComponentModel.DataAnnotations;

namespace KycFormValidationTest.Models
{
    public class CorporateFormViewModel
    {
        [Required]
        public AboutCompanyViewModel AboutCompany { get; set; }

        [Required]
        public PurposeViewModel Purpose { get; set; }

        [Required]
        public FilledByViewModel FilledBy { get; set; }

        public bool HasBeneficialOwner { get; set; }

        public List<BeneficialOwnerViewModel>? BeneficialOwners { get; set; }

        public static explicit operator SaveCorporateFormRequest(CorporateFormViewModel viewModel)
        {
            return new SaveCorporateFormRequest
            {
                AboutCompany = (AboutCompanyDto)viewModel.AboutCompany,
                PurposeDto = (PurposeDto)viewModel.Purpose,
                FilledBy = (FilledByDto)viewModel.FilledBy,
                HasBeneficialOwner = viewModel.HasBeneficialOwner,
                BeneficialOwners = viewModel.BeneficialOwners?.Select(bo => (BeneficialOwnerDto)bo).ToList()
            };
        }
    }

    public class AboutCompanyViewModel
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
        public AddressViewModel CompanyAddress { get; set; }

        [Required]
        public ContactViewModel CompanyContact { get; set; }

        public static explicit operator AboutCompanyDto(AboutCompanyViewModel viewModel)
        {
            return new AboutCompanyDto
            {
                CompanyName = viewModel.CompanyName,
                CountryOfRegistration = viewModel.CountryOfRegistration,
                OrganizationNumber = viewModel.OrganizationNumber,
                CompanyForm = viewModel.CompanyForm,
                CompanyFormOther = viewModel.CompanyFormOther,
                CompanyRevenues = viewModel.CompanyRevenues,
                CompanyRevenueOther = viewModel.CompanyRevenueOther,
                CompanyAddress = (AddressDto)viewModel.CompanyAddress,
                CompanyContact = (ContactDto)viewModel.CompanyContact
            };
        }
    }

    public class AddressViewModel
    {
        [Required]
        public string Street { get; set; }

        [Required]
        public string Postcode { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string Country { get; set; }

        public static explicit operator AddressDto(AddressViewModel viewModel)
        {
            return new AddressDto
            {
                Street = viewModel.Street,
                Postcode = viewModel.Postcode,
                City = viewModel.City,
                Country = viewModel.Country
            };
        }
    }

    public class ContactViewModel
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

        public static explicit operator ContactDto(ContactViewModel viewModel)
        {
            return new ContactDto
            {
                Email = viewModel.Email,
                TelephoneNumber = viewModel.TelephoneNumber,
                Role = viewModel.Role,
                RoleOther = viewModel.RoleOther,
                Homepage = viewModel.Homepage
            };
        }
    }

    public class PurposeViewModel
    {
        [Required]
        public string PurposeOfBusinessRelationship { get; set; }

        [Required]
        public CorporateTransactionFrequencyEnum TransactionFrequency { get; set; }

        public decimal? TransactionFrequencyOther { get; set; }

        [Required]
        public CorporateMonthlyTransferAmountEnum MonthlyTransferAmount { get; set; }

        public decimal? MonthlyTransferAmountOther { get; set; }

        public static explicit operator PurposeDto(PurposeViewModel viewModel)
        {
            return new PurposeDto
            {
                PurposeOfBusinessRelationship = viewModel.PurposeOfBusinessRelationship,
                TransactionFrequency = viewModel.TransactionFrequency,
                TransactionFrequencyOther = viewModel.TransactionFrequencyOther,
                MonthlyTransferAmount = viewModel.MonthlyTransferAmount,
                MonthlyTransferAmountOther = viewModel.MonthlyTransferAmountOther
            };
        }
    }

    public class FilledByViewModel
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
        public List<NationalIdViewModel> NationalIds { get; set; }

        public static explicit operator FilledByDto(FilledByViewModel viewModel)
        {
            return new FilledByDto
            {
                ConfirmationOfCorrectData = viewModel.ConfirmationOfCorrectData,
                FirstName = viewModel.FirstName,
                LastName = viewModel.LastName,
                WorkRole = viewModel.WorkRole,
                Email = viewModel.Email,
                TelephoneNumber = viewModel.TelephoneNumber,
                NationalIds = viewModel.NationalIds.Select(nid => (NationalIdDto)nid).ToList()
            };
        }
    }

    public class NationalIdViewModel
    {
        [Required]
        public string Country { get; set; }

        [Required]
        public TypeOfIdNumberEnum TypeOfIdNumber { get; set; }

        public string? TypeOfIdNumberOther { get; set; }

        [Required]
        public string IdNumber { get; set; }

        public static explicit operator NationalIdDto(NationalIdViewModel viewModel)
        {
            return new NationalIdDto
            {
                Country = viewModel.Country,
                TypeOfIdNumber = viewModel.TypeOfIdNumber,
                TypeOfIdNumberOther = viewModel.TypeOfIdNumberOther,
                IdNumber = viewModel.IdNumber
            };
        }
    }

    public class BeneficialOwnerViewModel
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
        public AddressViewModel Address { get; set; }

        [Required]
        public List<NationalIdViewModel> NationalIDs { get; set; }

        [Required]
        public List<CitizenshipViewModel> Citizenships { get; set; }

        [Required]
        public List<string> TaxResidency { get; set; }

        [Required]
        public OwnershipViewModel Ownership { get; set; }

        public bool IsJointlyOwned { get; set; }

        [Required]
        public PepViewModel Pep { get; set; }

        public static explicit operator BeneficialOwnerDto(BeneficialOwnerViewModel viewModel)
        {
            return new BeneficialOwnerDto
            {
                FirstName = viewModel.FirstName,
                LastName = viewModel.LastName,
                DateOfBirth = viewModel.DateOfBirth,
                Role = viewModel.Role,
                RoleOther = viewModel.RoleOther,
                Address = (AddressDto)viewModel.Address,
                NationalIDs = viewModel.NationalIDs.Select(nid => (NationalIdDto)nid).ToList(),
                Citizenships = viewModel.Citizenships.Select(c => (CitizenshipDto)c).ToList(),
                TaxResidency = viewModel.TaxResidency,
                Ownership = (OwnershipDto)viewModel.Ownership,
                IsJointlyOwned = viewModel.IsJointlyOwned,
                Pep = (PepDto)viewModel.Pep
            };
        }
    }

    public class CitizenshipViewModel
    {
        [Required]
        public string Country { get; set; }

        [Required]
        public List<ConnectionToCountryEnum> ConnectionToCountry { get; set; }

        public static explicit operator CitizenshipDto(CitizenshipViewModel viewModel)
        {
            return new CitizenshipDto
            {
                Country = viewModel.Country,
                ConnectionToCountry = viewModel.ConnectionToCountry
            };
        }
    }

    public class OwnershipViewModel
    {
        [Required]
        public OwnershipTypeEnum OwnershipType { get; set; }

        public ControlTypeEnum? ControlType { get; set; }

        public decimal? OwnershipPercentage { get; set; }

        public static explicit operator OwnershipDto(OwnershipViewModel viewModel)
        {
            return new OwnershipDto
            {
                OwnershipType = viewModel.OwnershipType,
                ControlType = viewModel.ControlType,
                OwnershipPercentage = viewModel.OwnershipPercentage
            };
        }
    }

    public class PepViewModel
    {
        [Required]
        public bool IsPEP { get; set; }

        public RelationshipToPepTypeEnum? RelationshipToPep { get; set; }

        public PepPositionEnum? Position { get; set; }

        public string? Country { get; set; }

        public static explicit operator PepDto(PepViewModel viewModel)
        {
            return new PepDto
            {
                IsPEP = viewModel.IsPEP,
                RelationshipToPep = viewModel.RelationshipToPep,
                Position = viewModel.Position,
                Country = viewModel.Country
            };
        }
    }


    // ===========================
    // Private form stuff
    // ===========================


    public class PrivateFormViewModel
    {
        [Required]
        public PrivateUserInfoViewModel PrivateUserInfo { get; set; }

        [Required]
        public UserEconomyViewModel UserEconomy { get; set; }

        [Required]
        public PurposeAndTransactionsViewModel PurposeAndTransactions { get; set; }

        public static explicit operator SavePrivateFormRequest(PrivateFormViewModel viewModel)
        {
            return new SavePrivateFormRequest
            {
                PrivateUserInfo = (PrivateUserInfoDto)viewModel.PrivateUserInfo,
                UserEconomy = (UserEconomyDto)viewModel.UserEconomy,
                PurposeAndTransactions = (PurposeAndTransactionsDto)viewModel.PurposeAndTransactions
            };
        }
    }

    public class PrivateUserInfoViewModel
    {
        [Required]
        public string Firstname { get; set; }

        [Required]
        public string Lastname { get; set; }

        [Required]
        public AddressViewModel Address { get; set; }

        [Required]
        public List<string> TaxResidency { get; set; }

        [Required]
        public List<CitizenshipViewModel> Citizenships { get; set; }

        public PepViewModel PepInfo { get; set; }

        public static explicit operator PrivateUserInfoDto(PrivateUserInfoViewModel viewModel)
        {
            return new PrivateUserInfoDto
            {
                Firstname = viewModel.Firstname,
                Lastname = viewModel.Lastname,
                Address = (AddressDto)viewModel.Address,
                TaxResidency = viewModel.TaxResidency,
                Citizenships = viewModel.Citizenships.Select(c => (CitizenshipDto)c).ToList(),
                PepInfo = viewModel.PepInfo != null ? (PepDto)viewModel.PepInfo : null
            };
        }
    }

    public class UserEconomyViewModel
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

        public static explicit operator UserEconomyDto(UserEconomyViewModel viewModel)
        {
            return new UserEconomyDto
            {
                Employment = viewModel.Employment,
                Salary = viewModel.Salary,
                Currency = viewModel.Currency,
                MainFundSources = viewModel.MainFundSources,
                FundSourceOther = viewModel.FundSourceOther
            };
        }
    }

    public class PurposeAndTransactionsViewModel
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

        public static explicit operator PurposeAndTransactionsDto(PurposeAndTransactionsViewModel viewModel)
        {
            return new PurposeAndTransactionsDto
            {
                BusinessPurposes = viewModel.BusinessPurposes,
                BusinessPurposeOther = viewModel.BusinessPurposeOther,
                TransactionFrequency = viewModel.TransactionFrequency,
                TransactionFrequencyOther = viewModel.TransactionFrequencyOther,
                MonthlyTransferAmount = viewModel.MonthlyTransferAmount,
                MonthlyTransferAmountOther = viewModel.MonthlyTransferAmountOther
            };
        }
    }
}
