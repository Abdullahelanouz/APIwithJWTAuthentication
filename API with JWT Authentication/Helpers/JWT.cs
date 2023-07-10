namespace API_with_JWT_Authentication.Helpers
{
    public class JWT
    {
        public string Key { get; set; }
        public string Issuer { get; set; }
        public int Audience { get; set; }
        public int DurationInDays { get; set; }
    }
}
