using System;
using System.Collections.Generic;

namespace TestProject.Data.Entities
{
    public class AreaEntity : BaseEntity
    {
        public string Name { get; set; }

        public IEnumerable<GarageEntity> Garages { get; set; }
    }
}
