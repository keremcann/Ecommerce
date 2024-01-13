using Ecommerce.Core.Configuration;
using Ecommerce.Core.LogManager;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Ecommerce.Core.Connection
{
    public abstract class DbConnection
    {
        /// <summary>
        /// 
        /// </summary>
        public DbConnectionResponse connection;

        /// <summary>
        /// 
        /// </summary>
        public DbConnection() 
        {
            connection = OpenConnection();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private DbConnectionResponse OpenConnection()
        {
            var response = new DbConnectionResponse();
            try
            {
                String connectionString = AppSettings.GetConnectionString();
                IDbConnection _db = new SqlConnection(connectionString);
                _db.Open();
                response.db = _db;
                response.Success = true;
                response.ErrorMessage = "Success";
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.ErrorMessage = ex.Message;
                FileLog log = new FileLog();
                log.Error(ex.Message);
            }
            return response;
        }
    }
}
