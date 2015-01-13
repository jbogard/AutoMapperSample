namespace AutoMapperSample.Mappers
{
    using System;

    using AutoMapper;

    using AutoMapperSample.Service;

    public class DateTimeConverter : ITypeConverter<DateTime, string>
    {
        private IApplicationSettingsService applicationSettingsService;

        public DateTimeConverter(IApplicationSettingsService applicationSettingsService)
        {
            this.applicationSettingsService = applicationSettingsService;
        }

        public string Convert(ResolutionContext context)
        {
            return context.IsSourceValueNull ? string.Empty : ((DateTime)context.SourceValue).ToString(this.applicationSettingsService.DateTimeFormatString);
        }
    }
}