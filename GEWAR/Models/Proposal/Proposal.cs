using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace GEWAR.Models
{
    public class Proposal : BaseModel
    {
        public enum StatusEnum
        {
            Pending,
            Accepted,
            Rejected
        }

        public int RequestID { get; set; }
        public int DesignerID { get; set; }
        public string OfferDetails { get; set; }
        public decimal? PriceEstimate { get; set; }
        public string Status { get; set; }
        public DateTime CreatedDate { get; set; }

        public static bool IsValidStatus(string status)
        {
            return Enum.TryParse<StatusEnum>(status, true, out var result) &&
                   Enum.IsDefined(typeof(StatusEnum), result);
        }
    }
}