namespace Tangent.CeviriDukkani.Domain.Dto.Enums
{
    public enum UserRoleTypeEnum
    {
        Translator = 1 ,
        Editor,
        Admin,
        ProofReader,
        FreelanceTranslator
    }

    public enum GenderEnum {
        Male = 1,
        Female 
    }

    public enum TranslationOperationStatusEnum {
        Bid = 1,
        Withdraw,
        Accepted
    }

    public enum TranslationProgressStatusEnum {
        TranslatorStarted = 1,
        TranslatorInProgress,
        TranslatorDone,
        EditorStarted,
        EditorInProgress,
        EditorDone,
        ProofReaderStarted,
        ProofReaderInProgress,
        ProofReaderDone,
        Closed,
        Open
    }

    public enum TranslationQualityEnum {
        Standard = 1,
        Premium,
        Platinium
    }

    public enum MembershipTypeEnum {
        Personal = 1,
        Corporate
    }

    public enum CompanyTerminologyStatusEnum {
        ReadyToUse=1,
        RequestedRevisionFromCoordinator,
        RevisedByCoordinator,
        RequestedRevisionFromClient,
        RevisedByClient
    }

    public enum OrderStatusEnum {
        Created=1,
        Approved,
        Rejected,
        RevisionNeeded,
        InProcess,
        ReadyToDeliver,
        PaymentRetrieved,
        Delivered
    }

    public enum ScoreEnum {
        Poor=1,
        Decent,
        Average,
        Good,
        Excellent
    }

    public enum MailStatusTypeEnum {
        Waiting = 0,        
        Sent = 1,
        Progress = 2,
        Error = 3
    }

    public enum MailSenderTypeEnum {
        System = 1,
        User = 2,
        Advertisement = 3
    }
}
