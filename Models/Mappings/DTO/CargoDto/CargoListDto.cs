using System;

namespace SmallDelivery.Models.Mappings.DTO.CargoDto;

public class CargoListDto
{
  public IList<CargoDetailsDto> Cargoes { get; set; }
}
