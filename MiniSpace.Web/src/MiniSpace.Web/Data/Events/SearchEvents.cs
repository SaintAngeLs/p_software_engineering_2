﻿using System;
using MiniSpace.Web.DTO.Wrappers;

namespace MiniSpace.Web.DTO.Data.Events
{
    public class SearchEvents
    {
        public string Name { get; set; }
        public string Organizer { get; set; }
        public string DateFrom { get; set; }
        public string DateTo { get; set; }
        public PageableDto Pageable { get; set; }
        
        public SearchEvents(string name, string organizer, string dateFrom, string dateTo, PageableDto pageable)
        {
            Name = name;
            Organizer = organizer;
            DateFrom = dateFrom;
            DateTo = dateTo;
            Pageable = pageable;
        }
    }
}