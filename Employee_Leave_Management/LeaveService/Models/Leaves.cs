namespace LeaveService
{
    public class Leaves
    {
        public Guid LeaveId { get; set; }

        public required ReasonType Reason { get; set; }

        public required DateTime StartDate { get; set; }

        public required DateTime EndDate { get; set; }

        public required StatusType Status { get; set; }
    }

    public enum ReasonType
    {
        SickLeave,
        CasualLeave,
        MaternityLeave,
        PaternityLeave,
        VacationLeave,
        Other
    }

    public enum StatusType
    {
        Pending,
        Approved,
        Rejected
    }
}
