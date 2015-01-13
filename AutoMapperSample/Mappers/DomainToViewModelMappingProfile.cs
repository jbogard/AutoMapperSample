namespace AutoMapperSample.Mappers
{
    using System;

    using AutoMapper;

    using AutoMapperSample.Service;
    using AutoMapperSample.ViewModels;

    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get
            {
                return "DomainToViewModelMappingProfile";
            }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<DateTime, string>().ConvertUsing<DateTimeConverter>();
            Mapper.CreateMap<ApplicationSettingsDto, ApplicationSettingsViewModel>()
                .ForMember(dest => dest.ReportDateString, opt => opt.MapFrom(src => src.ReportDate));
        }
    }
}