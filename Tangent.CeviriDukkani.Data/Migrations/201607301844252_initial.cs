namespace Tangent.CeviriDukkani.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Common.BankAccount",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BankAccountTypeId = c.Int(nullable: false),
                        BankName = c.String(),
                        AccountHolderFullName = c.String(),
                        IBAN = c.String(),
                        PaypalEmailAddress = c.String(),
                        BeneficiaryAddress = c.String(),
                        AccountNumber = c.String(),
                        SwiftBicCode = c.String(),
                        CityCountryBank = c.String(),
                        BankAddress = c.String(),
                        Active = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        UpdatedAt = c.DateTime(),
                        UpdatedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Common.BankAccountType", t => t.BankAccountTypeId, cascadeDelete: false)
                .Index(t => t.BankAccountTypeId);
            
            CreateTable(
                "Common.BankAccountType",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Active = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        UpdatedAt = c.DateTime(),
                        UpdatedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Common.Capacity",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Translation = c.Int(nullable: false),
                        Reviews = c.Int(nullable: false),
                        ProofReading = c.Int(nullable: false),
                        Active = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        UpdatedAt = c.DateTime(),
                        UpdatedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Common.City",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Code = c.String(),
                        CountryId = c.Int(nullable: false),
                        Active = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        UpdatedAt = c.DateTime(),
                        UpdatedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Common.Country", t => t.CountryId, cascadeDelete: false)
                .Index(t => t.CountryId);
            
            CreateTable(
                "Common.Country",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Code = c.String(),
                        Active = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        UpdatedAt = c.DateTime(),
                        UpdatedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Common.Comment",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Content = c.String(),
                        FromUserId = c.Int(nullable: false),
                        ToUserId = c.Int(nullable: false),
                        TranslationOperationId = c.Int(nullable: false),
                        Active = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        UpdatedAt = c.DateTime(),
                        UpdatedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("System.User", t => t.FromUserId, cascadeDelete: false)
                .ForeignKey("System.User", t => t.ToUserId, cascadeDelete: false)
                .ForeignKey("Translation.TranslationOperation", t => t.TranslationOperationId, cascadeDelete: false)
                .Index(t => t.FromUserId)
                .Index(t => t.ToUserId)
                .Index(t => t.TranslationOperationId);
            
            CreateTable(
                "System.User",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        SurName = c.String(),
                        GenderId = c.Int(nullable: false),
                        MobilePhone = c.String(),
                        BirthDate = c.DateTime(),
                        Email = c.String(),
                        Password = c.String(),
                        PasswordRetryCount = c.Int(nullable: false),
                        LastLoginDate = c.DateTime(),
                        UserContactId = c.Int(),
                        UserAbilityId = c.Int(),
                        UserPaymentId = c.Int(),
                        UserRateId = c.Int(),
                        UserScoreId = c.Int(),
                        Active = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        UpdatedAt = c.DateTime(),
                        UpdatedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Common.Gender", t => t.GenderId, cascadeDelete: false)
                .ForeignKey("System.UserAbility", t => t.UserAbilityId)
                .ForeignKey("System.UserContact", t => t.UserContactId)
                .ForeignKey("System.UserPayment", t => t.UserPaymentId)
                .ForeignKey("System.UserRate", t => t.UserRateId)
                .ForeignKey("System.UserScore", t => t.UserScoreId)
                .Index(t => t.GenderId)
                .Index(t => t.UserContactId)
                .Index(t => t.UserAbilityId)
                .Index(t => t.UserPaymentId)
                .Index(t => t.UserRateId)
                .Index(t => t.UserScoreId);
            
            CreateTable(
                "Common.Gender",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Active = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        UpdatedAt = c.DateTime(),
                        UpdatedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "System.UserAbility",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MotherTongueId = c.Int(nullable: false),
                        BilingualTongueId = c.Int(nullable: false),
                        YearsOfExperience = c.Single(nullable: false),
                        CapacityId = c.Int(nullable: false),
                        QualityEnsureDescription = c.String(),
                        Qualifications = c.String(),
                        MainClients = c.String(),
                        Active = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        UpdatedAt = c.DateTime(),
                        UpdatedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Common.Tongue", t => t.BilingualTongueId, cascadeDelete: false)
                .ForeignKey("Common.Capacity", t => t.CapacityId, cascadeDelete: false)
                .ForeignKey("Common.Tongue", t => t.MotherTongueId, cascadeDelete: false)
                .Index(t => t.MotherTongueId)
                .Index(t => t.BilingualTongueId)
                .Index(t => t.CapacityId);
            
            CreateTable(
                "Common.Tongue",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Active = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        UpdatedAt = c.DateTime(),
                        UpdatedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Common.Specialization",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserAbilityId = c.Int(nullable: false),
                        TerminologyId = c.Int(nullable: false),
                        Active = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        UpdatedAt = c.DateTime(),
                        UpdatedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Common.Terminology", t => t.TerminologyId, cascadeDelete: false)
                .ForeignKey("System.UserAbility", t => t.UserAbilityId, cascadeDelete: false)
                .Index(t => t.UserAbilityId)
                .Index(t => t.TerminologyId);
            
            CreateTable(
                "Common.Terminology",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Active = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        UpdatedAt = c.DateTime(),
                        UpdatedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "System.TechnologyKnowledge",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SoftwareId = c.Int(nullable: false),
                        SoftwareVersion = c.String(),
                        OperatingSystem = c.String(),
                        Rating = c.Int(nullable: false),
                        UserAbilityId = c.Int(nullable: false),
                        Active = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        UpdatedAt = c.DateTime(),
                        UpdatedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Common.Software", t => t.SoftwareId, cascadeDelete: false)
                .ForeignKey("System.UserAbility", t => t.UserAbilityId, cascadeDelete: false)
                .Index(t => t.SoftwareId)
                .Index(t => t.UserAbilityId);
            
            CreateTable(
                "Common.Software",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Active = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        UpdatedAt = c.DateTime(),
                        UpdatedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "System.UserContact",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Address = c.String(),
                        PostalCode = c.String(),
                        AlternativeEmail = c.String(),
                        AlternativePhone1 = c.String(),
                        AlternativePhone2 = c.String(),
                        Fax = c.String(),
                        Skype = c.String(),
                        DistrictId = c.Int(nullable: false),
                        Active = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        UpdatedAt = c.DateTime(),
                        UpdatedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Common.District", t => t.DistrictId, cascadeDelete: false)
                .Index(t => t.DistrictId);
            
            CreateTable(
                "Common.District",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CityId = c.Int(nullable: false),
                        Active = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        UpdatedAt = c.DateTime(),
                        UpdatedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Common.City", t => t.CityId, cascadeDelete: false)
                .Index(t => t.CityId);
            
            CreateTable(
                "System.UserPayment",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BankAccountId = c.Int(nullable: false),
                        VatTaxNo = c.String(),
                        CurrencyId = c.Int(nullable: false),
                        WorkingTypeId = c.Int(nullable: false),
                        MinimumChargeAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Active = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        UpdatedAt = c.DateTime(),
                        UpdatedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Common.BankAccount", t => t.BankAccountId, cascadeDelete: false)
                .ForeignKey("Common.Currency", t => t.CurrencyId, cascadeDelete: false)
                .ForeignKey("Common.WorkingType", t => t.WorkingTypeId, cascadeDelete: false)
                .Index(t => t.BankAccountId)
                .Index(t => t.CurrencyId)
                .Index(t => t.WorkingTypeId);
            
            CreateTable(
                "Common.Currency",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Active = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        UpdatedAt = c.DateTime(),
                        UpdatedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Common.WorkingType",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Active = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        UpdatedAt = c.DateTime(),
                        UpdatedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "System.UserRate",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DtpRate = c.Decimal(nullable: false, precision: 18, scale: 2),
                        GlossaryCreationRate = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TranslationMemoryManagementRate = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TerminologyExtractionRate = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ReviewSmeRate = c.Decimal(nullable: false, precision: 18, scale: 2),
                        LinguisticTestingRate = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ReviewLqaRate = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Active = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        UpdatedAt = c.DateTime(),
                        UpdatedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "System.RateItem",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ServiceTypeId = c.Int(nullable: false),
                        SourceLanguageId = c.Int(nullable: false),
                        TargetLanguageId = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SwornOrCertified = c.Boolean(),
                        CertificateId = c.Int(),
                        UserRateId = c.Int(nullable: false),
                        Active = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        UpdatedAt = c.DateTime(),
                        UpdatedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Document.UserDocument", t => t.CertificateId)
                .ForeignKey("Common.ServiceType", t => t.ServiceTypeId, cascadeDelete: false)
                .ForeignKey("Common.Language", t => t.SourceLanguageId, cascadeDelete: false)
                .ForeignKey("Common.Language", t => t.TargetLanguageId, cascadeDelete: false)
                .ForeignKey("System.UserRate", t => t.UserRateId, cascadeDelete: false)
                .Index(t => t.ServiceTypeId)
                .Index(t => t.SourceLanguageId)
                .Index(t => t.TargetLanguageId)
                .Index(t => t.CertificateId)
                .Index(t => t.UserRateId);
            
            CreateTable(
                "Document.UserDocument",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserDocumentTypeId = c.Int(nullable: false),
                        UserRateId = c.Int(nullable: false),
                        Name = c.String(),
                        Path = c.String(),
                        Active = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        UpdatedAt = c.DateTime(),
                        UpdatedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Common.UserDocumentType", t => t.UserDocumentTypeId, cascadeDelete: false)
                .ForeignKey("System.UserRate", t => t.UserRateId, cascadeDelete: false)
                .Index(t => t.UserDocumentTypeId)
                .Index(t => t.UserRateId);
            
            CreateTable(
                "Common.UserDocumentType",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Active = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        UpdatedAt = c.DateTime(),
                        UpdatedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Common.ServiceType",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Active = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        UpdatedAt = c.DateTime(),
                        UpdatedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Common.Language",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Active = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        UpdatedAt = c.DateTime(),
                        UpdatedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "System.UserRole",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        UserRoleTypeId = c.Int(nullable: false),
                        Active = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        UpdatedAt = c.DateTime(),
                        UpdatedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("System.User", t => t.UserId, cascadeDelete: false)
                .ForeignKey("Common.UserRoleType", t => t.UserRoleTypeId, cascadeDelete: false)
                .Index(t => t.UserId)
                .Index(t => t.UserRoleTypeId);
            
            CreateTable(
                "Common.UserRoleType",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Active = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        UpdatedAt = c.DateTime(),
                        UpdatedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "System.UserScore",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AverageTranslatingScore = c.Double(nullable: false),
                        AverageEditingScore = c.Double(nullable: false),
                        AverageProofReadingScore = c.Double(nullable: false),
                        Active = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        UpdatedAt = c.DateTime(),
                        UpdatedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "System.UserScoreTransaction",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        VotingUserId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                        TranslatingScoreId = c.Int(nullable: false),
                        EditingScoreId = c.Int(nullable: false),
                        ProofReadingScoreId = c.Int(nullable: false),
                        RelatedDocumentId = c.Int(nullable: false),
                        UserScoreId = c.Int(nullable: false),
                        Active = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        UpdatedAt = c.DateTime(),
                        UpdatedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Common.Score", t => t.EditingScoreId, cascadeDelete: false)
                .ForeignKey("Common.Score", t => t.ProofReadingScoreId, cascadeDelete: false)
                .ForeignKey("Common.Score", t => t.TranslatingScoreId, cascadeDelete: false)
                .ForeignKey("System.User", t => t.UserId, cascadeDelete: false)
                .ForeignKey("System.UserScore", t => t.UserScoreId, cascadeDelete: false)
                .ForeignKey("System.User", t => t.VotingUserId, cascadeDelete: false)
                .Index(t => t.VotingUserId)
                .Index(t => t.UserId)
                .Index(t => t.TranslatingScoreId)
                .Index(t => t.EditingScoreId)
                .Index(t => t.ProofReadingScoreId)
                .Index(t => t.UserScoreId);
            
            CreateTable(
                "Common.Score",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Active = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        UpdatedAt = c.DateTime(),
                        UpdatedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Translation.TranslationOperation",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TranslationDocumentPartId = c.Int(nullable: false),
                        TranslatorId = c.Int(),
                        TranslatedContent = c.String(),
                        EditorId = c.Int(),
                        EditedContent = c.String(),
                        ProofReaderId = c.Int(),
                        ProofReadContent = c.String(),
                        TranslationOperationStatusId = c.Int(nullable: false),
                        TranslationProgressStatusId = c.Int(nullable: false),
                        Active = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        UpdatedAt = c.DateTime(),
                        UpdatedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("System.User", t => t.EditorId)
                .ForeignKey("System.User", t => t.ProofReaderId)
                .ForeignKey("Document.TranslationDocumentPart", t => t.TranslationDocumentPartId, cascadeDelete: false)
                .ForeignKey("Common.TranslationOperationStatus", t => t.TranslationOperationStatusId, cascadeDelete: false)
                .ForeignKey("Common.TranslationProgressStatus", t => t.TranslationProgressStatusId, cascadeDelete: false)
                .ForeignKey("System.User", t => t.TranslatorId)
                .Index(t => t.TranslationDocumentPartId)
                .Index(t => t.TranslatorId)
                .Index(t => t.EditorId)
                .Index(t => t.ProofReaderId)
                .Index(t => t.TranslationOperationStatusId)
                .Index(t => t.TranslationProgressStatusId);
            
            CreateTable(
                "Document.TranslationDocumentPart",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TranslationDocumentId = c.Int(nullable: false),
                        Path = c.String(),
                        Content = c.String(),
                        Active = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        UpdatedAt = c.DateTime(),
                        UpdatedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Document.TranslationDocument", t => t.TranslationDocumentId, cascadeDelete: false)
                .Index(t => t.TranslationDocumentId);
            
            CreateTable(
                "Document.TranslationDocument",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PageCount = c.Int(nullable: false),
                        CharCount = c.Int(nullable: false),
                        CharCountWithSpaces = c.Int(nullable: false),
                        Name = c.String(),
                        Path = c.String(),
                        Active = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        UpdatedAt = c.DateTime(),
                        UpdatedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Common.TranslationOperationStatus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Active = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        UpdatedAt = c.DateTime(),
                        UpdatedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Common.TranslationProgressStatus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Active = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        UpdatedAt = c.DateTime(),
                        UpdatedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Common.Company",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        AuthorizedEmail = c.String(),
                        AuthorizedFullName = c.String(),
                        AuthorizedMobilePhone = c.String(),
                        Phone = c.String(),
                        ExtensionNumber = c.String(),
                        AccountingEmail = c.String(),
                        IsUsingPo = c.Boolean(),
                        TaxNumber = c.String(),
                        TaxOffice = c.String(),
                        Address = c.String(),
                        IsContractPrice = c.Boolean(),
                        Active = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        UpdatedAt = c.DateTime(),
                        UpdatedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Translation.CompanyDocumentTemplate",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CompanyId = c.Int(nullable: false),
                        Name = c.String(),
                        FileUrl = c.String(),
                        Active = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        UpdatedAt = c.DateTime(),
                        UpdatedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Common.Company", t => t.CompanyId, cascadeDelete: false)
                .Index(t => t.CompanyId);
            
            CreateTable(
                "Translation.CompanyTerminology",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CompanyId = c.Int(nullable: false),
                        Name = c.String(),
                        FileUrl = c.String(),
                        CompanyTerminologyStatusId = c.Int(nullable: false),
                        Active = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        UpdatedAt = c.DateTime(),
                        UpdatedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Common.Company", t => t.CompanyId, cascadeDelete: false)
                .ForeignKey("Common.CompanyTerminologyStatus", t => t.CompanyTerminologyStatusId, cascadeDelete: false)
                .Index(t => t.CompanyId)
                .Index(t => t.CompanyTerminologyStatusId);
            
            CreateTable(
                "Common.CompanyTerminologyStatus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Active = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        UpdatedAt = c.DateTime(),
                        UpdatedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Translation.TerminologyItem",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SourceWord = c.String(),
                        TargetWord = c.String(),
                        Approved = c.Boolean(nullable: false),
                        CompanyTerminologyId = c.Int(nullable: false),
                        Active = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        UpdatedAt = c.DateTime(),
                        UpdatedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Translation.CompanyTerminology", t => t.CompanyTerminologyId, cascadeDelete: false)
                .Index(t => t.CompanyTerminologyId);
            
            CreateTable(
                "Sale.Customer",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MembershipTypeId = c.Int(nullable: false),
                        Name = c.String(),
                        Surname = c.String(),
                        MobilePhone = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                        EmailConfirmed = c.Boolean(nullable: false),
                        SmsConfirmed = c.Boolean(nullable: false),
                        CompanyId = c.Int(),
                        InstitutionCode = c.String(),
                        Active = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        UpdatedAt = c.DateTime(),
                        UpdatedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Common.Company", t => t.CompanyId)
                .ForeignKey("Common.MembershipType", t => t.MembershipTypeId, cascadeDelete: false)
                .Index(t => t.MembershipTypeId)
                .Index(t => t.CompanyId);
            
            CreateTable(
                "Common.MembershipType",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Active = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        UpdatedAt = c.DateTime(),
                        UpdatedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Document.GeneralDocument",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GeneralDocumentTypeId = c.Int(nullable: false),
                        Name = c.String(),
                        Path = c.String(),
                        Active = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        UpdatedAt = c.DateTime(),
                        UpdatedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Common.GeneralDocumentType", t => t.GeneralDocumentTypeId, cascadeDelete: false)
                .Index(t => t.GeneralDocumentTypeId);
            
            CreateTable(
                "Common.GeneralDocumentType",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Active = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        UpdatedAt = c.DateTime(),
                        UpdatedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "System.Mail",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Subject = c.String(),
                        Message = c.String(),
                        Status = c.Int(nullable: false),
                        MailSender = c.Int(nullable: false),
                        SendTime = c.DateTime(),
                        Exception = c.String(),
                        Active = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        UpdatedAt = c.DateTime(),
                        UpdatedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "System.MailTargets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MailAddres = c.String(),
                        Active = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        UpdatedAt = c.DateTime(),
                        UpdatedBy = c.Int(),
                        MailItem_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("System.Mail", t => t.MailItem_Id)
                .Index(t => t.MailItem_Id);
            
            CreateTable(
                "Common.Message",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FromUserId = c.Int(),
                        ToUserId = c.Int(),
                        FromCustomerId = c.Int(),
                        ToCustomerId = c.Int(),
                        MessageText = c.String(),
                        ReadDate = c.DateTime(),
                        FromStatus = c.Boolean(nullable: false),
                        ToStatus = c.Boolean(nullable: false),
                        Active = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        UpdatedAt = c.DateTime(),
                        UpdatedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Sale.Customer", t => t.FromCustomerId)
                .ForeignKey("System.User", t => t.FromUserId)
                .ForeignKey("Sale.Customer", t => t.ToCustomerId)
                .ForeignKey("System.User", t => t.ToUserId)
                .Index(t => t.FromUserId)
                .Index(t => t.ToUserId)
                .Index(t => t.FromCustomerId)
                .Index(t => t.ToCustomerId);
            
            CreateTable(
                "Sale.OrderDetail",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderId = c.Int(nullable: false),
                        TranslationOperationId = c.Int(nullable: false),
                        AveragePrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        OfferedPrice = c.Decimal(precision: 18, scale: 2),
                        AcceptedPrice = c.Decimal(precision: 18, scale: 2),
                        EditorAveragePrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        EditorOfferedPrice = c.Decimal(precision: 18, scale: 2),
                        EditorAcceptedPrice = c.Decimal(precision: 18, scale: 2),
                        ProofReaderAveragePrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ProofReaderOfferedPrice = c.Decimal(precision: 18, scale: 2),
                        ProofReaderAcceptedPrice = c.Decimal(precision: 18, scale: 2),
                        Active = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        UpdatedAt = c.DateTime(),
                        UpdatedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Sale.Order", t => t.OrderId, cascadeDelete: false)
                .ForeignKey("Translation.TranslationOperation", t => t.TranslationOperationId, cascadeDelete: false)
                .Index(t => t.OrderId)
                .Index(t => t.TranslationOperationId);
            
            CreateTable(
                "Sale.Order",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TranslationDocumentId = c.Int(nullable: false),
                        CustomerId = c.Int(nullable: false),
                        SourceLanguageId = c.Int(nullable: false),
                        TerminologyId = c.Int(nullable: false),
                        CompanyTerminologyId = c.Int(),
                        CompanyDocumentTemplateId = c.Int(),
                        TranslationQualityId = c.Int(nullable: false),
                        CalculatedPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        VatPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        OrderPotentialDeliveryDate = c.DateTime(),
                        OrderStatusId = c.Int(nullable: false),
                        Active = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        UpdatedAt = c.DateTime(),
                        UpdatedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Translation.CompanyDocumentTemplate", t => t.CompanyDocumentTemplateId)
                .ForeignKey("Translation.CompanyTerminology", t => t.CompanyTerminologyId)
                .ForeignKey("Sale.Customer", t => t.CustomerId, cascadeDelete: false)
                .ForeignKey("Common.OrderStatus", t => t.OrderStatusId, cascadeDelete: false)
                .ForeignKey("Common.Language", t => t.SourceLanguageId, cascadeDelete: false)
                .ForeignKey("Common.Terminology", t => t.TerminologyId, cascadeDelete: false)
                .ForeignKey("Document.TranslationDocument", t => t.TranslationDocumentId, cascadeDelete: false)
                .ForeignKey("Common.TranslationQuality", t => t.TranslationQualityId, cascadeDelete: false)
                .Index(t => t.TranslationDocumentId)
                .Index(t => t.CustomerId)
                .Index(t => t.SourceLanguageId)
                .Index(t => t.TerminologyId)
                .Index(t => t.CompanyTerminologyId)
                .Index(t => t.CompanyDocumentTemplateId)
                .Index(t => t.TranslationQualityId)
                .Index(t => t.OrderStatusId);
            
            CreateTable(
                "Common.OrderStatus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Active = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        UpdatedAt = c.DateTime(),
                        UpdatedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Common.OrderTargetLanguage",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderId = c.Int(nullable: false),
                        LanguageId = c.Int(nullable: false),
                        Active = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        UpdatedAt = c.DateTime(),
                        UpdatedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Common.Language", t => t.LanguageId, cascadeDelete: false)
                .ForeignKey("Sale.Order", t => t.OrderId, cascadeDelete: false)
                .Index(t => t.OrderId)
                .Index(t => t.LanguageId);
            
            CreateTable(
                "Common.TranslationQuality",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Active = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        UpdatedAt = c.DateTime(),
                        UpdatedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Sale.PriceList",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SourceLanguageId = c.Int(nullable: false),
                        TargetLanguageId = c.Int(nullable: false),
                        Char_0_100 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Char_100_150 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Char_150_200 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Char_200_500 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Char_500_More = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Active = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        UpdatedAt = c.DateTime(),
                        UpdatedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Common.Language", t => t.SourceLanguageId, cascadeDelete: false)
                .ForeignKey("Common.Language", t => t.TargetLanguageId, cascadeDelete: false)
                .Index(t => t.SourceLanguageId)
                .Index(t => t.TargetLanguageId);
            
            CreateTable(
                "Translation.SourceTargetLanguage",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SourceLanguageId = c.Int(nullable: false),
                        TargetLanguageId = c.Int(nullable: false),
                        Active = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        UpdatedAt = c.DateTime(),
                        UpdatedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Common.Language", t => t.SourceLanguageId, cascadeDelete: false)
                .ForeignKey("Common.Language", t => t.TargetLanguageId, cascadeDelete: false)
                .Index(t => t.SourceLanguageId)
                .Index(t => t.TargetLanguageId);
            
            CreateTable(
                "Common.TerminologyPriceRate",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TerminologyId = c.Int(nullable: false),
                        Rate = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Active = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        UpdatedAt = c.DateTime(),
                        UpdatedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Common.Terminology", t => t.TerminologyId, cascadeDelete: false)
                .Index(t => t.TerminologyId);
            
            CreateTable(
                "System.UserLanguage",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        LanguageId = c.Int(nullable: false),
                        TerminologyId = c.Int(),
                        Active = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        UpdatedAt = c.DateTime(),
                        UpdatedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Common.Language", t => t.LanguageId, cascadeDelete: false)
                .ForeignKey("Common.Terminology", t => t.TerminologyId)
                .ForeignKey("System.User", t => t.UserId, cascadeDelete: false)
                .Index(t => t.UserId)
                .Index(t => t.LanguageId)
                .Index(t => t.TerminologyId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("System.UserLanguage", "UserId", "System.User");
            DropForeignKey("System.UserLanguage", "TerminologyId", "Common.Terminology");
            DropForeignKey("System.UserLanguage", "LanguageId", "Common.Language");
            DropForeignKey("Common.TerminologyPriceRate", "TerminologyId", "Common.Terminology");
            DropForeignKey("Translation.SourceTargetLanguage", "TargetLanguageId", "Common.Language");
            DropForeignKey("Translation.SourceTargetLanguage", "SourceLanguageId", "Common.Language");
            DropForeignKey("Sale.PriceList", "TargetLanguageId", "Common.Language");
            DropForeignKey("Sale.PriceList", "SourceLanguageId", "Common.Language");
            DropForeignKey("Sale.OrderDetail", "TranslationOperationId", "Translation.TranslationOperation");
            DropForeignKey("Sale.Order", "TranslationQualityId", "Common.TranslationQuality");
            DropForeignKey("Sale.Order", "TranslationDocumentId", "Document.TranslationDocument");
            DropForeignKey("Sale.Order", "TerminologyId", "Common.Terminology");
            DropForeignKey("Common.OrderTargetLanguage", "OrderId", "Sale.Order");
            DropForeignKey("Common.OrderTargetLanguage", "LanguageId", "Common.Language");
            DropForeignKey("Sale.Order", "SourceLanguageId", "Common.Language");
            DropForeignKey("Sale.Order", "OrderStatusId", "Common.OrderStatus");
            DropForeignKey("Sale.OrderDetail", "OrderId", "Sale.Order");
            DropForeignKey("Sale.Order", "CustomerId", "Sale.Customer");
            DropForeignKey("Sale.Order", "CompanyTerminologyId", "Translation.CompanyTerminology");
            DropForeignKey("Sale.Order", "CompanyDocumentTemplateId", "Translation.CompanyDocumentTemplate");
            DropForeignKey("Common.Message", "ToUserId", "System.User");
            DropForeignKey("Common.Message", "ToCustomerId", "Sale.Customer");
            DropForeignKey("Common.Message", "FromUserId", "System.User");
            DropForeignKey("Common.Message", "FromCustomerId", "Sale.Customer");
            DropForeignKey("System.MailTargets", "MailItem_Id", "System.Mail");
            DropForeignKey("Document.GeneralDocument", "GeneralDocumentTypeId", "Common.GeneralDocumentType");
            DropForeignKey("Sale.Customer", "MembershipTypeId", "Common.MembershipType");
            DropForeignKey("Sale.Customer", "CompanyId", "Common.Company");
            DropForeignKey("Translation.TerminologyItem", "CompanyTerminologyId", "Translation.CompanyTerminology");
            DropForeignKey("Translation.CompanyTerminology", "CompanyTerminologyStatusId", "Common.CompanyTerminologyStatus");
            DropForeignKey("Translation.CompanyTerminology", "CompanyId", "Common.Company");
            DropForeignKey("Translation.CompanyDocumentTemplate", "CompanyId", "Common.Company");
            DropForeignKey("Translation.TranslationOperation", "TranslatorId", "System.User");
            DropForeignKey("Translation.TranslationOperation", "TranslationProgressStatusId", "Common.TranslationProgressStatus");
            DropForeignKey("Translation.TranslationOperation", "TranslationOperationStatusId", "Common.TranslationOperationStatus");
            DropForeignKey("Translation.TranslationOperation", "TranslationDocumentPartId", "Document.TranslationDocumentPart");
            DropForeignKey("Document.TranslationDocumentPart", "TranslationDocumentId", "Document.TranslationDocument");
            DropForeignKey("Translation.TranslationOperation", "ProofReaderId", "System.User");
            DropForeignKey("Translation.TranslationOperation", "EditorId", "System.User");
            DropForeignKey("Common.Comment", "TranslationOperationId", "Translation.TranslationOperation");
            DropForeignKey("Common.Comment", "ToUserId", "System.User");
            DropForeignKey("Common.Comment", "FromUserId", "System.User");
            DropForeignKey("System.User", "UserScoreId", "System.UserScore");
            DropForeignKey("System.UserScoreTransaction", "VotingUserId", "System.User");
            DropForeignKey("System.UserScoreTransaction", "UserScoreId", "System.UserScore");
            DropForeignKey("System.UserScoreTransaction", "UserId", "System.User");
            DropForeignKey("System.UserScoreTransaction", "TranslatingScoreId", "Common.Score");
            DropForeignKey("System.UserScoreTransaction", "ProofReadingScoreId", "Common.Score");
            DropForeignKey("System.UserScoreTransaction", "EditingScoreId", "Common.Score");
            DropForeignKey("System.UserRole", "UserRoleTypeId", "Common.UserRoleType");
            DropForeignKey("System.UserRole", "UserId", "System.User");
            DropForeignKey("System.User", "UserRateId", "System.UserRate");
            DropForeignKey("System.RateItem", "UserRateId", "System.UserRate");
            DropForeignKey("System.RateItem", "TargetLanguageId", "Common.Language");
            DropForeignKey("System.RateItem", "SourceLanguageId", "Common.Language");
            DropForeignKey("System.RateItem", "ServiceTypeId", "Common.ServiceType");
            DropForeignKey("System.RateItem", "CertificateId", "Document.UserDocument");
            DropForeignKey("Document.UserDocument", "UserRateId", "System.UserRate");
            DropForeignKey("Document.UserDocument", "UserDocumentTypeId", "Common.UserDocumentType");
            DropForeignKey("System.User", "UserPaymentId", "System.UserPayment");
            DropForeignKey("System.UserPayment", "WorkingTypeId", "Common.WorkingType");
            DropForeignKey("System.UserPayment", "CurrencyId", "Common.Currency");
            DropForeignKey("System.UserPayment", "BankAccountId", "Common.BankAccount");
            DropForeignKey("System.User", "UserContactId", "System.UserContact");
            DropForeignKey("System.UserContact", "DistrictId", "Common.District");
            DropForeignKey("Common.District", "CityId", "Common.City");
            DropForeignKey("System.User", "UserAbilityId", "System.UserAbility");
            DropForeignKey("System.TechnologyKnowledge", "UserAbilityId", "System.UserAbility");
            DropForeignKey("System.TechnologyKnowledge", "SoftwareId", "Common.Software");
            DropForeignKey("Common.Specialization", "UserAbilityId", "System.UserAbility");
            DropForeignKey("Common.Specialization", "TerminologyId", "Common.Terminology");
            DropForeignKey("System.UserAbility", "MotherTongueId", "Common.Tongue");
            DropForeignKey("System.UserAbility", "CapacityId", "Common.Capacity");
            DropForeignKey("System.UserAbility", "BilingualTongueId", "Common.Tongue");
            DropForeignKey("System.User", "GenderId", "Common.Gender");
            DropForeignKey("Common.City", "CountryId", "Common.Country");
            DropForeignKey("Common.BankAccount", "BankAccountTypeId", "Common.BankAccountType");
            DropIndex("System.UserLanguage", new[] { "TerminologyId" });
            DropIndex("System.UserLanguage", new[] { "LanguageId" });
            DropIndex("System.UserLanguage", new[] { "UserId" });
            DropIndex("Common.TerminologyPriceRate", new[] { "TerminologyId" });
            DropIndex("Translation.SourceTargetLanguage", new[] { "TargetLanguageId" });
            DropIndex("Translation.SourceTargetLanguage", new[] { "SourceLanguageId" });
            DropIndex("Sale.PriceList", new[] { "TargetLanguageId" });
            DropIndex("Sale.PriceList", new[] { "SourceLanguageId" });
            DropIndex("Common.OrderTargetLanguage", new[] { "LanguageId" });
            DropIndex("Common.OrderTargetLanguage", new[] { "OrderId" });
            DropIndex("Sale.Order", new[] { "OrderStatusId" });
            DropIndex("Sale.Order", new[] { "TranslationQualityId" });
            DropIndex("Sale.Order", new[] { "CompanyDocumentTemplateId" });
            DropIndex("Sale.Order", new[] { "CompanyTerminologyId" });
            DropIndex("Sale.Order", new[] { "TerminologyId" });
            DropIndex("Sale.Order", new[] { "SourceLanguageId" });
            DropIndex("Sale.Order", new[] { "CustomerId" });
            DropIndex("Sale.Order", new[] { "TranslationDocumentId" });
            DropIndex("Sale.OrderDetail", new[] { "TranslationOperationId" });
            DropIndex("Sale.OrderDetail", new[] { "OrderId" });
            DropIndex("Common.Message", new[] { "ToCustomerId" });
            DropIndex("Common.Message", new[] { "FromCustomerId" });
            DropIndex("Common.Message", new[] { "ToUserId" });
            DropIndex("Common.Message", new[] { "FromUserId" });
            DropIndex("System.MailTargets", new[] { "MailItem_Id" });
            DropIndex("Document.GeneralDocument", new[] { "GeneralDocumentTypeId" });
            DropIndex("Sale.Customer", new[] { "CompanyId" });
            DropIndex("Sale.Customer", new[] { "MembershipTypeId" });
            DropIndex("Translation.TerminologyItem", new[] { "CompanyTerminologyId" });
            DropIndex("Translation.CompanyTerminology", new[] { "CompanyTerminologyStatusId" });
            DropIndex("Translation.CompanyTerminology", new[] { "CompanyId" });
            DropIndex("Translation.CompanyDocumentTemplate", new[] { "CompanyId" });
            DropIndex("Document.TranslationDocumentPart", new[] { "TranslationDocumentId" });
            DropIndex("Translation.TranslationOperation", new[] { "TranslationProgressStatusId" });
            DropIndex("Translation.TranslationOperation", new[] { "TranslationOperationStatusId" });
            DropIndex("Translation.TranslationOperation", new[] { "ProofReaderId" });
            DropIndex("Translation.TranslationOperation", new[] { "EditorId" });
            DropIndex("Translation.TranslationOperation", new[] { "TranslatorId" });
            DropIndex("Translation.TranslationOperation", new[] { "TranslationDocumentPartId" });
            DropIndex("System.UserScoreTransaction", new[] { "UserScoreId" });
            DropIndex("System.UserScoreTransaction", new[] { "ProofReadingScoreId" });
            DropIndex("System.UserScoreTransaction", new[] { "EditingScoreId" });
            DropIndex("System.UserScoreTransaction", new[] { "TranslatingScoreId" });
            DropIndex("System.UserScoreTransaction", new[] { "UserId" });
            DropIndex("System.UserScoreTransaction", new[] { "VotingUserId" });
            DropIndex("System.UserRole", new[] { "UserRoleTypeId" });
            DropIndex("System.UserRole", new[] { "UserId" });
            DropIndex("Document.UserDocument", new[] { "UserRateId" });
            DropIndex("Document.UserDocument", new[] { "UserDocumentTypeId" });
            DropIndex("System.RateItem", new[] { "UserRateId" });
            DropIndex("System.RateItem", new[] { "CertificateId" });
            DropIndex("System.RateItem", new[] { "TargetLanguageId" });
            DropIndex("System.RateItem", new[] { "SourceLanguageId" });
            DropIndex("System.RateItem", new[] { "ServiceTypeId" });
            DropIndex("System.UserPayment", new[] { "WorkingTypeId" });
            DropIndex("System.UserPayment", new[] { "CurrencyId" });
            DropIndex("System.UserPayment", new[] { "BankAccountId" });
            DropIndex("Common.District", new[] { "CityId" });
            DropIndex("System.UserContact", new[] { "DistrictId" });
            DropIndex("System.TechnologyKnowledge", new[] { "UserAbilityId" });
            DropIndex("System.TechnologyKnowledge", new[] { "SoftwareId" });
            DropIndex("Common.Specialization", new[] { "TerminologyId" });
            DropIndex("Common.Specialization", new[] { "UserAbilityId" });
            DropIndex("System.UserAbility", new[] { "CapacityId" });
            DropIndex("System.UserAbility", new[] { "BilingualTongueId" });
            DropIndex("System.UserAbility", new[] { "MotherTongueId" });
            DropIndex("System.User", new[] { "UserScoreId" });
            DropIndex("System.User", new[] { "UserRateId" });
            DropIndex("System.User", new[] { "UserPaymentId" });
            DropIndex("System.User", new[] { "UserAbilityId" });
            DropIndex("System.User", new[] { "UserContactId" });
            DropIndex("System.User", new[] { "GenderId" });
            DropIndex("Common.Comment", new[] { "TranslationOperationId" });
            DropIndex("Common.Comment", new[] { "ToUserId" });
            DropIndex("Common.Comment", new[] { "FromUserId" });
            DropIndex("Common.City", new[] { "CountryId" });
            DropIndex("Common.BankAccount", new[] { "BankAccountTypeId" });
            DropTable("System.UserLanguage");
            DropTable("Common.TerminologyPriceRate");
            DropTable("Translation.SourceTargetLanguage");
            DropTable("Sale.PriceList");
            DropTable("Common.TranslationQuality");
            DropTable("Common.OrderTargetLanguage");
            DropTable("Common.OrderStatus");
            DropTable("Sale.Order");
            DropTable("Sale.OrderDetail");
            DropTable("Common.Message");
            DropTable("System.MailTargets");
            DropTable("System.Mail");
            DropTable("Common.GeneralDocumentType");
            DropTable("Document.GeneralDocument");
            DropTable("Common.MembershipType");
            DropTable("Sale.Customer");
            DropTable("Translation.TerminologyItem");
            DropTable("Common.CompanyTerminologyStatus");
            DropTable("Translation.CompanyTerminology");
            DropTable("Translation.CompanyDocumentTemplate");
            DropTable("Common.Company");
            DropTable("Common.TranslationProgressStatus");
            DropTable("Common.TranslationOperationStatus");
            DropTable("Document.TranslationDocument");
            DropTable("Document.TranslationDocumentPart");
            DropTable("Translation.TranslationOperation");
            DropTable("Common.Score");
            DropTable("System.UserScoreTransaction");
            DropTable("System.UserScore");
            DropTable("Common.UserRoleType");
            DropTable("System.UserRole");
            DropTable("Common.Language");
            DropTable("Common.ServiceType");
            DropTable("Common.UserDocumentType");
            DropTable("Document.UserDocument");
            DropTable("System.RateItem");
            DropTable("System.UserRate");
            DropTable("Common.WorkingType");
            DropTable("Common.Currency");
            DropTable("System.UserPayment");
            DropTable("Common.District");
            DropTable("System.UserContact");
            DropTable("Common.Software");
            DropTable("System.TechnologyKnowledge");
            DropTable("Common.Terminology");
            DropTable("Common.Specialization");
            DropTable("Common.Tongue");
            DropTable("System.UserAbility");
            DropTable("Common.Gender");
            DropTable("System.User");
            DropTable("Common.Comment");
            DropTable("Common.Country");
            DropTable("Common.City");
            DropTable("Common.Capacity");
            DropTable("Common.BankAccountType");
            DropTable("Common.BankAccount");
        }
    }
}
