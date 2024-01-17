using Microsoft.AspNetCore.Mvc;
using Register.Manegement.Application.Interfaces.UserRegister;
using Register.Manegement.Application.Requests.UserRegister;
using Register.Manegement.Application.Responses.UserRegister;

namespace Register.Manegement.Controllers.v1
{
    [ApiController]
    [Route("[controller]")]
    public class UserRegisterController
    {
        private readonly ILogger<UserRegisterController> _logger;
        private readonly IUserRegisterApplication _Application;
        
        public UserRegisterController(ILogger<UserRegisterController> logger
            , IUserRegisterApplication application)
        {
            _logger = logger;
            _Application = application;
        }

        [HttpPost]
        [ProducesResponseType<UserRegisterPostResponse>(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<UserRegisterPostResponse> Post(UserRegisterPostRequest request)
        {
            _logger.LogInformation($"process next request: {request}");
            var result = _Application.Post(request);
            return new JsonResult(result);
        }
    }
}
