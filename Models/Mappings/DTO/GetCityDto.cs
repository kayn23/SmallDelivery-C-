using AutoMapper;
using SmallDelivery.Models;
using SmallDelivery.Models.Mapping;

namespace SmallDelivery.Models.Mappings.DTO
{
  public class GetCityDto : IMapWith<City>
  {
    public Guid Id { get; set; }
    public string Name { get; set; }

    public void Mapping(Profile profile)
    {
      profile.CreateMap<City, GetCityDto>();
    }
  }
}