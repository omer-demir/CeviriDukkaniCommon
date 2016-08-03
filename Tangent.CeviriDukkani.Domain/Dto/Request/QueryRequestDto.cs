using System.Collections.Generic;

namespace Tangent.CeviriDukkani.Domain.Dto.Request {
    public class QueryRequestDto {
        public Dictionary<string, object> Parameters { get; set; }
        public string SortingFieldName { get; set; }
        public SortingType SortingType { get; set; }
    }
}

namespace Tangent.CeviriDukkani.Domain.Dto.Request {
    public enum SortingType {
        Asc,
        Desc,
        NoSort
    }
}