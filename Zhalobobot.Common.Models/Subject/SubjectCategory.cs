using System.ComponentModel;

namespace Zhalobobot.Common.Models.Subject
{
    public enum SubjectCategory
    {
        [Description("����������")]
        Math = 0,
        [Description("����������������")]
        Programming = 1,
        [Description("������ �����")]
        OnlineCourse = 2,
        [Description("������")]
        Another = 3
    }
}