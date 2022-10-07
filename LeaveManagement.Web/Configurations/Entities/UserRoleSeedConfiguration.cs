using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                // admin
                new IdentityUserRole<string>
                {
                    RoleId = "87ebfcf3-48e8-45ca-a780-aa1c5a04aa90",
                    UserId = "621bf487-6731-494e-8e7d-5d5b045c9180"
                },
                // regular user
                new IdentityUserRole<string>
                {
                    RoleId = "0ed0adcc-5947-4a0b-9dad-e00b326e1c42",
                    UserId = "ad1be9d8-c475-446e-8206-876ca9a17bfb"
                }
            );
        }
    }
}