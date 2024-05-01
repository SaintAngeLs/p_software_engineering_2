using Convey.CQRS.Queries;
using MiniSpace.Services.Organizations.Application.DTO;

namespace MiniSpace.Services.Organizations.Application.Queries
{
    public class GetOrganizerOrganizations: IQuery<IEnumerable<OrganizationDto>>
    {
        public Guid OrganizerId { get; set; }
    }
}
