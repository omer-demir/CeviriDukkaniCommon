using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using Tangent.CeviriDukkani.Data.Model;
using Tangent.CeviriDukkani.Domain.Entities.Common;
using Tangent.CeviriDukkani.Domain.Entities.System;

namespace Tangent.CeviriDukkani.Data.Migrations {
    internal sealed class Configuration : DbMigrationsConfiguration<Model.CeviriDukkaniModel> {
        public Configuration() {
            AutomaticMigrationsEnabled = false;
            AutomaticMigrationDataLossAllowed = false;
        }

        protected override void Seed(CeviriDukkaniModel context) {
            var country1 = new Country { Name = "Türkiye", Code = "TUR" };
            context.Countries.AddOrUpdate(x => x.Code, country1);

            var city = new City { Name = "Ýstanbul", Code = "Ist", CountryId = country1.Id };
            context.Cities.AddOrUpdate(x => x.Code, city);

            var d1 = new District {
                Id = 1,
                Name = "Kadýköy",
                CityId = city.Id
            };
            var d2 = new District {
                Id = 2,
                Name = "Acýbadem",
                CityId = city.Id
            };
            var d3 = new District {
                Id = 3,
                Name = "Bostancý",
                CityId = city.Id
            };
            context.Districts.AddOrUpdate(a => a.Name, d1, d2, d3);

            var bankAccType1 = new BankAccountType { Name = "Turkish Bank" ,Id=1};
            var bankAccType2 = new BankAccountType { Name = "Other Country Bank", Id = 2};
            var bankAccType3 = new BankAccountType { Name = "PayPal", Id = 3 };
            context.BankAccountTypes.AddOrUpdate(a => a.Name, bankAccType1, bankAccType2, bankAccType3);

            var lang1 = new Language { Name = "Ýngilizce", Id = 1 };
            var lang2 = new Language { Name = "Türkçe", Id = 2};
            context.Languages.AddOrUpdate(a => a.Name, lang1, lang2);

            var term1 = new Terminology { Name = "Genel" };
            var term2 = new Terminology { Name = "Saðlýk" };
            context.Terminologies.AddOrUpdate(a => a.Name, term2, term1);

            var spec1 = new Specialization { Name = "Genel" };
            var spec2 = new Specialization { Name = "Saðlýk" };
            context.Specializations.AddOrUpdate(a => a.Name, spec1, spec2);

            var tongue1 = new Tongue { Name = "Ýngilizce", Id = 1 };
            var tongue2 = new Tongue { Name = "Türkçe", Id = 2 };
            context.Tongues.AddOrUpdate(a => a.Name, tongue1, tongue2);

            var gen1 = new Gender { Name = "Erkek" };
            var gen2 = new Gender { Name = "Bayan" };
            context.Genders.AddOrUpdate(a => a.Name, gen1, gen2);

            var worktype1 = new WorkingType { Name = "Per character", Id = 1 };
            var worktype2 = new WorkingType { Name = "Per word", Id = 2 };
            context.WorkingTypes.AddOrUpdate(a => a.Name, worktype1, worktype2);

            var curr1 = new Currency { Name = "TRY", Id = 1 };
            var curr2 = new Currency { Name = "USD", Id = 2 };
            context.Currencies.AddOrUpdate(a => a.Name, curr1, curr2);


            var serviceType = new ServiceType { Name = "Translating", Id = 1 };
            var serviceType2 = new ServiceType { Name = "QA", Id = 2 };
            var serviceType3 = new ServiceType { Name = "Review", Id = 3 };
            context.ServiceTypes.AddOrUpdate(a => a.Name, serviceType, serviceType2, serviceType3);

            var userRoleType1 = new UserRoleType { Name = "Admin", Id = 3};
            var userRoleType2 = new UserRoleType { Name = "Translator", Id = 1};
            var userRoleType3 = new UserRoleType { Name = "Editor", Id = 2};
            var userRoleType4 = new UserRoleType { Name = "Proof Reader", Id = 4 };
            var userRoleType5 = new UserRoleType { Name = "Freelance Translator", Id = 5 };
            context.UserRoleTypes.AddOrUpdate(a => a.Name, userRoleType1, userRoleType2, userRoleType3, userRoleType4, userRoleType5);


            var translationOpStatus1 = new TranslationOperationStatus {
                Name = "Bid"
            };
            var translationOpStatus2 = new TranslationOperationStatus {
                Name = "Withdraw"
            };
            var translationOpStatus3 = new TranslationOperationStatus {
                Name = "Accepted"
            };
            context.TranslationOperationStatuses.AddOrUpdate(a => a.Name, translationOpStatus1, translationOpStatus2, translationOpStatus3);

            var translationProgStatus = new TranslationProgressStatus {
                Name = "Open"
            };
            var translationProgStatus1 = new TranslationProgressStatus {
                Name = "Translator Started"
            };
            var translationProgStatus2 = new TranslationProgressStatus {
                Name = "Translator In Progress"
            };
            var translationProgStatus3 = new TranslationProgressStatus {
                Name = "Translator Done"
            };
            var translationProgStatus4 = new TranslationProgressStatus {
                Name = "Editor Started"
            };
            var translationProgStatus5 = new TranslationProgressStatus {
                Name = "Editor In Progress"
            };
            var translationProgStatus6 = new TranslationProgressStatus {
                Name = "Editor Done"
            };
            var translationProgStatus7 = new TranslationProgressStatus {
                Name = "Proof Reader Started"
            };
            var translationProgStatus8 = new TranslationProgressStatus {
                Name = "Proof Reader In Progress"
            };
            var translationProgStatus9 = new TranslationProgressStatus {
                Name = "Proof Reader Done"
            };
            var translationProgStatus10 = new TranslationProgressStatus {
                Name = "Closed"
            };
            context.TranslationProgressStatuses.AddOrUpdate(a => a.Name, translationProgStatus1, translationProgStatus2, translationProgStatus3, translationProgStatus4, translationProgStatus5, translationProgStatus6, translationProgStatus7,
                translationProgStatus8, translationProgStatus9, translationProgStatus10, translationProgStatus
                );

            var translationQuality1 = new TranslationQuality {
                Name = "Standard"
            };
            var translationQuality2 = new TranslationQuality {
                Name = "Premium"
            };
            var translationQuality3 = new TranslationQuality {
                Name = "Platinium"
            };
            context.TranslationQualities.AddOrUpdate(a => a.Name, translationQuality1, translationQuality2, translationQuality3);

            var membershipType1 = new MembershipType {
                Name = "Personal"
            };
            var membershipType2 = new MembershipType {
                Name = "Corporate"
            };
            context.MembershipTypes.AddOrUpdate(a => a.Name, membershipType1, membershipType2);


            var companyTerm1 = new CompanyTerminologyStatus {
                Name = "Ready To Use"
            };
            var companyTerm2 = new CompanyTerminologyStatus {
                Name = "Requested revision from coordinator"
            };
            var companyTerm3 = new CompanyTerminologyStatus {
                Name = "Revised by Coordinator"
            };
            var companyTerm4 = new CompanyTerminologyStatus {
                Name = "Requested revision from client"
            };
            var companyTerm5 = new CompanyTerminologyStatus {
                Name = "Revised by client"
            };
            context.CompanyTerminologyStatuses.AddOrUpdate(a => a.Name, companyTerm1, companyTerm2, companyTerm3, companyTerm4, companyTerm5);

            var orderSta1 = new OrderStatus { Name = "Created" };
            var orderSta2 = new OrderStatus { Name = "Approved" };
            var orderSta3 = new OrderStatus { Name = "Rejected" };
            var orderSta4 = new OrderStatus { Name = "Revision Needed" };
            var orderSta5 = new OrderStatus { Name = "In Progress" };
            var orderSta6 = new OrderStatus { Name = "Ready to deliver" };
            var orderSta7 = new OrderStatus { Name = "Payment retrieved" };
            var orderSta8 = new OrderStatus { Name = "Delivered" };
            context.OrderStatuses.AddOrUpdate(a => a.Name, orderSta1, orderSta2, orderSta3, orderSta4, orderSta5, orderSta6, orderSta7, orderSta8);

            var score1 = new Score { Name = "Poor" };
            var score2 = new Score { Name = "Decent" };
            var score3 = new Score { Name = "Average" };
            var score4 = new Score { Name = "Good" };
            var score5 = new Score { Name = "Excellent" };
            context.Scores.AddOrUpdate(a => a.Name, score1, score2, score3, score4, score5);


            context.Users.AddOrUpdate(a => a.Email,
                new User {
                    Name = "Ahmet",
                    BirthDate = DateTime.Now,
                    Email = "a@a.com",
                    Gender = gen1,
                    MobilePhone = "",
                    Password = "1",
                    PasswordRetryCount = 0,
                    SurName = "Açýk",
                    UserAbility = new UserAbility {
                        BilingualTongueId = tongue2.Id,
                        Capacity = new Capacity {
                            ProofReading = 100,
                            Translation = 200,
                            Reviews = 150
                        },
                        MainClients = "YOK",
                        MotherTongueId = tongue1.Id,
                        Qualifications = "YOK",
                        QualityEnsureDescription = "YOK",
                        Specializations = new List<Specialization> {
                            spec1,spec2
                        },
                        TechnologyKnowledges = new List<TechnologyKnowledge> {
                            new TechnologyKnowledge {
                                OperatingSystem = "Windows",
                                Rating = 1,
                                Software = new Software {
                                    Name = "Office",
                                    Description = "MS Office"
                                },
                                SoftwareVersion = "2012"
                            },
                            new TechnologyKnowledge {
                                OperatingSystem = "Windows",
                                Rating = 1,
                                Software = new Software {
                                    Name = "Powerpoint",
                                    Description = "MS Powerpoint"
                                },
                                SoftwareVersion = "2012"
                            }
                        },
                        YearsOfExperience = 5
                    },
                    UserContact = new UserContact {
                        Address = "IST",
                        AlternativeEmail = "b@b.com",
                        DistrictId = d1.Id,
                        PostalCode = "34567"
                    },
                    UserPayment = new UserPayment {
                        BankAccount = new BankAccount {
                            AccountHolderFullName = "YOK",
                            BankAccountTypeId = bankAccType1.Id,
                            BankName = "YOK",
                            IBAN = "11"
                        },
                        CurrencyId = curr1.Id,
                        MinimumChargeAmount = 1.1M,
                        VatTaxNo = "",
                        WorkingTypeId = worktype1.Id
                    },
                    UserRate = new UserRate {
                        DtpRate = 1.1M,
                        GlossaryCreationRate = 1.1M,
                        LinguisticTestingRate = 1.1M,
                        ReviewLqaRate = 1.1M,
                        ReviewSmeRate = 1.1M,
                        TerminologyExtractionRate = 1.1M,
                        TranslationMemoryManagementRate = 1.1M,
                        RateItems = new List<RateItem> {
                            new RateItem {
                                Price = 1.1M,
                                ServiceTypeId = serviceType.Id,
                                SourceLanguageId = lang1.Id,
                                TargetLanguageId = lang2.Id,

                            }
                        }
                    },
                    UserRoles = new List<UserRole> {
                        new UserRole {
                            UserRoleTypeId =userRoleType2.Id
                        },
                        new UserRole {
                            UserRoleTypeId =userRoleType3.Id
                        },
                    }
                },
                new User {
                    Name = "Emir",
                    BirthDate = DateTime.Now,
                    Email = "e@e.com",
                    Gender = gen2,
                    MobilePhone = "",
                    Password = "1",
                    PasswordRetryCount = 0,
                    SurName = "Çok",
                    UserContact = new UserContact {
                        Address = "IST",
                        AlternativeEmail = "b@b.com",
                        DistrictId = d2.Id,
                        PostalCode = "34567"
                    },
                    UserRoles = new List<UserRole> {
                        new UserRole {
                            UserRoleTypeId =userRoleType1.Id
                        },
                    }
                },
                new User {
                    Name = "Sülü",
                    BirthDate = DateTime.Now,
                    Email = "s@s.com",
                    Gender = gen1,
                    MobilePhone = "",
                    Password = "1",
                    PasswordRetryCount = 0,
                    SurName = "Doðan",
                    UserAbility = new UserAbility {
                        BilingualTongueId = tongue1.Id,
                        Capacity = new Capacity {
                            ProofReading = 300,
                            Translation = 700,
                            Reviews = 450
                        },
                        MainClients = "YOK",
                        MotherTongueId = tongue2.Id,
                        Qualifications = "YOK",
                        QualityEnsureDescription = "YOK",
                        Specializations = new List<Specialization> {
                            spec1
                        },
                        TechnologyKnowledges = new List<TechnologyKnowledge> {
                            new TechnologyKnowledge {
                                OperatingSystem = "Windows",
                                Rating = 1,
                                Software = new Software {
                                    Name = "Partagas",
                                    Description = "Partagas"
                                },
                                SoftwareVersion = "2012"
                            }
                        },
                        YearsOfExperience = 1
                    },
                    UserContact = new UserContact {
                        Address = "IST",
                        AlternativeEmail = "b@b.com",
                        DistrictId = d3.Id,
                        PostalCode = "34567"
                    },
                    UserPayment = new UserPayment {
                        BankAccount = new BankAccount {
                            AccountHolderFullName = "YOK",
                            BankAccountTypeId = bankAccType2.Id,
                            BankName = "YOK",
                            IBAN = "11"
                        },
                        CurrencyId = curr2.Id,
                        MinimumChargeAmount = 1.1M,
                        VatTaxNo = "",
                        WorkingTypeId = worktype2.Id
                    },
                    UserRate = new UserRate {
                        DtpRate = 1.1M,
                        GlossaryCreationRate = 1.1M,
                        LinguisticTestingRate = 1.1M,
                        ReviewLqaRate = 1.1M,
                        ReviewSmeRate = 1.1M,
                        TerminologyExtractionRate = 1.1M,
                        TranslationMemoryManagementRate = 1.1M,
                        RateItems = new List<RateItem> {
                            new RateItem {
                                Price = 1.1M,
                                ServiceTypeId = serviceType2.Id,
                                SourceLanguageId = lang1.Id,
                                TargetLanguageId = lang2.Id,

                            }
                        }
                    },
                    UserRoles = new List<UserRole> {
                        new UserRole {
                            UserRoleTypeId = userRoleType4.Id
                        },
                        new UserRole {
                            UserRoleTypeId = userRoleType5.Id
                        },
                    }
                });



        }
    }
}
