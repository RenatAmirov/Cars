using System;

namespace TestProject.Data.Entities
{
    public class ReportsEntity : BaseEntity
    {
        public long GarageId { get; set; }

        public virtual GarageEntity Garage { get; set; }

        public string Notes { get; set; }

        public DateTime ReportTimePeriod { get; set; }
    }
}
