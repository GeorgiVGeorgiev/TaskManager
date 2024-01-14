namespace TaskManager.Common
{
    public static class EntityValidationConstantView
    {
        public static class PerosanlFileFormModel
        {
            public const int NameMinLength = 3;
            public const int NameMaxLength = 55;

            public const int UrlMinLength = 3;
            public const int UrlMaxLength = 2048;

            public const string PriceMaxLength = "1000000";
            public const string PriceMinLength = "0";
        }
    }
}
