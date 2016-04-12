namespace XuDua.Da.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            UserGroups = new HashSet<UserGroup>();
        }

        public int UserID { get; set; }

        [Required]
        [StringLength(128)]
        public string UserName { get; set; }

        [Required]
        [StringLength(64)]
        public string Password { get; set; }

        [Required]
        [StringLength(64)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(64)]
        public string LastName { get; set; }

        [Required]
        [StringLength(256)]
        public string Email { get; set; }

        [Required]
        [StringLength(16)]
        public string Mobile { get; set; }

        [Required]
        [StringLength(128)]
        public string Tag { get; set; }

        public short Status { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime Created { get; set; }

        public int? CreatedBy { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? LastUpdated { get; set; }

        public int? LastUpdatedBy { get; set; }

        public bool ChangePassword { get; set; }

        public short Gender { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateOfBirth { get; set; }

        [Required]
        [StringLength(64)]
        public string HashPassword { get; set; }

        [Required]
        [StringLength(64)]
        public string SaltPassword { get; set; }

        [StringLength(64)]
        public string OneTimePassword { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? OTPExpireTime { get; set; }

        public int? CountryCode { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserGroup> UserGroups { get; set; }
    }
}
