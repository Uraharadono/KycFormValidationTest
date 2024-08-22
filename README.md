# CORPORATE
## Valid Payloads
### Valid Payload 1
{
 "AboutCompany": {
 "CompanyName": "Tech Innovators Inc.",
 "CountryOfRegistration": "USA",
 "OrganizationNumber": "123456789",
 "CompanyForm": 1,
 "CompanyRevenues": [1, 2],
 "CompanyAddress": {
 "Street": "123 Innovation Drive",
 "Postcode": "94043",
 "City": "Mountain View",
 "Country": "USA"
 },
 "CompanyContact": {
 "Email": "contact@techinnovators.com",
 "TelephoneNumber": "+1234567890",
 "Role": 1
 }
 },
 "PurposeDto": {
 "PurposeOfBusinessRelationship": "Investment",
 "TransactionFrequency": 1,
 "MonthlyTransferAmount": 1
 },
 "FilledBy": {
 "ConfirmationOfCorrectData": true,
 "FirstName": "John",
 "LastName": "Doe",
 "WorkRole": "CEO",
 "Email": "john.doe@techinnovators.com",
 "TelephoneNumber": "+1234567890",
 "NationalIds": [
 {
 "Country": "USA",
 "TypeOfIdNumber": 1,
 "IdNumber": "987654321"
 }
 ]
 },
 "HasBeneficialOwner": false
}
### Valid Payload 2
{
 "AboutCompany": {
 "CompanyName": "Global Ventures Ltd.",
 "CountryOfRegistration": "UK",
 "OrganizationNumber": "987654321",
 "CompanyForm": 2,
 "CompanyRevenues": [2],
 "CompanyAddress": {
 "Street": "456 Enterprise Road",
 "Postcode": "EC1A 1BB",
 "City": "London",
 "Country": "UK"
 },
 "CompanyContact": {
 "Email": "info@globalventures.co.uk",
 "TelephoneNumber": "+441234567890",
 "Role": 2
 }
 },
 "PurposeDto": {
 "PurposeOfBusinessRelationship": "Partnership",
 "TransactionFrequency": 2,
 "MonthlyTransferAmount": 2
 },
 "FilledBy": {
 "ConfirmationOfCorrectData": true,
 "FirstName": "Jane",
 "LastName": "Smith",
 "WorkRole": "Board Member",
 "Email": "jane.smith@globalventures.co.uk",
 "TelephoneNumber": "+441234567890",
 "NationalIds": [
 {
 "Country": "UK",
 "TypeOfIdNumber": 2,
 "IdNumber": "123456789"
 }
 ]
 },
 "HasBeneficialOwner": true,
 "BeneficialOwners": [
 {
 "FirstName": "Alice",
 "LastName": "Johnson",
 "DateOfBirth": "1980-01-01",
 "Address": {
 "Street": "789 Wealth Street",
 "Postcode": "W1A 1AA",
 "City": "London",
 "Country": "UK"
 },
 "NationalIDs": [
 {
 "Country": "UK",
 "TypeOfIdNumber": 3,
 "IdNumber": "A1234567"
 }
 ],
 "Citizenships": [
 {
 "Country": "UK",
 "ConnectionToCountry": [1, 2]
 }
 ],
 "TaxResidency": ["UK"],
 "Ownership": {
 "OwnershipType": 1,
 "OwnershipPercentage": 50
 },
 "Pep": {
 "IsPEP": false
 }
 }
 ]
}
## Invalid Payloads
### Invalid Payload 1 (Missing Required Fields)
{
 "AboutCompany": {
 "CompanyName": "Tech Innovators Inc.",
 "CountryOfRegistration": "USA",
 "OrganizationNumber": "123456789",
 "CompanyForm": 1,
 "CompanyRevenues": [1, 2],
 "CompanyAddress": {
 "Street": "123 Innovation Drive",
 "Postcode": "94043",
 "City": "Mountain View",
 "Country": "USA"
 },
 "CompanyContact": {
 "Email": "contact@techinnovators.com",
 "TelephoneNumber": "+1234567890",
 "Role": 1
 }
 },
 "PurposeDto": {
 "PurposeOfBusinessRelationship": "Investment",
 "TransactionFrequency": 1,
 "MonthlyTransferAmount": 1
 },
 "FilledBy": {
 "ConfirmationOfCorrectData": true,
 "FirstName": "John",
 "LastName": "Doe",
 "WorkRole": "CEO",
 "Email": "john.doe@techinnovators.com",
 "TelephoneNumber": "+1234567890",
 "NationalIds": [
 {
 "Country": "USA",
 "TypeOfIdNumber": 1,
 "IdNumber": "987654321"
 }
 ]
 }
 // Missing HasBeneficialOwner field
}
### Invalid Payload 2 (Invalid Email Format) - not invalid actually
{
 "AboutCompany": {
 "CompanyName": "Global Ventures Ltd.",
 "CountryOfRegistration": "UK",
 "OrganizationNumber": "987654321",
 "CompanyForm": 2,
 "CompanyRevenues": [2],
 "CompanyAddress": {
 "Street": "456 Enterprise Road",
 "Postcode": "EC1A 1BB",
 "City": "London",
 "Country": "UK"
 },
 "CompanyContact": {
 "Email": "info@globalventures",
 "TelephoneNumber": "+441234567890",
 "Role": 2
 }
 },
 "PurposeDto": {
 "PurposeOfBusinessRelationship": "Partnership",
 "TransactionFrequency": 2,
 "MonthlyTransferAmount": 2
 },
 "FilledBy": {
 "ConfirmationOfCorrectData": true,
 "FirstName": "Jane",
 "LastName": "Smith",
 "WorkRole": "Board Member",
 "Email": "jane.smith@globalventures.co.uk",
 "TelephoneNumber": "+441234567890",
 "NationalIds": [
 {
 "Country": "UK",
 "TypeOfIdNumber": 2,
 "IdNumber": "123456789"
 }
 ]
 },
 "HasBeneficialOwner": true,
 "BeneficialOwners": [
 {
 "FirstName": "Alice",
 "LastName": "Johnson",
 "DateOfBirth": "1980-01-01",
 "Address": {
 "Street": "789 Wealth Street",
 "Postcode": "W1A 1AA",
 "City": "London",
 "Country": "UK"
 },
 "NationalIDs": [
 {
 "Country": "UK",
 "TypeOfIdNumber": 3,
 "IdNumber": "A1234567"
 }
 ],
 "Citizenships": [
 {
 "Country": "UK",
 "ConnectionToCountry": [1, 2]
 }
 ],
 "TaxResidency": ["UK"],
 "Ownership": {
 "OwnershipType": 1,
 "OwnershipPercentage": 50
 },
 "Pep": {
 "IsPEP": false
 }
 }
 ]
}


