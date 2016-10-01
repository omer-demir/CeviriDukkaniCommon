using System;
using System.Collections.Generic;
using System.Linq;
using Tangent.CeviriDukkani.Domain.Dto.Common;

namespace Tangent.CeviriDukkani.Domain.Dto.Sale {
    public class SimultaneousTranslatingOrderDto:OrderDto {
        public virtual List<SimultaneousTranslatingOrderTargetLanguageDto> TargetLanguages { get; set; }


        public int CityId { get; set; }
        public virtual CityDto City { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public bool AccommodationProvided { get; set; }
        public bool FoodProvided { get; set; }
        public bool TransportationProvided { get; set; }

        public virtual List<SimultaneousTranslatingOrderEquipmentDto> Equipments { get; set; }
        public virtual List<SimultaneousTranslatingOrderTranslatorDto> Translators { get; set; }

        public string TargetLanguagesAsString {
            get {
                if (TargetLanguages != null && TargetLanguages.Any()) {
                    return string.Join(",", TargetLanguages.Select(a => a.Language.Name));
                }
                return "";
            }
        }
    }
}