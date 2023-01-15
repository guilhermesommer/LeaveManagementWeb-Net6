using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Web.Models
{
    public class LeaveRequestVM
    {
        public int Id { get; set; }

        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }

        [Display(Name = "End Date")]
        public DateTime EndDate { get; set; }

        [Display(Name = "Leave Type")]
        public LeaveTypeVM LeaveType { get; set; }

        [Display(Name = "Date Requested")]
        public DateTime DateRequested { get; set; }

        /*[Display(Name = "Request Comments")]
        public string? RequestComments { get; set; }*/

        public bool? Approved { get; set; }

        public string ApprovedText
        {
            get
            {
                if (Cancelled)
                {
                    return "Cancelled";
                }
                else if (Approved == null || !Approved.HasValue)
                {
                    return "Pending";
                }
                else if (Approved.HasValue && Approved.Value)
                {
                    return "Approved";
                }
                else if (Approved.HasValue && !Approved.Value)
                {
                    return "Rejected";
                }
                else
                {
                    return string.Empty;
                }
            }
        }

        public string ApprovedBadgeClass
        {
            get
            {
                if (Cancelled)
                {
                    return "badge bg-dark";
                }
                else if (Approved == null || !Approved.HasValue)
                {
                    return "badge bg-warning";
                }
                else if (Approved.HasValue && Approved.Value)
                {
                    return "badge bg-success";
                }
                else if (Approved.HasValue && !Approved.Value)
                {
                    return "badge bg-danger";
                }
                else
                {
                    return string.Empty;
                }
            }
        }

        public bool Cancelled { get; set; }

        public string RequestingEmployeeId { get; set; }

        public EmployeeListVM Employee { get; set; }
    }
}
