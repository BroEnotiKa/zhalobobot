using System;
using System.Collections.Generic;
using Zhalobobot.Common.Helpers.Extensions;
using Zhalobobot.Common.Models.Student;

namespace Zhalobobot.Bot.Cache
{
    public class StudentCache : EntityCacheBase<Student>
    {
        private readonly Dictionary<long, Student> chatIdIndex = new();

        public StudentCache(Student[] students) 
            : base(students)
        {
            foreach (var student in students)
                chatIdIndex.Add(student.Id, student);
        }

        public Student? Find(long chatId) => chatIdIndex.Find(chatId);
        public Student Get(long chatId) => chatIdIndex.Find(chatId) ?? throw new Exception();
        public void Add(Student student) => chatIdIndex.Add(student.Id, student);
    }
}