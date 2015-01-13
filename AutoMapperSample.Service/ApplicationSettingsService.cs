namespace AutoMapperSample.Service
{
    public class ApplicationSettingsService : IApplicationSettingsService
    {
        public string DateTimeFormatString
        {
            get
            {
                return "dd/MMM/yyyy";
            }
        }
    }
}