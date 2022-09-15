using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace EbosTask.Common
{
    public class SqlHelper
    {
        
        public static SqlConnection GetConnection()
        {
            try
            {
                var config = new ConfigurationBuilder()
            .SetBasePath(System.IO.Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", false)
            .Build();

                var connectionString = config.GetSection("connectionString:TaskConStr").Value;

                if (string.IsNullOrEmpty(connectionString))
                    throw new ArgumentException("No connection string in config.json");

                SqlConnection connection = new SqlConnection(connectionString);

                return connection;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
