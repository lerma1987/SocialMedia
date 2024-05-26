using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SocialMedia.Core.Entities;

namespace SocialMedia.Infrastructure.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder) 
        {
            builder.ToTable("Usuario");

            builder.HasKey(e => e.UserId);

            builder.Property(e => e.UserId)
                .HasColumnName("IdUsuario");

            builder.Property(e => e.LastName)
                .IsRequired()
                .HasColumnName("Apellidos")
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.Email)
                .IsRequired()
                .HasColumnName("Email")
                .HasMaxLength(30)
                .IsUnicode(false);

            builder.Property(e => e.BirthDate)
                .HasColumnName("FechaNacimiento")
                .HasColumnType("date");

            builder.Property(e => e.FirstName)
                .IsRequired()
                .HasColumnName("Nombres")
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.PhoneNumber)
                .HasMaxLength(10)
                .HasColumnName("Telefono")
                .IsUnicode(false);

            builder.Property(e => e.IsActive)
                .HasColumnType("bit")
                .HasColumnName("Activo");
        }
    }
}
