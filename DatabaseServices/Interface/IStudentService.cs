using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseOperation;

namespace DatabaseServices.Interface
{
    public interface IStudentService 
    {
        void AddStudent(sp_fetch_student_Result stud);
        void UpdateStudent(sp_fetch_student_Result stud);
        void DeleteStudent(int stud_id);
        void RestoreStudent(int stud_id);
        List<sp_fetch_student_Result> GetStudent();
        sp_fetch_student_Result GetStudentById(int stud_id);
    }
}
