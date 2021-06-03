namespace API
{
    public class Appsettings
    {
        public string ASPNETCORE_ENVIRONMENT { get; set; }
        public ConnectionStrings ConnectionStrings { get; set; }
        public AuthorizationSettings Authorization { get; set; }
    }

    public class ConnectionStrings
    {
        public string DbConnection { get; set; }
    }

    public class AuthorizationSettings
    {
        public string JwtKey { get; set; }
        public string Issuer { get; set; }
        public string Audience { get; set; }
        public int ExpirationInSeconds { get; set; }
    }
}