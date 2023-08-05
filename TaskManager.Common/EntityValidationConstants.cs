namespace TaskManager.Common
{
    public static class EntityValidationConstants
    {
        public static class User
        {
            public const int FirstNameMaxLength = 15;
            public const int FirstNameMinLength = 3;

            public const int LastNameMaxLength = 15;
            public const int LastNameMinLength = 3;
        }

        public static class Client
        {
            public const int ClientNameMaxLength = 50;
            public const int ClientNameMinLength = 3;

            public const int PredstavitelNameMaxLength = 30;
            public const int PredstavitelNameMinLength = 3;

            public const int PhoneNumberMaxLength = 15;
            public const int PhoneNumberMinLength = 7;
        }

        public static class Worker
        {
            public const int PositionMaxLength = 15;
            public const int PositionMinLength = 1;

            public const int PhoneNumberMaxLength = 15;
            public const int PhoneNumberMinLength = 7;
        }
        public static class Comentar
        {
            public const int DescriptionMaxLength = 2500;
            public const int DescriptionMinLength = 1;

        }
    }
}