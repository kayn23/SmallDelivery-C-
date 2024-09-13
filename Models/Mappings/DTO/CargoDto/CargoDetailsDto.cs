using System;
using AutoMapper;
using SmallDelivery.Models.Mapping;

namespace SmallDelivery.Models.Mappings.DTO.CargoDto;

public class CargoDetailsDto : IMapWith<Cargo>
{
  public Guid Id { get; set; }
  public float Weight { get; set; }
  public Guid InvoiceId { get; set; }

  public void Mapping(Profile profile)
  {
    profile.CreateMap<Cargo, CargoDetailsDto>();
  }

}
