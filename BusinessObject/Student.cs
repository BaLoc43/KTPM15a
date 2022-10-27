using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    [Serializable]
    public class Student
    {
        public long studentId { get; set; }
        public string fullName { get; set; }
        public DateTime DOB { get; set; }
        public Student():this(0, "no-name", new DateTime())
        {

        }
        public Student(long id, string fname, DateTime dob)
        {
            studentId = id; fullName = fname; DOB = dob;
        }
        public override string ToString()
        {
            return fullName+"\t"+DOB;
        }
    }
}
