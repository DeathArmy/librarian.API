using librarian.API.Models;
using librarian.API.Dtos.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using librarian.API.Dtos.UserBook;

namespace librarian.API.Services.UserService
{
    public interface IUserService
    {
        public Task<ServiceResponse<UserDto>> AddUser(AddUserDto newUser);
        public Task<ServiceResponse<GetUserDto>> UpdateUser(UpdateUserDto updateCharacter);
        public Task<ServiceResponse<GetUserDto>> Login(LoginDto login);
        public Task<ServiceResponse<UserDto>> PasswordChange(PasswordChangeDto pwdChange);
        public Task<ServiceResponse<List<PlainUserBookDto>>> UpdateUserBookList(List<PlainUserBookDto> ubList);
    }
}
