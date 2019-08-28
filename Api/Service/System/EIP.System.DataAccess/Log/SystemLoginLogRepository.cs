using EIP.Common.DataAccess;
using EIP.System.Models.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EIP.System.DataAccess.Log
{
    public class SystemLoginLogRepository : MongoDbAsyncRepository<SystemLoginLog>, ISystemLoginLogRepository
    {
        /// <summary>
        /// ��ȡ��־��������
        /// </summary>
        /// <returns></returns>
        public Task<IEnumerable<SystemLoginLog>> GetBrowserAnalysis()
        {
            var field = new[] { "UserAgent" };
            return GetAllEnumerableAsync(null, field);
        }
    }
}