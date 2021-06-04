using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TQL_PrjMgmtWebApi.Models {
    public class Project {
        public int Id { get; set; }
        public string Description { get; set; }
        public int EstimateInDays { get; set; } = 1;
        public DateTime Deadline { get; set; } = DateTime.Now.AddDays(1);
    }
}
