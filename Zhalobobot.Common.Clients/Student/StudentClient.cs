using System.Net.Http;
using System.Threading.Tasks;
using Zhalobobot.Common.Clients.Core;
using Zhalobobot.Common.Models.Student;
using Zhalobobot.Common.Models.Student.Requests;

namespace Zhalobobot.Common.Clients.Student
{
    public class StudentClient : ClientBase, IStudentClient
    {
        public StudentClient(HttpClient client, string serverUri)
            : base("students", client, serverUri)
        {
        }

        public Task<ZhalobobotResult<Models.Student.Student[]>> GetAll()
            => Method<Models.Student.Student[]>("getAll").CallAsync();

        public Task<ZhalobobotResult<StudentData[]>> GetAllData()
            => Method<StudentData[]>("getAllData").CallAsync();

        public Task<ZhalobobotResult> Add(AddStudentRequest request)
            => Method("add").CallAsync(request);

        public Task<ZhalobobotResult> Update(UpdateStudentRequest request)
            => Method("update").CallAsync(request);
    }
}