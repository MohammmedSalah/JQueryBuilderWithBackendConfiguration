using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JQueryBuilderWithBackendConfiguration.Models
{
    public class StudentFilterFlat
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int GradeId { get; set; }
        public string SectionName { get; set; }//outer property
    }

}