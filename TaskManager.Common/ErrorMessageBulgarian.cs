namespace TaskManager.Common
{
    public static class ErrorMessageBulgarian
    {
        public const string NameErrorMessage = "Дължината на името е от {2} до {1} букви.";
        public const string PhoneErrorMessage = "Дължината на телефонния номер е от {2} до {1} букви.";
        public const string TaskDescriptionErrorMessage = "Описанието на задачата е от {2} до {1} букви.";
        public const string DescriptionErrorMessage = "Описанието на задачата е от {2} до {1} букви.";
        public const string TermDaysErrorMessage = "Работните дни на задачата са от {1} до {2} дни.";
        public const string PriceErrorMessage = "Цената варира от {1} до {2} дни.";
        public const string RequiredErrorMessage = "Полето е задължително";

        public const string ErrorIfUserIsNotAdminMessage = "Страницата е предназначена за админа.";
        public const string ErrorIfUserIsNotWorkerMessage = "Страницата е предназначена за работници.";
        public const string GeneralErrorMessage = "Нещо се прецака, опитай пак или се свържи с администратор.";
        public const string ErrorIfUserDontExistMessage = "Този потребител не съществува.";
        public const string ErrorIfClientDontExistMessage = "Този клиент не съществува.";
        public const string ErrorIfYouAreNotCommentarOwnerMessage = "Ти не си писал този коментар защо искаш да го коригираш ?";
        public const string ErrorIfFrontTaskDontExistMessage = "Задачата която се опитваш да коригираш не съществува.";
        public const string ErrorIfTaskDontExistMessage = "Задачата не съществува в базата данни.";
        public const string ErrorIfRequestDontExistMessage = "Задачата не съществува в базата данни.";
        public const string ErrorIfTypeDontExistMessage = "Типът не съществува в базата данни.";
        public const string ErrorIfWorkerTryToSendRequest = "Ти работиш, какви задачи искаш да даваш ?";

        public const string SuccessfullySendRequest = "Успешно изпратихте задачата.";
    }
}