_____


# INDIVIDUAL
## Valid Payloads
### Valid Payload 1
{
  "PrivateUserInfo": {
    "Firstname": "John",
    "Lastname": "Doe",
    "Address": {
      "Street": "123 Main St",
      "Postcode": "12345",
      "City": "Anytown",
      "Country": "USA"
    },
    "TaxResidency": ["USA"],
    "Citizenships": [
      {
        "Country": "USA",
        "ConnectionToCountry": [1, 2]
      }
    ],
    "PepInfo": {
      "IsPEP": false
    }
  },
  "UserEconomy": {
    "Employment": 1,
    "Salary": 50000,
    "Currency": "USD",
    "MainFundSources": [1, 2]
  },
  "PurposeAndTransactions": {
    "BusinessPurposes": [1, 2],
    "TransactionFrequency": 2,
    "MonthlyTransferAmount": 2
  }
}


### Valid Payload 2
{
  "PrivateUserInfo": {
    "Firstname": "Jane",
    "Lastname": "Smith",
    "Address": {
      "Street": "456 Elm St",
      "Postcode": "67890",
      "City": "Othertown",
      "Country": "Canada"
    },
    "TaxResidency": ["Canada"],
    "Citizenships": [
      {
        "Country": "Canada",
        "ConnectionToCountry": [3, 4]
      }
    ],
    "PepInfo": {
      "IsPEP": true,
      "RelationshipToPep": 1,
      "Position": 2,
      "Country": "Canada"
    }
  },
  "UserEconomy": {
    "Employment": 2,
    "Salary": 30000,
    "Currency": "CAD",
    "MainFundSources": [3, 4]
  },
  "PurposeAndTransactions": {
    "BusinessPurposes": [3, 4],
    "TransactionFrequency": 3,
    "MonthlyTransferAmount": 3
  }
}

## Invalid Payloads
### Invalid Payload 1 (Missing required fields)
{
  "PrivateUserInfo": {
    "Firstname": "Alice",
    "Lastname": "Johnson",
    "Address": {
      "Street": "789 Oak St",
      "Postcode": "54321",
      "City": "Sometown",
      "Country": "UK"
    },
    "TaxResidency": ["UK"],
    "Citizenships": [
      {
        "Country": "UK",
        "ConnectionToCountry": [5]
      }
    ],
    "PepInfo": {
      "IsPEP": false
    }
  },
  "UserEconomy": {
    "Employment": 3,
    "Salary": 20000,
    "Currency": "GBP",
    "MainFundSources": [5]
  },
  "PurposeAndTransactions": {
    "BusinessPurposes": [5],
    "TransactionFrequency": 4
    // Missing MonthlyTransferAmount
  }
}

### Invalid Payload 2 (Invalid data type)

{
  "PrivateUserInfo": {
    "Firstname": "Bob",
    "Lastname": "Brown",
    "Address": {
      "Street": "321 Pine St",
      "Postcode": "98765",
      "City": "Anycity",
      "Country": "Australia"
    },
    "TaxResidency": ["Australia"],
    "Citizenships": [
      {
        "Country": "Australia",
        "ConnectionToCountry": [1, 2]
      }
    ],
    "PepInfo": {
      "IsPEP": true,
      "RelationshipToPep": 2,
      "Position": 3,
      "Country": "Australia"
    }
  },
  "UserEconomy": {
    "Employment": 4,
    "Salary": "invalid_salary", // Invalid data type
    "Currency": "AUD",
    "MainFundSources": [1, 2]
  },
  "PurposeAndTransactions": {
    "BusinessPurposes": [6, 7],
    "TransactionFrequency": 5,
    "MonthlyTransferAmount": 4
  }
}



