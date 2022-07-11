﻿using System;

namespace Repository.Model
{
    public class FuelQuoteMasterModel
    {
        public long FuelId { get; set; }

        public int? ClientId { get; set; }

        public string ClientName { get; set; }

        public int? GallonsRequested { get; set; }

        public DateTime? DeliveryDate { get; set; }

        public int? SuggestedPrice { get; set; }

        public int? TotalAmountDue { get; set; }

        public string DiliveryAddress { get; set; }

        public DateTime? CreatedDate { get; set; }
    }
}