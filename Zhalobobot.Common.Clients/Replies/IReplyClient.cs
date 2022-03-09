using System.Threading.Tasks;
using Zhalobobot.Common.Clients.Core;
using Zhalobobot.Common.Models.Reply.Requests;

namespace Zhalobobot.Common.Clients.Reply
{
    public interface IReplyClient
    {
        /// <summary>
        /// �������� ����� �� �������� �����.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<ZhalobobotResult> Add(AddReplyRequest request);

        /// <summary>
        /// �������� ��� ������ �� �������� �����.
        /// </summary>
        /// <returns></returns>
        Task<ZhalobobotResult<Models.Reply.Reply[]>> GetAll();
    }
}