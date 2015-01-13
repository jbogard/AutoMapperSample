namespace AutoMapperSample.Controllers
{
    using System;
    using System.Web.Http;

    using AutoMapper;

    using AutoMapperSample.Service;
    using AutoMapperSample.ViewModels;

    public class ApplicationSettingsController : ApiController
    {
        private IApplicationSettingsService applicationSettingsService;

        public ApplicationSettingsController(IApplicationSettingsService applicationSettingsService)
        {
            this.applicationSettingsService = applicationSettingsService;
        }

        public IHttpActionResult Get()
        {
            var applicationSettingsDto = new ApplicationSettingsDto();
            applicationSettingsDto.Id = 1;
            applicationSettingsDto.ReportDate = DateTime.Now;

            var converted = Mapper.Map<ApplicationSettingsDto, ApplicationSettingsViewModel>(applicationSettingsDto);

            return this.Ok(converted);
        }
    }
}