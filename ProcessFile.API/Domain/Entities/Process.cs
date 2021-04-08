using ProcessFile.API.Domain.Enum;
using System;
using System.Collections.Generic;

namespace ProcessFile.API.Domain.Entities
{
    public class Process : BaseEntity
    {
        public DateTime StartDate { get; set; }
        public string Title { get; set; }
        public ProcessStatus ProcesStatus { get; set; }

        public List<Sulamerica> Sulamericas { get; set; }
        public List<Unimed> Unimed { get; set; }
    }
}
