using MultiLayer.Domain;
using MultiLayer.Infrasturcture;

namespace MultiLayer.Services
{
    public class DbContextFactory
    {
        public static IDbContext Create()
        {
            return new MultilayerDbContext();
        }
    }
}
