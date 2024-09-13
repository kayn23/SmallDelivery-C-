using System;

namespace SmallDelivery.Models.Mappings.DTO.UserDto;

public class UserListDto
{
  public IList<UserDetailsDto> Users { get; set; }
}
