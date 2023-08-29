using AutoMapper;
using Employees_Application.DataAccess.Repository.IRepository;
using Employees_Application.Models;
using Employees_Application.Service.DTO;
using Employees_Application.Service.Services.IService;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Employees_Application.Service.Services
{
    public class AuthService : IAuthService
    {
        private readonly ITokenService _tokenService;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public AuthService(IUnitOfWork unitOfWork, ITokenService tokenService, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _tokenService = tokenService;
            _mapper = mapper;
        }
        public async Task<string> AuthenticationAsync(UserDTO userDTO)
        {
            var userEntity = _mapper.Map<User>(userDTO);
            var user = await _unitOfWork.Users.GetUserByUsernameAsync(userEntity);
            if (user == null)
            {
                throw new ApplicationException("Invalid username or password");
            }
            // return _tokenService.GenerateToken(userEntity);
            return user.UserName;
        }

        public async Task RegisterAsync(UserDTO userDTO)
        {
            var user = _mapper.Map<User>(userDTO);
            await _unitOfWork.Users.AddUserAsync(user);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}