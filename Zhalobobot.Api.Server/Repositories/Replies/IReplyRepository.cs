using System.Threading.Tasks;
using Zhalobobot.Common.Models.Reply;

namespace Zhalobobot.Api.Server.Repositories.Feedback
{
    public interface IReplyRepository
    {
        /// <summary>
        /// �������� ����� �� �������� �����.
        /// </summary>
        /// <param name="reply"></param>
        /// <returns></returns>
        public Task Add(Reply reply);

        /// <summary>
        /// �������� ��� ������ �� �������� �����.
        /// </summary>
        /// <returns></returns>
        Task<Reply[]> GetAll();
    }
}