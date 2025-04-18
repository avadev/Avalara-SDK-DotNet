# Avalara.SDK.Model.A1099.V2.W8BeneFormDataModel
W-8 BEN-E form

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Type of the form, always W8BENE for this model. | [optional] [readonly] 
**SignedDate** | **DateTime?** | The date the form was signed. | [optional] 
**DisregardedEntityChapter4FatcaStatus** | **string** | The FATCA status for disregarded entities under Chapter 4. | [optional] 
**CreatedAt** | **DateTime?** | The creation date of the form. | [optional] 
**Name** | **string** | The name of the individual or entity associated with the form. | [optional] 
**ResidenceAddress** | **string** | The residential address of the individual or entity. | [optional] 
**ResidenceCity** | **string** | The city of residence. | [optional] 
**ResidenceState** | **string** | The state of residence. | [optional] 
**ResidencePostalCode** | **string** | The postal code of the residence. | [optional] 
**ResidenceCountry** | **string** | The country of residence. | [optional] 
**MailingAddress** | **string** | The mailing address. | [optional] 
**MailingCity** | **string** | The city of the mailing address. | [optional] 
**MailingState** | **string** | The state of the mailing address. | [optional] 
**MailingPostalCode** | **string** | The postal code of the mailing address. | [optional] 
**MailingCountry** | **string** | The country of the mailing address. | [optional] 
**DisregardedAddress** | **string** | The address for disregarded entities. | [optional] 
**DisregardedCity** | **string** | The city for disregarded entities. | [optional] 
**DisregardedState** | **string** | The state for disregarded entities. | [optional] 
**DisregardedPostalCode** | **string** | The postal code for disregarded entities. | [optional] 
**DisregardedCountry** | **string** | The country for disregarded entities. | [optional] 
**Tin** | **string** | The taxpayer identification number (TIN). | [optional] 
**TypeOfTin** | **string** | The type of TIN provided. | [optional] 
**ForeignTin** | **string** | The foreign taxpayer identification number (TIN). | [optional] 
**FtinNotRequired** | **bool?** | Indicates whether a foreign TIN is not required. | [optional] 
**ReferenceNumber** | **string** | A reference number for the form. | [optional] 
**Giin** | **string** | The global intermediary identification number (GIIN). | [optional] 
**Chapter3EntityType** | **string** | The Chapter 3 entity type. | [optional] 
**Chapter4FatcaStatus** | **string** | The Chapter 4 FATCA status. | [optional] 
**DisregardedEntity** | **string** | The disregarded entity information. | [optional] 
**DisregardedEntityGiin** | **string** | The GIIN for disregarded entities. | [optional] 
**BenefitLimitation** | **string** | The benefit limitation for tax treaty claims. | [optional] 
**Part4SponsoringEntity** | **string** | The sponsoring entity information for Part 4. | [optional] 
**Part4SponsoringEntityGiin** | **string** | The GIIN for the sponsoring entity in Part 4. | [optional] 
**Part7SponsoringEntity** | **string** | The sponsoring entity information for Part 7. | [optional] 
**Part12IgaCountry** | **string** | The IGA country information for Part 12. | [optional] 
**Part12IgaType** | **string** | The IGA type information for Part 12. | [optional] 
**Part12FatcaStatusUnderIgaAnnexIi** | **string** | The FATCA status under IGA Annex II for Part 12. | [optional] 
**Part12TrusteeName** | **string** | The trustee name for Part 12. | [optional] 
**Part12TrusteeIsForeign** | **bool?** | Indicates whether the trustee is foreign for Part 12. | [optional] 
**Part12Model2IgaGiin** | **string** | The GIIN for Model 2 IGA in Part 12. | [optional] 
**Box37AExchange** | **string** | The exchange information for Box 37A. | [optional] 
**Box37BExchange** | **string** | The exchange information for Box 37B. | [optional] 
**Box37BEntity** | **string** | The entity information for Box 37B. | [optional] 
**Part28SponsoringEntity** | **string** | The sponsoring entity information for Part 28. | [optional] 
**Part28SponsoringEntityGiin** | **string** | The GIIN for the sponsoring entity in Part 28. | [optional] 
**SignerName** | **string** | The name of the signer. | [optional] 
**EDeliveryConsentedAt** | **DateTime?** | The date when e-delivery was consented. | [optional] 
**ResidenceIsMailing** | **bool?** |  | [optional] 
**CitizenshipCountry** | **string** |  | [optional] 
**MakingTreatyClaim** | **bool?** |  | [optional] 
**TreatyCountry** | **string** |  | [optional] 
**TreatyArticle** | **string** |  | [optional] 
**WithholdingRate** | **string** |  | [optional] 
**IncomeType** | **string** |  | [optional] 
**TreatyReasons** | **string** |  | [optional] 
**CertifyBox14A** | **bool** |  | [optional] 
**CertifyBox14B** | **bool** |  | [optional] 
**CertifyBox14C** | **bool** |  | [optional] 
**CertifyBox171** | **bool** |  | [optional] 
**CertifyBox172** | **bool** |  | [optional] 
**CertifyBox18** | **bool** |  | [optional] 
**CertifyBox19** | **bool** |  | [optional] 
**CertifyBox21** | **bool** |  | [optional] 
**CertifyBox22** | **bool** |  | [optional] 
**CertifyBox23** | **bool** |  | [optional] 
**CertifyBox24A** | **bool** |  | [optional] 
**CertifyBox24B** | **bool** |  | [optional] 
**CertifyBox24C** | **bool** |  | [optional] 
**CertifyBox24D** | **bool** |  | [optional] 
**CertifyBox25A** | **bool** |  | [optional] 
**CertifyBox25B** | **bool** |  | [optional] 
**CertifyBox25C** | **bool** |  | [optional] 
**CertifyBox26** | **bool** |  | [optional] 
**CertifyBox27** | **bool** |  | [optional] 
**CertifyBox28A** | **bool** |  | [optional] 
**CertifyBox28B** | **bool** |  | [optional] 
**CertifyBox29A** | **bool** |  | [optional] 
**CertifyBox29B** | **bool** |  | [optional] 
**CertifyBox29C** | **bool** |  | [optional] 
**CertifyBox29D** | **bool** |  | [optional] 
**CertifyBox29E** | **bool** |  | [optional] 
**CertifyBox29F** | **bool** |  | [optional] 
**CertifyBox30** | **bool** |  | [optional] 
**CertifyBox31** | **bool** |  | [optional] 
**CertifyBox32** | **bool** |  | [optional] 
**CertifyBox33** | **bool** |  | [optional] 
**CertifyBox34** | **bool** |  | [optional] 
**CertifyBox35** | **bool** |  | [optional] 
**CertifyBox36** | **bool** |  | [optional] 
**CertifyBox37A** | **bool** |  | [optional] 
**CertifyBox37B** | **bool** |  | [optional] 
**CertifyBox38** | **bool** |  | [optional] 
**CertifyBox39** | **bool** |  | [optional] 
**CertifyBox40A** | **bool** |  | [optional] 
**CertifyBox40B** | **bool** |  | [optional] 
**CertifyBox40C** | **bool** |  | [optional] 
**CertifyBox41** | **bool** |  | [optional] 
**CertifyBox43** | **bool** |  | [optional] 
**CertifyPart29Signature** | **bool** |  | [optional] 
**Part19FormationOrResolutionDate** | **DateTime?** |  | [optional] 
**Part20FilingDate** | **DateTime?** |  | [optional] 
**Part21DeterminationDate** | **DateTime?** |  | [optional] 
**Id** | **string** |  | [optional] 
**EntryStatus** | **string** |  | [optional] 
**UpdatedAt** | **DateTime?** | The last updated date of the form. | [optional] 
**ReferenceId** | **string** | A reference identifier for the form. | [optional] 
**CompanyId** | **string** | The ID of the associated company. | [optional] 
**DisplayName** | **string** | The display name associated with the form. | [optional] 
**Email** | **string** | The email address of the individual associated with the form. | [optional] 
**Archived** | **bool?** | Indicates whether the form is archived. | [optional] 
**EntryStatusDate** | **DateTime?** |  | [optional] 
**PdfJson** | **string** |  | [optional] 
**PdfVersion** | **string** |  | [optional] 
**RequestToken** | **string** |  | [optional] 
**Signature** | **string** |  | [optional] 
**Mobile** | **bool?** |  | [optional] 
**AppVersion** | **string** |  | [optional] 
**Platform** | **string** |  | [optional] 
**OsVersion** | **string** |  | [optional] 
**AncestorId** | **string** |  | [optional] 

[[Back to Model list]](../../../README.md#documentation-for-models) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to README]](../../../README.md)

