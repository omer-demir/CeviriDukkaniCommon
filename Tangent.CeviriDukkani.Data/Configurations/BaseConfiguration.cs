using System.Data.Entity.ModelConfiguration;
using Tangent.CeviriDukkani.Domain.Entities;

namespace Tangent.CeviriDukkani.Data.Configurations {
    public class BaseConfiguration<T>:EntityTypeConfiguration<T> where T: BaseEntity {
        public BaseConfiguration() {
            
        }
    }
}