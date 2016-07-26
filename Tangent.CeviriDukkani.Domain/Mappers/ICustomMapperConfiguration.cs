using Tangent.CeviriDukkani.Domain.Dto;
using Tangent.CeviriDukkani.Domain.Entities;

namespace Tangent.CeviriDukkani.Domain.Mappers
{
    public interface ICustomMapperConfiguration
    {
        TTo GetMapDto<TTo, TFrom>(TFrom entity) where TTo : BaseDto where TFrom : BaseEntity;
        TTo GetMapEntity<TTo, TFrom>(TFrom entity) where TTo : BaseEntity where TFrom : BaseDto;
    }
}
