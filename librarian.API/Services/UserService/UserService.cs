using AutoMapper;
using librarian.API.Models;
using librarian.API.Dtos.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using Microsoft.EntityFrameworkCore;
using librarian.API.Dtos.UserBook;

namespace librarian.API.Services.UserService
{
    public class UserService : IUserService
    {
        DataContext _context;
        private readonly IMapper _mapper;
        public UserService(IMapper mapper, DataContext context)
        {
            _mapper = mapper;
            _context = context;
        }
        public async Task<ServiceResponse<UserDto>> AddUser(AddUserDto newUser)
        {
            ServiceResponse<UserDto> serviceResponse = new ServiceResponse<UserDto>();
            User user = new User();
            PasswordHashing ph = new PasswordHashing();
            try
            {
                user = _mapper.Map<User>(newUser);
                user.Salt = Encoding.Unicode.GetString(ph.GetSalt());
                user.Hash = Encoding.Unicode.GetString(ph.GetKey(user.Hash, Encoding.Unicode.GetBytes(user.Salt)));
                _context.Users.Add(user);
                _context.SaveChanges();
                serviceResponse.Data = _mapper.Map<UserDto>(user);
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message;
            }
            return serviceResponse;
        }

        public async Task<ServiceResponse<GetUserDto>> Login(LoginDto login)
        {
            ServiceResponse<GetUserDto> serviceResponse = new ServiceResponse<GetUserDto>();
            PasswordHashing ph = new PasswordHashing();
            User entity = new User();
            try
            {
                entity = _context.Users.First(u => u.Username == login.Username);
                if (ph.IsValid(login.Hash, entity.Salt, entity.Hash))
                {
                    serviceResponse.Data = _mapper.Map<GetUserDto>(_context.Users.Include(u => u.UserBooks).FirstOrDefault(u => u.Id == entity.Id));
                }
                else throw new Exception("");
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message += (ex.InnerException != null) ? ex.InnerException.Message : ex.Message;
                if (serviceResponse.Message == "") serviceResponse.Message = "Niepoprawny login lub hasło.";
            }
            return serviceResponse;
        }

        public async Task<ServiceResponse<UserDto>> PasswordChange(PasswordChangeDto pwdChange)
        {
            ServiceResponse<UserDto> serviceResponse = new ServiceResponse<UserDto>();
            PasswordHashing ph = new PasswordHashing();
            User entity = new User();
            try
            {
                entity = _context.Users.First(u => u.Username == pwdChange.Username);
                if (ph.IsValid(pwdChange.CurrentPassword, entity.Salt, entity.Hash))
                {
                    entity.Salt = Encoding.Unicode.GetString(ph.GetSalt());
                    entity.Hash = Encoding.Unicode.GetString(ph.GetKey(pwdChange.NewPassword, Encoding.Unicode.GetBytes(entity.Salt)));
                    _context.SaveChanges();
                    serviceResponse.Data = _mapper.Map<UserDto>(entity);
                }
                else throw new Exception("Wrong current password!");
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message;
            }
            return serviceResponse;
        }

        public async Task<ServiceResponse<GetUserDto>> UpdateUser(UpdateUserDto updateCharacter)
        {
            ServiceResponse<GetUserDto> serviceResponse = new ServiceResponse<GetUserDto>();
            try
            {
                User user = _context.Users.FirstOrDefault(u => u.Id == updateCharacter.Id);
                user.Username = updateCharacter.Username;
                user.Email = updateCharacter.Email;
                serviceResponse.Data = _mapper.Map<GetUserDto>(user);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message;
            }
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<PlainUserBookDto>>> UpdateUserBookList(List<PlainUserBookDto> ubList)
        {
            ServiceResponse<List<PlainUserBookDto>> serviceResponse = new ServiceResponse<List<PlainUserBookDto>>();
            try
            {
                var currentUserBookList = _context.UserBooks
                    .Where(ub => ub.UserId == ubList[0].UserId)
                    .ToList();
                _context.UserBooks.RemoveRange(currentUserBookList);
                foreach(var userbook in ubList)
                {
                    _context.UserBooks.Add(_mapper.Map<UserBook>(userbook));
                }
                _context.SaveChanges();

                serviceResponse.Data = _context.UserBooks
                    .Where(ub => ub.UserId == ubList[0].UserId)
                    .Select(ub => _mapper.Map<PlainUserBookDto>(ub))
                    .ToList();               
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message;
            }
            return serviceResponse;
        }
    }
}
