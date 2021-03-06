﻿namespace Tangent.CeviriDukkani.Domain.Exceptions.ExceptionCodes
{
    public static partial class ExceptionCodes
    {
        public const string NoRelatedData = "200";
        public const string WrongPasswordForUser = "201";
        public const string UserLockedOut = "202";
        public const string UserNotActivated = "203";
        public const string ThereIsAlreadyDefinedUser = "204";
        public const string UserEmailIsNotConfirmed = "205";
        public const string PassiveUser = "205";
        public const string NoOrderWithSpecifiedId = "301";
        public const string EmailCouldntSendToUser = "320";
        public const string UnableRetrieveTranslatorsForOrder = "321";
        public const string UnableRetrieveEditorsForOrder = "322";
        public const string UnableRetrieveProofReadersForOrder = "323";
    }
}
