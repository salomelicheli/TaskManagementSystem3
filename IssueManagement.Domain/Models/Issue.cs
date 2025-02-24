﻿using IssueManagement.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueManagement.Domain.Models
{
    public class Issue
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int? UserId { get; set; }
        public User? AssignedUser { get; set; }
        //public PriorityTypes Priority { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? CompletionDate { get; set; }
        public DateTime? CreatedAt { get; set; }
        //public StatusTypes? Status { get; set; }
        public int? PriorityID { get; set; }
        public Priority? Priority { get; set; }
        public int? StatusId { get; set; }
        public Status? Status { get; set; }
    }
}
