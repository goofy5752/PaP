using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using PaPData.Common.Contracts;

namespace PaPData.Models
{
    public class PaPUser : IdentityUser, IDeletableEntity
    {
        public override string Id { get; set; }

        public override string UserName { get; set; }

        public override string Email { get; set; }

        [Column(TypeName = "nvarchar(150)")]
        public string FullName { get; set; }

        public string ProfileImage { get; set; }

        public DateTime? RegisteredOn { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}
