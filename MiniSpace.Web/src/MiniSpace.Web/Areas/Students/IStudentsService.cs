using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MiniSpace.Web.DTO;
using MiniSpace.Web.HttpClients;

namespace MiniSpace.Web.Areas.Students
{
    public interface IStudentsService
    {
        Task<StudentDto> GetStudentAsync(Guid studentId);
        Task UpdateStudentAsync(Guid studentId, string profileImage, string description, bool emailNotifications);
        Task<HttpResponse<object>> CompleteStudentRegistrationAsync(Guid studentId, string profileImage,
            string description, DateTime dateOfBirth, bool emailNotifications);
    }
}