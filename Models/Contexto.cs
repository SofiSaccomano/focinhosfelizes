using Microsoft.EntityFrameworkCore;

namespace FocinhosFelizes.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }
    }
}
