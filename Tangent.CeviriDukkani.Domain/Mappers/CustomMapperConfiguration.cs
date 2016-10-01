using System.Linq;
using AutoMapper;
using Tangent.CeviriDukkani.Domain.Dto;
using Tangent.CeviriDukkani.Domain.Dto.Audit;
using Tangent.CeviriDukkani.Domain.Dto.Common;
using Tangent.CeviriDukkani.Domain.Dto.Document;
using Tangent.CeviriDukkani.Domain.Dto.Sale;
using Tangent.CeviriDukkani.Domain.Dto.System;
using Tangent.CeviriDukkani.Domain.Dto.Translation;
using Tangent.CeviriDukkani.Domain.Entities;
using Tangent.CeviriDukkani.Domain.Entities.Audit;
using Tangent.CeviriDukkani.Domain.Entities.Common;
using Tangent.CeviriDukkani.Domain.Entities.Document;
using Tangent.CeviriDukkani.Domain.Entities.Sale;
using Tangent.CeviriDukkani.Domain.Entities.System;
using Tangent.CeviriDukkani.Domain.Entities.Translation;

namespace Tangent.CeviriDukkani.Domain.Mappers {
    public class CustomMapperConfiguration : ICustomMapperConfiguration {
        private readonly IMapper _mapper;

