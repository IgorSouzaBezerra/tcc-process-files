using System;

namespace ProcessFile.API.Domain.Entities
{
    public class JobEvent : BaseEntity
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public JobStatus JobStatus { get; set; }
    }
}
