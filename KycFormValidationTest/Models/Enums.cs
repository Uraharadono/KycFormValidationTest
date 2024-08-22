namespace KycFormValidationTest.Models
{
    public enum CompanyFormEnum
    {
        /// <summary>
        /// Limited company.
        /// </summary>
        LIMITED_COMPANY = 1,

        /// <summary>
        /// Economic association.
        /// </summary>
        ECONOMIC_ASSOCIATION = 2,

        /// <summary>
        /// Individual company.
        /// </summary>
        INDIVIDUAL_COMPANY = 3,

        /// <summary>
        /// Trading company.
        /// </summary>
        TRADING_COMPANY = 4,

        /// <summary>
        /// Ideal association.
        /// </summary>
        NON_PROFIT_ASSOCIATION = 5,

        /// <summary>
        /// Limited partnership.
        /// </summary>
        LIMITED_PARTNERSHIP = 6,

        /// <summary>
        /// Foundation.
        /// </summary>
        FOUNDATION = 7,

        /// <summary>
        /// Other.
        /// </summary>
        OTHER = 99
    }

    public enum CompanyRevenueEnum
    {
        /// <summary>
        /// The company is a holding company.
        /// </summary>
        HOLDING_COMPANY = 1,

        /// <summary>
        /// Income from the company's business activities.
        /// </summary>
        INCOME_FROM_BUSINESS_ACTIVITIES = 2,

        /// <summary>
        /// Other.
        /// </summary>
        OTHER = 99
    }

    public enum RolesEnum
    {
        /// <summary>
        /// CEO.
        /// </summary>
        CEO = 1,

        /// <summary>
        /// Board member.
        /// </summary>
        BOARD_MEMBER = 2,

        /// <summary>
        /// Other.
        /// </summary>
        OTHER = 99
    }

    public enum CorporateTransactionFrequencyEnum
    {
        /// <summary>
        /// During 5 times/month.
        /// </summary>
        FiveTimesPerMonth = 1,

        /// <summary>
        /// 5-10 times/month.
        /// </summary>
        FIVE_TO_TEN = 2,

        /// <summary>
        /// 10-15  times/month.
        /// </summary>
        TEN_TO_FIFTEEN = 3,

        /// <summary>
        /// 15-20  times/month
        /// </summary>
        FIFTEEN_TO_TWENTY = 4,

        /// <summary>
        /// More than 20 times/month
        /// This options works as OTHER.
        /// </summary>
        MORE_THAN_TWENTY = 99
    }

    public enum CorporateMonthlyTransferAmountEnum
    {
        /// <summary>
        /// Under SEK 10,000/month.
        /// </summary>
        UNDER_10000 = 1,

        /// <summary>
        /// 10,000 - 100,000 SEK/month.
        /// </summary>
        BETWEEN_10000_AND_100000 = 2,

        /// <summary>
        /// 100,000 - 250,000  SEK/month.
        /// </summary>
        BETWEEN_100000_AND_250000 = 3,

        /// <summary>
        /// 250,000 - 500,000  SEK/month.
        /// </summary>
        BETWEEN_250000_AND_500000 = 4,

        /// <summary>
        /// 500,000 - 1,000,000  SEK/month.
        /// </summary>
        BETWEEN_500000_AND_1000000 = 5,

        /// <summary>
        /// 1,000,000 - 3,000,000  SEK/month.
        /// </summary>
        BETWEEN_1000000_AND_3000000 = 6,

        /// <summary>
        /// 3,000,000 - 5,000,000  SEK/month.
        /// </summary>
        BETWEEN_3000000_AND_5000000 = 7,

        /// <summary>
        /// More than SEK 5,000,000/month.
        /// This works as the OTHER option.
        /// </summary>
        MORE_THAN_5000000 = 99
    }

    public enum TypeOfIdNumberEnum
    {
        /// <summary>
        /// Social security number.
        /// </summary>
        SOCIAL_SECURITY_NUMBER = 1,

        /// <summary>
        /// National insurance number.
        /// </summary>
        NATIONAL_INSURANCE_NUMBER = 2,

        /// <summary>
        /// National ID.
        /// </summary>
        NATIONAL_ID = 3,

        /// <summary>
        /// Passport number.
        /// </summary>
        PASSPORT_NUMBER = 4,

        /// <summary>
        /// Driving license number.
        /// </summary>
        DRIVING_LICENSE_NUMBER = 5,

        /// <summary>
        /// Other.
        /// </summary>
        OTHER = 99
    }

    public enum ConnectionToCountryEnum
    {
        /// <summary>
        /// No residence
        /// </summary>
        NO_RESIDENCE = 1,

        /// <summary>
        /// Stay in country more than 180 days
        /// </summary>
        STAY_MORE_THAN_180_DAYS = 2,

        /// <summary>
        /// Investment activities
        /// </summary>
        INVESTMENT_ACTIVITIES = 3,

        /// <summary>
        /// Registered national population
        /// </summary>
        REGISTERED_NATIONAL_POPULATION = 4,

        /// <summary>
        /// Send money to country
        /// </summary>
        SEND_MONEY_TO_COUNTRY = 5
    }

    public enum OwnershipTypeEnum
    {
        /// <summary>
        /// Direct
        /// </summary>
        DIRECT = 1,

        /// <summary>
        /// Indirect
        /// </summary>
        INDIRECT = 2
    }

    public enum ControlTypeEnum
    {
        /// <summary>
        /// Shareholder or shareholders.
        /// </summary>
        SHAREHOLDER = 1,

        /// <summary>
        /// Right to vote.
        /// </summary>
        RIGHT_TO_VOTE = 2,

        /// <summary>
        /// Agreement, articles of association, similar or membership.
        /// </summary>
        AGREEMENT_ARTICLES_OR_MEMBERSHIP = 3,

        /// <summary>
        /// Right to appoint and dismiss more than half of the board members, etc.
        /// </summary>
        RIGHT_TO_APPOINT_OR_DISMISS_BOARD_MEMBERS = 4,

        /// <summary>
        /// Trustee in foundation or trust.
        /// </summary>
        TRUSTEE_IN_FOUNDATION_OR_TRUST = 5,

        /// <summary>
        /// Board member in foundation.
        /// </summary>
        BOARD_MEMBER_IN_FOUNDATION = 6,

        /// <summary>
        /// Beneficiary in foundation or trust.
        /// </summary>
        BENEFICIARY_IN_FOUNDATION_OR_TRUST = 7,

        /// <summary>
        /// Settlor in trust.
        /// </summary>
        SETTLOR_IN_TRUST = 8,

        /// <summary>
        /// Control through other companies.
        /// </summary>
        CONTROL_THROUGH_OTHER_COMPANIES = 9,

        /// <summary>
        /// Other.
        /// </summary>
        OTHER = 99
    }

    public enum RelationshipToPepTypeEnum
    {
        /// <summary>
        /// The person is a PEP.
        /// </summary>
        PEP = 1,

        /// <summary>
        /// Spouse.
        /// </summary>
        SPOUSE = 2,

        /// <summary>
        /// Registered Partner.
        /// </summary>
        REGISTERED_PARTNER = 3,

        /// <summary>
        /// Cohabitant.
        /// </summary>
        COHABITANT = 4,

        /// <summary>
        /// Child.
        /// </summary>
        CHILD = 5,

        /// <summary>
        /// Child's spouse or partner.
        /// </summary>
        CHILD_SPOUSE_OR_PARTNER = 6,

        /// <summary>
        /// Parent.
        /// </summary>
        PARENT = 7,

        /// <summary>
        /// Known associate.
        /// </summary>
        KNOWN_ASSOCIATE = 8
    }

    public enum PepPositionEnum
    {
        /// <summary>
        /// Head of state or government, minister, deputy or assistant minister.
        /// </summary>
        HEAD_OF_STATE = 1,

        /// <summary>
        /// Member of Parliament or member of similar legislative body.
        /// </summary>
        MEMBER_OF_PARLIAMENT = 2,

        /// <summary>
        /// Member of the board for political parties.
        /// </summary>
        MEMBER_OF_BOARD = 3,

        /// <summary>
        /// Judges of the Supreme Court, Constitutional Court or other high-level judicial bodies whose decisions are only exceptionally appealable.
        /// </summary>
        JUDGES_SUPREME_COURT = 4,

        /// <summary>
        /// Senior official at audit authorities or member of the central bank's governing body.
        /// </summary>
        SENIOR_OFFICIAL = 5,

        /// <summary>
        /// Ambassador, head of mission or senior officer in the armed forces.
        /// </summary>
        AMBASSADOR = 6,

        /// <summary>
        /// Person who is part of the administrative, management or control bodies of state-owned companies.
        /// </summary>
        PART_OF_ADMINISTRATION = 7
    }

    // ===========================
    // Private form stuff
    // ===========================

    public enum EmploymentStatusEnum
    {
        /// <summary>
        /// Full time.
        /// </summary>
        FULL_TIME = 1,

        /// <summary>
        /// Part time.
        /// </summary>
        PART_TIME = 2,

        /// <summary>
        /// Student.
        /// </summary>
        STUDENT = 3,

        /// <summary>
        /// Unemployed.
        /// </summary>
        UNEMPLOYED = 4,

        /// <summary>
        /// Retired.
        /// </summary>
        RETIRED = 5
    }

    public enum MainSourceFundsEnum
    {
        /// <summary>
        /// Salary/pension.
        /// </summary>
        SALARY = 1,

        /// <summary>
        /// Return from investments.
        /// </summary>
        RETURN_FROM_INVESTMENTS = 2,

        /// <summary>
        /// Inheritance or gift.
        /// </summary>
        INHERITANCE = 3,

        /// <summary>
        /// Online gambling.
        /// </summary>
        ONLINE_GAMBLING = 4,

        /// <summary>
        /// Crypto trading.
        /// </summary>
        CRYPTO = 5,

        /// <summary>
        /// Other.
        /// </summary>
        OTHER = 99
    }

    public enum BusinessPurposeEnum
    {
        /// <summary>
        /// To make money transfers.
        /// </summary>
        MONEY_TRANSFERS = 1,

        /// <summary>
        /// Shop online.
        /// </summary>
        SHOP_ONLINE = 2,

        /// <summary>
        /// Play at online casino.
        /// </summary>
        ONLINE_CASINO = 3,

        /// <summary>
        /// Investments in crypto or other assets.
        /// </summary>
        INVESTMENTS_IN_CRYPTO_OR_OTHER_ASSETS = 4,

        /// <summary>
        /// Credit services.
        /// </summary>
        CREDIT_SERVICES = 5,

        /// <summary>
        /// Insurance.
        /// </summary>
        INSURANCE = 6,

        /// <summary>
        /// Wealth management.
        /// </summary>
        WEALTH_MANAGEMENT = 7,

        /// <summary>
        /// Savings accounts.
        /// </summary>
        SAVINGS_ACCOUNTS = 8,

        /// <summary>
        /// Business financing.
        /// </summary>
        BUSINESS_FINANCING = 9,

        /// <summary>
        /// Personal loans.
        /// </summary>
        PERSONAL_LOANS = 10,

        /// <summary>
        /// Pension savings.
        /// </summary>
        PENSION_SAVINGS = 11,

        /// <summary>
        /// International transfers.
        /// </summary>
        INTERNATIONAL_TRANSFERS = 12,

        /// <summary>
        /// Currency exchange.
        /// </summary>
        CURRENCY_EXCHANGE = 13,

        /// <summary>
        /// Other.
        /// </summary>
        OTHER = 99
    }

    public enum PrivateTransactionFrequencyEnum
    {
        /// <summary>
        /// Under 2 times/month.
        /// </summary>
        UNDER_2 = 1,

        /// <summary>
        /// 2-4 times/month.
        /// </summary>
        TWO_TO_FOUR = 2,

        /// <summary>
        /// 4-6 times/month.
        /// </summary>
        FOUR_TO_SIX = 3,

        /// <summary>
        /// 6-8 times/month.
        /// </summary>
        SIX_TO_EIGHT = 4,

        /// <summary>
        /// 8-12 times/month.
        /// </summary>
        EIGHT_TO_TWELVE = 5,

        /// <summary>
        /// Over 12 times/month.
        /// </summary>
        OVER_TWELVE = 6
    }

    public enum PrivateMonthlyTransferAmountEnum
    {
        /// <summary>
        /// Under 100 EUR/month.
        /// </summary>
        Under_100_EUR = 1,

        /// <summary>
        /// 100 - 1 000 EUR/month.
        /// </summary>
        BEETWEN_100_AND_1000_EUR = 2,

        /// <summary>
        /// 1 000 - 2 500 EUR/month.
        /// </summary>
        BEETWEN_1000_AND_2500_EUR = 3,

        /// <summary>
        /// 2 500 - 5 000 EUR/month.
        /// </summary>
        BEETWEN_2500_AND_5000_EUR = 4,

        /// <summary>
        /// 5 000 - 10 000 EUR/month.
        /// </summary>
        BEETWEN_5000_AND_10000_EUR = 5,

        /// <summary>
        /// Over 10 000 EUR/month.
        /// </summary>
        OVER_10000_EUR = 6,

        /// <summary>
        /// Under 1 000 SEK/month.
        /// </summary>
        Under_1000_SEK = 11,

        /// <summary>
        /// 1 000 - 10 000 SEK/month.
        /// </summary>
        BEETWEN_1000_AND_10000_SEK = 12,

        /// <summary>
        /// 10 000 - 25 000 SEK/month.
        /// </summary>
        BEETWEN_10000_AND_25000_SEK = 13,

        /// <summary>
        /// 25 000 - 50 000 SEK/month.
        /// </summary>
        BEETWEN_25000_AND_50000_SEK = 14,

        /// <summary>
        /// 50 000 - 100 000 SEK/month.
        /// </summary>
        BEETWEN_50000_AND_100000_SEK = 15,

        /// <summary>
        /// Over 100 000 SEK/month
        /// </summary>
        OVER_100000_SEK = 16
    }
}
