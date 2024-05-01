using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MiniSpace.Web.DTO;
using MiniSpace.Web.HttpClients;

namespace MiniSpace.Web.Areas.Friends
{
    public interface IFriendsService
    {
        FriendDto FriendDto { get; }
        Task UpdateFriendDto(Guid friendId);
        void ClearFriendDto();
        Task<FriendDto> GetFriendAsync(Guid friendId);
        Task<IEnumerable<FriendDto>> GetAllFriendsAsync();
        Task<HttpResponse<object>> AddFriendAsync(Guid friendId);
        Task RemoveFriendAsync(Guid friendId);
        Task<IEnumerable<StudentDto>> GetAllStudentsAsync(); 
    }
}