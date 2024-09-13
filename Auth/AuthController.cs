using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace SmallDelivery.Auth
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly SmallDeliveryDbContext _context;
        public AuthController(SmallDeliveryDbContext context) => _context = context;
        [HttpPost]
        public async Task<ActionResult> Auth(AuthDto authDto, CancellationToken cancellationToken)
        {
            var entity = await _context.Users.FirstOrDefaultAsync(u => u.Email == authDto.email, cancellationToken);
            if (entity == null) return Unauthorized();
            if (!entity.Password.Equals(authDto.pass)) return Unauthorized();
            return Ok(AuthService.GenerateToken(entity));
        }
    }
}
