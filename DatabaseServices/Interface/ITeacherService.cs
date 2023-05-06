using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseOperation;

namespace DatabaseServices.Interface
{
    public interface ITeacherService
    {
        void AddTeacher(sp_fetch_teacher_Result tech);
        void UpdateTeacher(sp_fetch_teacher_Result tech);
        void DeleteTeacher(int tech_id);
        void RestoreTeacher(int tech_id);
        List<sp_fetch_teacher_Result> GetTeacher();
        sp_fetch_teacher_Result GetTeacherById(int tech_id);
    }
}
