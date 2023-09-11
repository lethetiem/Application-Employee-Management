using System.Text;
using System.Text.RegularExpressions;
using AutoMapper;
using Employees_Application.DataAccess.Repository.IRepository;
using Employees_Application.Helpers;
using Employees_Application.Models;
using Employees_Application.Service.DTO;
using Employees_Application.Service.Services.IService;

namespace Employees_Application.Service.Services
{
    public class AuthService : IAuthService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public AuthService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        private static string CheckPasswordStrength(string password)
        {
            StringBuilder sb = new StringBuilder();
            if (password.Length < 8)
            {
                sb.Append("Minimum password length should be 8" + Environment.NewLine);
            }
            if (!(Regex.IsMatch(password, "[a-z]") && Regex.IsMatch(password, "[A-Z]") && Regex.IsMatch(password, "[0-9]")))
            {
                sb.Append("Password should be Alphanumeric" + Environment.NewLine);
            }
            if (!Regex.IsMatch(password, "[<,>,@,!,#,$,%,^,&,*,(,),_,+,\\[,\\],{,},?,:,;,|,',\\,.,/,~,`,-,=]"))
            {
                sb.Append("Password should contain special chars" + Environment.NewLine);
            }
            return sb.ToString();
        }
        public async Task<UserDTO> AuthenticationAsync(UserDTO userDTO)
        {
            var user = await _unitOfWork.Users.AuthenticationAsync(userDTO.UserName);
            if (!PasswordHash.VerifyPassword(userDTO.Password, user.Password))
            {
                throw new ApplicationException("Password is Incorrect!");
            }
            if (user != null)
            {
                return _mapper.Map<UserDTO>(user);
            }
            else
            {
                throw new ApplicationException("User not found");
            }
        }
        public async Task RegisterAsync(UserDTO userDTO)
        {
            var userExists = await _unitOfWork.Users.CheckUserNameExistAsync(userDTO.UserName);
            var emailExists = await _unitOfWork.Users.CheckEmailExistAsync(userDTO.Email);
            var checkPassword = CheckPasswordStrength(userDTO.Password);
            userDTO.Password = PasswordHash.HashPassword(userDTO.Password);
            userDTO.Role = "User";
            userDTO.Token = "";
            if (userExists)
            {
                throw new ApplicationException("Username already exists");
            }
            if (emailExists)
            {
                throw new ApplicationException("Email already exists");
            }
            if (!string.IsNullOrEmpty(checkPassword))
            {
                throw new ApplicationException(checkPassword);
            }
            var userEntity = _mapper.Map<User>(userDTO);
            await _unitOfWork.Users.AddUserAsync(userEntity);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}