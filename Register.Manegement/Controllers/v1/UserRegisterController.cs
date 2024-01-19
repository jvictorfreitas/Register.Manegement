using Microsoft.AspNetCore.Mvc;
using Register.Manegement.Application.Interfaces.UserRegister;
using Register.Manegement.Application.Requests.UserRegister;
using Register.Manegement.Application.Responses.UserRegister;

namespace Register.Manegement.Controllers.v1
{
    [ApiController]
    [Route("[controller]")]
    public class UserRegisterController : ControllerBase
    {
        private readonly IUserRegisterApplication _Application;

        public UserRegisterController(IUserRegisterApplication application)
        {
            _Application = application;
        }

        /// <summary>
        /// Registra um usuário e retorno um login e senha
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType<UserRegisterPostResponse>(StatusCodes.Status201Created)]
        public IActionResult Post(UserRegisterPostRequest request) 
        {
            var result = _Application.Post(request);
            if(result.Success)
                return Ok(result);

            return BadRequest(result);
        }

        /// <summary>
        /// Retorna uma Lista de usuários entre as datas estabelecidas
        /// </summary>
        /// <param name="request"></param>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult Get(UserRegisterGetRequest request
            , [FromHeader] Guid login
            , [FromHeader] Guid password)
        {
            var result = _Application.Get(request,login,password);
            if(result.Success)
                return Ok(result);

            return BadRequest(result);
        }

        [HttpGet("{userLogin}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult Get(Guid userLogin
            , [FromHeader] Guid login
            , [FromHeader] Guid password)
        {
            var result = _Application.Get(userLogin, login, password);
            if (result.Success)
                return Ok(result);

            return BadRequest(result);
        }

        [HttpPut("{userLogin}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult Put(Guid userLogin
            ,UserRegisterPutRequest request
            ,[FromHeader]Guid login
            ,[FromHeader]Guid password)
        {
            var result = _Application.Put(request,userLogin,login,password);
            if (result.Success)
                return Ok(result);

            return BadRequest(result);
        }

        [HttpDelete("{userLogin}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult Delete(Guid userLogin
            ,[FromHeader]Guid login
            ,[FromHeader]Guid password)
        {
            var result = _Application.Get(userLogin, login, password);
            if (result.Success)
                return Ok(result);

            return BadRequest(result);
        }
    }
}
