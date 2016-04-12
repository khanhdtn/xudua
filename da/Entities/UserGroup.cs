namespace XuDua.Da.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserGroup")]
    public partial class UserGroup
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UserGroup()
        {
            Users = new HashSet<User>();
        }

        public int UserGroupID { get; set; }

        [Required]
        [StringLength(256)]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        public int? UsergroupTypeID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime Created { get; set; }

        public int? CreatedBy { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? LastUpdated { get; set; }

        public int? LastUpdatedBy { get; set; }

        public virtual UserGroupType UserGroupType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User> Users { get; set; }
    }
}
