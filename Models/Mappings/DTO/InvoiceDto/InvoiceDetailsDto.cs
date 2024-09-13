using System;
using AutoMapper;
using SmallDelivery.Models.Mapping;
using SmallDelivery.Models.Mappings.DTO.StatusDto;
using SmallDelivery.Models.Mappings.DTO.UserDto;

namespace SmallDelivery.Models.Mappings.DTO.InvoiceDto;

public class InvoiceDetailsDto : IMapWith<Invoice>
{
  public Guid Id { get; set; }
  public StockDetailsDto Endpoint { get; set; }
  public UserDetailsDto Sender { get; set; }
  public UserDetailsDto Recipient { get; set; }
  public StatusDetailsDto Status { get; set; }

  public void Mapping(Profile profile)
  {
    profile.CreateMap<Invoice, InvoiceDetailsDto>();
    profile.CreateMap<Stock, StockDetailsDto>();
    profile.CreateMap<User, UserDetailsDto>();
    profile.CreateMap<Status, StockDetailsDto>();
  }

}
