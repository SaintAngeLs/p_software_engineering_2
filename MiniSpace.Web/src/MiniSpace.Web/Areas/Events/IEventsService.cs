﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using MiniSpace.Web.DTO;
using MiniSpace.Web.DTO.Wrappers;
using MiniSpace.Web.HttpClients;

namespace MiniSpace.Web.Areas.Events
{
    public interface IEventsService
    {
        Task<EventDto> GetEventAsync(Guid eventId);
        Task<PagedResponseDto<IEnumerable<EventDto>>> GetStudentEventsAsync(Guid studentId, int numberOfResults);
        Task<HttpResponse<object>> AddEventAsync(Guid eventId, string name, Guid organizerId, string startDate, string endDate,
            string buildingName, string street, string buildingNumber, string apartmentNumber, string city,
            string zipCode, string description, int capacity, decimal fee, string category, string publishDate);
        Task SignUpToEventAsync(Guid eventId, Guid studentId);
        Task ShowInterestInEventAsync(Guid eventId, Guid studentId);
        Task RateEventAsync(Guid eventId, int rating, Guid studentId);
        Task<HttpResponse<PagedResponseDto<IEnumerable<EventDto>>>> SearchEventsAsync(string name, string organizer, 
            string dateFrom, string dateTo, PageableDto pageable);
    }
}