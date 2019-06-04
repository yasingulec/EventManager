namespace EventManagingSystem.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Event")]
    public partial class Event
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Event()
        {
            EventPerson = new HashSet<EventPerson>();
        }

        public int EventID { get; set; }

        [Required]
        [StringLength(50)]
        public string EventName { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ApplicationDate { get; set; }

        public int NumberOfPersons { get; set; }

        [Required]
        [StringLength(300)]
        public string EventImage { get; set; }

        [Required]
        [StringLength(400)]
        public string Description { get; set; }

        public int CategoryID { get; set; }

        public int PersonID { get; set; }

        [Required]
        [StringLength(50)]
        public string Country { get; set; }

        [Required]
        [StringLength(50)]
        public string City { get; set; }

        [Required]
        [StringLength(50)]
        public string Location { get; set; }

        public virtual Category Category { get; set; }

        public virtual Person Person { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EventPerson> EventPerson { get; set; }
    }
}
