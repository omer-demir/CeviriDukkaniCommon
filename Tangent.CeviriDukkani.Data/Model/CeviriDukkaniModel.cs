using System.Data.Entity;
using Tangent.CeviriDukkani.Domain.Entities.Common;
using Tangent.CeviriDukkani.Domain.Entities.Document;
using Tangent.CeviriDukkani.Domain.Entities.Sale;
using Tangent.CeviriDukkani.Domain.Entities.System;
using Tangent.CeviriDukkani.Domain.Entities.Translation;

namespace Tangent.CeviriDukkani.Data.Model
{
    public class CeviriDukkaniModel : DbContext
    {
        public CeviriDukkaniModel() : base("name=DefaultConnection")
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }

        #region Common

        public virtual DbSet<BankAccount> BankAccounts { get; set; }
        public virtual DbSet<BankAccountType> BankAccountTypes { get; set; }
        public virtual DbSet<Capacity> Capacities { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<CompanyTerminologyStatus> CompanyTerminologyStatuses { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Currency> Currencies { get; set; }
        public virtual DbSet<District> Districts { get; set; }
        public virtual DbSet<Gender> Genders { get; set; }
        public virtual DbSet<GeneralDocumentType> GeneralDocumentTypes { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<MembershipType> MembershipTypes { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<OrderStatus> OrderStatuses { get; set; }
        public virtual DbSet<Score> Scores { get; set; }
        public virtual DbSet<ServiceType> ServiceTypes { get; set; }
        public virtual DbSet<Software> Softwares { get; set; }
        public virtual DbSet<Terminology> Terminologies { get; set; }
        public virtual DbSet<TranslationOperationStatus> TranslationOperationStatuses { get; set; }
        public virtual DbSet<TranslationProgressStatus> TranslationProgressStatuses { get; set; }
        public virtual DbSet<TranslationQuality> TranslationQualities { get; set; }
        public virtual DbSet<UserDocumentType> UsercoDocumentTypes { get; set; }
        public virtual DbSet<UserRoleType> UserRoleTypes { get; set; }
        public virtual DbSet<WorkingType> WorkingTypes { get; set; }
        public virtual DbSet<Specialization> Specializations { get; set; }
        public virtual DbSet<Tongue> Tongues { get; set; }
        public virtual DbSet<TerminologyPriceRate> TerminologyPriceRate { get; set; }
        public virtual DbSet<Configuration> Configurations { get; set; }

        #endregion

        #region Document 

        public virtual DbSet<TranslationDocumentPart> TranslationDocumentParts { get; set; }
        public virtual DbSet<GeneralDocument> GeneralDocuments { get; set; }
        public virtual DbSet<TranslationDocument> TranslationDocuments { get; set; }
        public virtual DbSet<UserDocument> UserDocuments { get; set; }

        #endregion

        #region Sale

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<PriceList> PriceLists { get; set; }
        public virtual DbSet<CampaignItem> CampaignItems { get; set; }
        public virtual DbSet<CompanyPriceOffer> CompanyPriceOffers { get; set; }

        #endregion

        #region System

        public virtual DbSet<RateItem> RateItems { get; set; }
        public virtual DbSet<TechnologyKnowledge> TechnologyKnowledges { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserAbility> UserAbilities { get; set; }
        public virtual DbSet<UserContact> UserContacts { get; set; }
        public virtual DbSet<UserLanguage> UserLanguages { get; set; }
        public virtual DbSet<UserPayment> UserPayments { get; set; }
        public virtual DbSet<UserRate> UserRates { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }
        public virtual DbSet<UserScore> UserScores { get; set; }
        public virtual DbSet<UserScoreTransaction> UserScoreTransactions { get; set; }
        public virtual DbSet<MailItem> Mail { get; set; }
        public virtual DbSet<AccountRegistration> AccountRegistrations { get; set; }

        #endregion

        #region Translation

        public virtual DbSet<CompanyDocumentTemplate> CompanyDocumentTemplates { get; set; }
        public virtual DbSet<CompanyTerminology> CompanyTerminologies { get; set; }
        public virtual DbSet<SourceTargetLanguage> SourceTargetLanguages { get; set; }
        public virtual DbSet<TerminologyItem> TerminologyItems { get; set; }
        public virtual DbSet<TranslationOperation> TranslationOperations { get; set; }

        #endregion
    }
}
