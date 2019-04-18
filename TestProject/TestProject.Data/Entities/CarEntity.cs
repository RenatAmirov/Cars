using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestProject.Data.Entities
{
    public class CarEntity : BaseEntity
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public string ObjectStatus { get; set; }

        //[ForeignKey(nameof(CarCategoryEntity))]
        //public long CategoryId { get; set; }

        //public virtual CarCategoryEntity Category { get; set; }

        //[ForeignKey(nameof(CarImpactClassesEntity))]
        //public long ImpactClassIndex { get; set; }

        //public virtual CarImpactClassesEntity ImpactClass { get; set; }

        //[ForeignKey(nameof(GarageEntity))]
        public long GarageId { get; set; }

        public virtual GarageEntity Garage { get; set; }

        //[ForeignKey(nameof(CarProbabilityClassesEntity))]
        //public long ProbabilityClassIndex { get; set; }

        //public virtual CarProbabilityClassesEntity ProbabilityClass { get; set; }
    }
}
