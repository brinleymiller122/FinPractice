using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinPractice.Models
{
    public class Project
    {
        [Key]
        [Required]
        public int ProjectId { get; set; }

        [Required]
        public string ProjectName { get; set; }

        [Required]
        public string ProjectType { get; set; }

      
        public int ProjectRegionalProgram {get;set;}

    
        public int ProjectImpact { get; set; }

        
        public string ProjectPhase { get; set; }

        
        public string ProjectFunctionalityStatus { get; set; }
    }
}
