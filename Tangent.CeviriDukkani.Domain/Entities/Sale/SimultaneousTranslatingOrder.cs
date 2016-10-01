using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Tangent.CeviriDukkani.Domain.Entities.Common;
using Tangent.CeviriDukkani.Domain.Entities.System;

namespace Tangent.CeviriDukkani.Domain.Entities.Sale {
    [Table("SimultaneousTranslatingOrder", Schema = "Order")]
    public class SimultaneousTranslatingOrder : Order {
        public int CityId { get; set; }
        public virtual City City { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public bool AccommodationProvided { get; set; }
        public bool FoodProvided { get; set; }
        public bool TransportationProvided { get; set; }

        public virtual List<SimultaneousTranslatingOrderEquipment> Equipments { get; set; }
        public virtual List<SimultaneousTranslatingOrderTranslator> Translators { get; set; }
    }
}