        public CustomMapperConfiguration() {
            var mapperConfiguration = new MapperConfiguration(a => {
                //Dto -> Entity

                a.CreateMap<BaseDto, BaseEntity>();
                a.CreateMap<KeyValueDto, KeyValue>();

                a.CreateMap<BankAccountDto, BankAccount>();
                a.CreateMap<BankAccountTypeDto, BankAccountType>();
                a.CreateMap<CapacityDto, Capacity>();
                a.CreateMap<CityDto, City>();
                a.CreateMap<CommentDto, Comment>();
                a.CreateMap<CompanyDto, Company>();
                a.CreateMap<CompanyTerminologyStatusDto, CompanyTerminologyStatus>();
                a.CreateMap<CountryDto, Country>();
                a.CreateMap<CurrencyDto, Currency>();
                a.CreateMap<DistrictDto, District>();
                a.CreateMap<GenderDto, Gender>();
                a.CreateMap<GeneralDocumentTypeDto, GeneralDocumentType>();
                a.CreateMap<LanguageDto, Language>();
                a.CreateMap<MembershipTypeDto, MembershipType>();
                a.CreateMap<MessageDto, Message>();
                a.CreateMap<OrderStatusDto, OrderStatus>();
                a.CreateMap<ScoreDto, Score>();
                a.CreateMap<ServiceTypeDto, ServiceType>();
                a.CreateMap<SpecializationDto, Specialization>();
                a.CreateMap<SoftwareDto, Software>();
                a.CreateMap<TerminologyDto, Terminology>();
                a.CreateMap<TranslationOperationStatusDto, TranslationOperationStatus>();
                a.CreateMap<TranslationProgressStatusDto, TranslationProgressStatus>();
                a.CreateMap<TranslationQualityDto, TranslationQuality>();
                a.CreateMap<UserDocumentTypeDto, UserDocumentType>();
                a.CreateMap<UserRoleTypeDto, UserRoleType>();
                a.CreateMap<WorkingTypeDto, WorkingType>();
                a.CreateMap<TongueDto, Tongue>();
                a.CreateMap<OrderTargetLanguageDto, OrderTargetLanguage>();

                a.CreateMap<DocumentDto, Document>();
                a.CreateMap<TranslationDocumentPartDto, TranslationDocumentPart>();
                a.CreateMap<GeneralDocumentDto, GeneralDocument>();
                a.CreateMap<TranslationDocumentDto, TranslationDocument>();
                a.CreateMap<UserDocumentDto, UserDocument>();

                a.CreateMap<CustomerDto, Customer>();
                a.CreateMap<OrderDetailDto, OrderDetail>();
                a.CreateMap<OrderDto, Order>();
                a.CreateMap<PriceListDto, PriceList>();

                a.CreateMap<RateItemDto, RateItem>();
                a.CreateMap<TechnologyKnowledgeDto, TechnologyKnowledge>();
                a.CreateMap<UserAbilityDto, UserAbility>();
                a.CreateMap<UserContactDto, UserContact>();
                a.CreateMap<UserDto, User>();
                a.CreateMap<UserLanguageDto, UserLanguage>();
                a.CreateMap<UserPaymentDto, UserPayment>();
                a.CreateMap<UserRateDto, UserRate>();
                a.CreateMap<UserRoleDto, UserRole>();
                a.CreateMap<UserScoreDto, UserScore>();
                a.CreateMap<UserScoreTransactionDto, UserScoreTransaction>();

                a.CreateMap<CompanyDocumentTemplateDto, CompanyDocumentTemplate>();
                a.CreateMap<CompanyTerminologyDto, CompanyTerminology>();
                a.CreateMap<SourceTargetLanguageDto, SourceTargetLanguage>();
                a.CreateMap<TerminologyItemDto, TerminologyItem>();
                a.CreateMap<TranslationOperationDto, TranslationOperation>();

                a.CreateMap<DocumentAuditDto, DocumentAudit>();
                a.CreateMap<CampaignItemDto, CampaignItem>();
                a.CreateMap<CompanyPriceOfferDto, CompanyPriceOffer>();

                a.CreateMap<SimultaneousTranslatingOrderDto, SimultaneousTranslatingOrder>();
                a.CreateMap<SimultaneousTranslatingOrderEquipmentDto, SimultaneousTranslatingOrderEquipment>();
                a.CreateMap<SimultaneousTranslatingOrderTranslatorDto, SimultaneousTranslatingOrderTranslator>();
                a.CreateMap<TranslatingOrderDto, TranslatingOrder>();
                a.CreateMap<EquipmentDto, Equipment>();
                a.CreateMap<AccountRegistrationDto, AccountRegistration>();

                //Entity -> Dto

                a.CreateMap<BaseEntity, BaseDto>();
                a.CreateMap<KeyValue, KeyValueDto>();

                a.CreateMap<BankAccount, BankAccountDto>();
                a.CreateMap<BankAccountType, BankAccountTypeDto>();
                a.CreateMap<Capacity, CapacityDto>();
                a.CreateMap<City, CityDto>();
                a.CreateMap<Comment, CommentDto>();
                a.CreateMap<Company, CompanyDto>();
                a.CreateMap<CompanyTerminologyStatus, CompanyTerminologyStatusDto>();
                a.CreateMap<Country, CountryDto>();
                a.CreateMap<Currency, CurrencyDto>();
                a.CreateMap<District, DistrictDto>();
                a.CreateMap<Gender, GenderDto>();
                a.CreateMap<GeneralDocumentType, GeneralDocumentTypeDto>();
                a.CreateMap<Language, LanguageDto>();
                a.CreateMap<MembershipType, MembershipTypeDto>();
                a.CreateMap<Message, MessageDto>();
                a.CreateMap<OrderStatus, OrderStatusDto>();
                a.CreateMap<Score, ScoreDto>();
                a.CreateMap<Specialization, SpecializationDto>();
                a.CreateMap<ServiceType, ServiceTypeDto>();
                a.CreateMap<Software, SoftwareDto>();
                a.CreateMap<Terminology, TerminologyDto>();
                a.CreateMap<TranslationOperationStatus, TranslationOperationStatusDto>();
                a.CreateMap<TranslationProgressStatus, TranslationProgressStatusDto>();
                a.CreateMap<TranslationQuality, TranslationQualityDto>();
                a.CreateMap<UserDocumentType, UserDocumentTypeDto>();
                a.CreateMap<UserRoleType, UserRoleTypeDto>();
                a.CreateMap<WorkingType, WorkingTypeDto>();
                a.CreateMap<Tongue, TongueDto>();
                a.CreateMap<OrderTargetLanguage, OrderTargetLanguageDto>().ForMember(b=>b.Order,b=>b.Ignore());

                a.CreateMap<Document, DocumentDto>();
                a.CreateMap<TranslationDocumentPart, TranslationDocumentPartDto>();
                a.CreateMap<GeneralDocument, GeneralDocumentDto>();
                a.CreateMap<TranslationDocument, TranslationDocumentDto>();
                a.CreateMap<UserDocument, UserDocumentDto>();

                a.CreateMap<Customer, CustomerDto>();
                a.CreateMap<OrderDetail, OrderDetailDto>().ForMember(b => b.Order, b => b.Ignore());
                a.CreateMap<Order, OrderDto>();
                a.CreateMap<PriceList, PriceListDto>();

                a.CreateMap<RateItem, RateItemDto>();
                a.CreateMap<TechnologyKnowledge, TechnologyKnowledgeDto>();
                a.CreateMap<UserAbility, UserAbilityDto>();
                a.CreateMap<UserContact, UserContactDto>();
                a.CreateMap<User, UserDto>();
                a.CreateMap<UserLanguage, UserLanguageDto>();
                a.CreateMap<UserPayment, UserPaymentDto>();
                a.CreateMap<UserRate, UserRateDto>();
                a.CreateMap<UserRole, UserRoleDto>();
                a.CreateMap<UserScore, UserScoreDto>();
                a.CreateMap<UserScoreTransaction, UserScoreTransactionDto>();

                a.CreateMap<CompanyDocumentTemplate, CompanyDocumentTemplateDto>();
                a.CreateMap<CompanyTerminology, CompanyTerminologyDto>();
                a.CreateMap<SourceTargetLanguage, SourceTargetLanguageDto>();
                a.CreateMap<TerminologyItem, TerminologyItemDto>();
                a.CreateMap<TranslationOperation, TranslationOperationDto>();
                //a.CreateMap<Translator, TranslatorDto>();

                a.CreateMap<DocumentAudit, DocumentAuditDto>();
                a.CreateMap<CampaignItem, CampaignItemDto>();
                a.CreateMap<CompanyPriceOffer, CompanyPriceOfferDto>();

                a.CreateMap<SimultaneousTranslatingOrder, SimultaneousTranslatingOrderDto>();
                a.CreateMap<SimultaneousTranslatingOrderEquipment, SimultaneousTranslatingOrderEquipmentDto>();
                a.CreateMap<SimultaneousTranslatingOrderTranslator, SimultaneousTranslatingOrderTranslatorDto>();
                a.CreateMap<TranslatingOrder, TranslatingOrderDto>();
                a.CreateMap<Equipment, EquipmentDto>();
                a.CreateMap<AccountRegistration, AccountRegistrationDto>();

            });

            _mapper = mapperConfiguration.CreateMapper();
        }
        public TTo GetMapDto<TTo, TFrom>(TFrom entity) where TTo : BaseDto where TFrom : BaseEntity {
            return _mapper.Map<TTo>(entity);
        }

        public TTo GetMapEntity<TTo, TFrom>(TFrom entity) where TTo : BaseEntity where TFrom : BaseDto {
            return _mapper.Map<TTo>(entity);
        }
    }
}
