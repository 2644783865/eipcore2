using System.Threading.Tasks;
using EIP.Common.DataAccess;
using EIP.Workflow.Models.Engine;
using EIP.Workflow.Models.Entities;

namespace EIP.Workflow.DataAccess.Config
{
    public interface IWorkflowProcessInstanceRepository : IAsyncRepository<WorkflowProcessInstance>
    {
        /// <summary>
        /// ��������״̬
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<int> UpdateWorkflowProcessInstanceStatus(WorkflowEngineRunnerInput input);
    }
}
