namespace EventManagingSystem.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EventPerson")]
    public partial class EventPerson
    {
        public int ID { get; set; }

        public int TotalPerson { get; set; }

        public int PersonID { get; set; }

        public int EventID { get; set; }

        public virtual Event Event { get; set; }

        public virtual Person Person { get; set; }
    }
}
