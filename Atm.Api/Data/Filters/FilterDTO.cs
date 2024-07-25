﻿namespace Atm.Api.Data.Filters
{
    public class FilterDTO
    {
        public int Offset { get; set; }
        public int Limit { get; set; }
        public IEnumerable<Sort> Sort { get; set; }
        public Filter Filter { get; set; }
    }
}
