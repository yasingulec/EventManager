namespace EventManagingSystem.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Message")]
    public partial class Message
    {
        public int MessageID { get; set; }

        public int MessageFrom { get; set; }

        public int MessageTo { get; set; }

        public DateTime MessageDate { get; set; }

        [Required]
        [StringLength(300)]
        public string MessageBody { get; set; }

        public virtual Person Person { get; set; }

        public virtual Person Person1 { get; set; }
    }
}
