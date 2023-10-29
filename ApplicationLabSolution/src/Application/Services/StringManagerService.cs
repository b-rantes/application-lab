namespace Application.UseCases
{
    public class StringManagerService : IStringManagerService
    {
        private string _string;

        public StringManagerService()
        {
            _string = "HelloWorld";
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
