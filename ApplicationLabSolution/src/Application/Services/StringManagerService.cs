using Microsoft.Extensions.Configuration;

namespace Application.UseCases
{
    public class StringManagerService : IStringManagerService
    {
        private string _string;

        public StringManagerService(IConfiguration configuration)
        {
            _string = configuration.GetSection("StringManagerService:Value").Value ?? "Empty value";
        }

        public string GetString()
        {
            return _string;
        }

        public void SetString(string value)
        {
            _string = value;
        }
    }
}
