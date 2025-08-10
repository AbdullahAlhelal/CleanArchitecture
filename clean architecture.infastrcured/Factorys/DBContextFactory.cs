using clean_architecture.Core.Interfaces;
using clean_architecture.infastrcured.persistnace.Data.DataServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clean_architecture.infastrcured.Factorys
{
    public static class DBContextFactory
    {

        public static IDbContextBuilder ContextBuilder( string type)
        {
            switch ( type )
            {
                case "sql":
                    return new SqlDBContext();
                case "Cosmo":
                    return new CosmoDBContext();
                case "Gragh":
                    return new GraphDBContext();

                default:
                    return null;
            }
        }
    }
}
