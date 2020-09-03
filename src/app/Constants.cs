namespace CSE.Helium
{
    /// <summary>
    /// String constants
    /// </summary>
    public sealed class Constants
    {
        public const string SwaggerTitle = "Helium";
        public const string SwaggerPath = "/swagger/helium.json";

        public const string KeyVaultName = "KEYVAULT_NAME";
        public const string AuthType = "AUTH_TYPE";
        public const string LogLevel = "LOG_LEVEL";

        public const string CosmosCollection = "CosmosCollection";
        public const string CosmosDatabase = "CosmosDatabase";
        public const string CosmosKey = "CosmosKey";
        public const string CosmosUrl = "CosmosUrl";

        public const string AppInsightsKey = "AppInsightsKey";
        public const string NewKeyLoadedMetric = "newKeyLoaded";

        // if port is changed, also update value in the Dockerfiles
        public const string Port = "8080";

        public const int KeyVaultChangeCheckSeconds = 30;

        public const string GenresControllerException = "GenresControllerException";
        public const string HealthzControllerException = "HealthzControllerException";

        public const int DefaultPageSize = 100;
        public const int MaxPageSize = 1000;

        public const int HealthzCacheDuration = 60;
        public const int GracefulShutdownTimeout = 10;
    }
    public enum AuthenticationType { MI, CLI, VS }
}
