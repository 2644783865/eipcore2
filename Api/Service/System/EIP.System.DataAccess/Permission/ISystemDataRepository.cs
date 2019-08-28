using EIP.Common.DataAccess;
using EIP.System.Models.Dtos.Permission;
using EIP.System.Models.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EIP.System.DataAccess.Permission
{
    public interface ISystemDataRepository : IAsyncRepository<SystemData>
    {
        /// <summary>
        ///     ���ݲ˵�Id��ȡ����Ȩ�޹���
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<IEnumerable<SystemDataOutput>> GetDataByMenuId(SystemDataGetDataByMenuIdInput input=null);
    }
}