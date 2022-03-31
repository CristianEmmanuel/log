using AutoMapper;
using Login.Helpers;
using Login.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace Login.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class ProvincesController : ControllerBase
    {
        private IProvinceService _provincesService;
        private IMapper _mapper;
        private readonly AppSettings _appSettings;

        public ProvincesController(
            IProvinceService ProvincesService,
            IMapper mapper,
            IOptions<AppSettings> appSettings)
        {
            _provincesService = ProvincesService;
            _mapper = mapper;
            _appSettings = appSettings.Value;
        }

        //[HttpGet("{name}")]
        //public IActionResult GetByName(string name)
        //{
        // var provinces = _provincesService.GetByName(name);
        //  //=> Ok(await _provincesService.GetByName(name));
        //    //var user = _provincesService.GetByName(name);
        //    //var model = _mapper.Map<UserModel>(user);
        //    //return Ok(model);
        //}

    }
}
