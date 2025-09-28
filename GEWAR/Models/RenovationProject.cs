using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace GEWAR.Models
    {
        public class RenovationProject
        {
            public enum ProjectStatusEnum
            {
                Estimated,
                InProgress,
                Completed
            }

            public int ProjectID { get; set; }
            public int UserID { get; set; }
            public int PropertyID { get; set; }
            public decimal? EstimatedCost { get; set; }
            public decimal? EstimatedProfit { get; set; }
            public string ProjectStatus { get; set; }
            public DateTime? StartDate { get; set; }
            public DateTime? EndDate { get; set; }
            public decimal? RenovationCosts { get; set; }

            public static bool IsValidProjectStatus(string status)
            {
                return Enum.TryParse<ProjectStatusEnum>(status, true, out var result) &&
                       Enum.IsDefined(typeof(ProjectStatusEnum), result);
            }
        }
    }


