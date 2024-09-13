using System;
using AutoMapper;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using SmallDelivery.Models.Mapping;

namespace SmallDelivery.Models.Mappings.DTO.StatusDto;

public class StatusDetailsDto : IMapWith<Status>
{
  public Guid Id { get; set; }
  public string Name { get; set; }

  public void Mapping(Profile profile)
  {
    profile.CreateMap<Status, StatusDetailsDto>();
  }
}
