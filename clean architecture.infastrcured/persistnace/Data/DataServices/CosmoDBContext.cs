using clean_architecture.Core.Interfaces;

namespace clean_architecture.infastrcured.persistnace.Data.DataServices
{
    public class CosmoDBContext : IDbContextBuilder
    {
        public dynamic GetDbContextByType()
        {
            throw new NotImplementedException();
        }
    }
}
