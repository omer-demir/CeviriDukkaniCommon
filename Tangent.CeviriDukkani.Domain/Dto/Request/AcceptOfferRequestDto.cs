﻿using Tangent.CeviriDukkani.Domain.Dto.Enums;

namespace Tangent.CeviriDukkani.Domain.Dto.Request {
    public class AcceptOfferRequestDto {
        public int BidderId { get; set; }
        public UserRoleTypeEnum UserRoleType { get; set; }
        public int OrderDetailId { get; set; }
        public decimal? Price { get; set; }

    }
}