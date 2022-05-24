using PYHDATA.NETFramework.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PYHDATA.NETFramework.Data.Configurations
{
    public class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            HasKey(x => x.Id);
            Property(x => x.FirstName).IsRequired().IsUnicode().HasMaxLength(50);
            Property(x => x.LastName).IsRequired().IsUnicode().HasMaxLength(50);
            Property(x => x.Email).IsRequired().IsUnicode().HasMaxLength(250);
            Property(x => x.Address).IsUnicode().HasMaxLength(250);
            Property(x => x.Image).IsUnicode();
            Property(x => x.Password).IsUnicode();
            Property(x => x.Phone).IsUnicode().HasMaxLength(20);
            Property(x => x.BirthDate).IsUnicode().HasMaxLength(10);
            Property(x => x.CreatedAt).IsRequired();
            Property(x => x.UpdatedAt).IsRequired();
        }
    }
}
