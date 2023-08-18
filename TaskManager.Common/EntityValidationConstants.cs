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
        public static class Document
        {
            public const int NameMaxLength = 80;
            public const int NameMinLength = 1;

        }
        public static class FrontDescriptionType
        {
            public const int TitleMaxLength = 100;
            public const int TitleMinLength = 1;

            public const int DescriptionMaxLength = 5000;
            public const int DescriptionMinLength = 1;

            public const int ImageUrlMaxLength = 2048;


            public const string PriceMaxLength = "1000000";
            public const string PriceMinLength = "0";

            public const string TermMaxLength = "365";
            public const string TermMinLength = "1";
        }

        public static class Type
        {
            public const int NameMaxLength = 100;
            public const int NameMinLength = 3;
        }

        public static class Request
        {
            #region 
            public const int NameMaxLength = 25;
            public const int NameMinLength = 3;
            #endregion
            #region
            public const int PhoneNumberMaxLength = 15;
            public const int PhoneNumberMinLength = 7;
            #endregion
            #region
            public const int DescriptionMaxLength = 2000;
            public const int DescriptionMinLength = 15;
            #endregion
        }
        public static class Status
        {
            public const int NameMaxLength = 25;
            public const int NameMinLength = 3;
        }

        public static class GeoTask
        {
            public const int AddressMaxLength = 100;
            public const int AddressMinLength = 3;

            public const string PriceMaxLength = "1000000";
            public const string PriceMinLength = "0";

            public const int IdKKKRMaxLength = 50;
            public const int IdKKKRMinLength = 0;

            public const int NoteMaxLength = 300;
            public const int NoteMinLength = 0;

        }
    }
}