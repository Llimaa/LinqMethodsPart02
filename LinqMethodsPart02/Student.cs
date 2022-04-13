using System.Collections.Generic;

namespace LinqMethodsPart02
{
    public class Student
    {
        public Student(int id, string name, string lastName, string documento, List<string> emails, string enrollment)
        {
            Id = id;
            Name = name;
            LastName = lastName;
            Documento = documento;
            Emails = emails;
            Enrollment = enrollment;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Documento { get; set; }
        public List<string> Emails { get; set; }
        public string Enrollment { get; set; }
    }
}
