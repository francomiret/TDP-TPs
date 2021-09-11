using System.Data.Entity.ModelConfiguration;
using Ejercicio02.AccountManager.Domain;

namespace Ejercicio02.AccountManager.DAL.EntityFramework.Mapping
{
    class ClientMap : EntityTypeConfiguration<Client>
    {

        public ClientMap()
        {
            this.HasKey(pClient => pClient.Id);

            this.Property(pClient => pClient.Id)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(pClient => pClient.Document.Type)
                .HasColumnName("DocumentType")
                .IsRequired();

            this.Property(pClient => pClient.Document.Number)
                .HasColumnName("DocumentNumber")
                .HasMaxLength(20)
                .IsRequired();

            this.Property(pClient => pClient.FirstName)
                .HasMaxLength(30)
                .IsRequired();

            this.Property(pClient => pClient.LastName)
                .HasMaxLength(30)
                .IsRequired();

            this.HasMany(pClient => pClient.Accounts)
                .WithRequired();
        }

    }
}
