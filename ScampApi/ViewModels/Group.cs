﻿using System.Collections.Generic;

namespace ScampApi.ViewModels
{
    public class Group
    {
        public string GroupId { get; set; }
        public string Name { get; set; }
        public IEnumerable<ScampResourceSummary> Resources { get; set; }
        public IEnumerable<GroupTemplateSummary> Templates { get; set; }
        public IEnumerable<UserSummary> Admins { get; set; }
        public IEnumerable<UserSummary> Members { get; set; }
    }
}
