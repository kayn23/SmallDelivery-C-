using System;

namespace SmallDelivery.Models.Mappings.DTO;

public class StockListDto
{
  public IList<StockDetailsDto> Stocks { get; set; }
}
