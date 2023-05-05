using Microsoft.AspNetCore.Mvc;
using System.Net;
using VillaApi.Models;
using VillaAPIDemo.Models.DTO;
using VillaAPIDemo.Repository.IRepository;

namespace VillaAPIDemo.Controllers
{
	[Route("api/UsersAuth")]
	[ApiController]
	public class UsersController : Controller
	{

		private readonly IUserRepository _userRepo;
		protected APIResponse _response;
		public UsersController(IUserRepository userRepo)

		{
			_userRepo = userRepo;
			this._response = new();

		}
		//For login
		[HttpPost("login")]
		public async Task<IActionResult> Login([FromBody] LoginRequestDTO model)
		{
			//if user login is null and string is null then return badrequest and print a message else print response

			var loginResponse = await _userRepo.Login(model);

			if (loginResponse.User == null || string.IsNullOrEmpty(loginResponse.Token))
			{
				_response.StatusCode = HttpStatusCode.BadRequest;
				_response.IsSuccess=false;
				_response.ErrorMessages.Add("Username or password is incorrect");
				return BadRequest(_response);
			}

			_response.StatusCode = HttpStatusCode.OK;
			_response.IsSuccess=true;
			_response.Result=loginResponse;
			return Ok(_response);
		}
		// for Register

		[HttpPost("register")]
		public async Task<IActionResult> Register([FromBody] RegisterationRequestDTO model)
		{
			// if the unique user nme is not valid then it will return badrequest and prints a message
			//if user is null then also it returns badrequest and prints a message
			//if the username is valid then it prints ok and give the response

			bool ifUserNameUnique = _userRepo.IsUniqueUser(model.UserName);


			if (!ifUserNameUnique)
			{
				_response.StatusCode = HttpStatusCode.BadRequest;
				_response.IsSuccess=false;
				_response.ErrorMessages.Add("Username already exists");
				return BadRequest(_response);

			}
			var user = await _userRepo.Register(model);
			  
			    if (user == null)
			{
				_response.StatusCode = HttpStatusCode.BadRequest;
				_response.IsSuccess=false;
				_response.ErrorMessages.Add("Error while registering");
				return BadRequest(_response);
			}
			_response.StatusCode = HttpStatusCode.OK;
			_response.IsSuccess=true;

			return Ok(_response);
		}

	}
}
