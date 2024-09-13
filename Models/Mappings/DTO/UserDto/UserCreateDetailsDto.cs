using System;

namespace SmallDelivery.Models.Mappings.DTO.UserDto;

public class UserCreateDetailsDto : UserDetailsDto
{
  public string Password { get; set; }

}
