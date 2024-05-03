﻿using Convey.CQRS.Queries;
using Convey.Persistence.MongoDB;
using MiniSpace.Services.Organizations.Application.DTO;
using MiniSpace.Services.Organizations.Application.Queries;
using MiniSpace.Services.Organizations.Infrastructure.Mongo.Documents;

namespace MiniSpace.Services.Organizations.Infrastructure.Mongo.Queries.Handlers
{
    public class GetRootOrganizationsHandler : IQueryHandler<GetRootOrganizations, IEnumerable<OrganizationDto>>
    {
        private readonly IMongoRepository<OrganizationDocument, Guid> _repository;

        public GetRootOrganizationsHandler(IMongoRepository<OrganizationDocument, Guid> repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<OrganizationDto>> HandleAsync(GetRootOrganizations query, CancellationToken cancellationToken)
            => (await _repository.FindAsync(o => o.ParentId == Guid.Empty)).Select(o => o.AsDto());
    }
}