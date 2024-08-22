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


