using DatabaseOperation;
using DatabaseServices.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseServices.Implementations
{
    public class StudentService : IStudentService
    {
        IRepository<sp_fetch_student_Result> studrepo;
        public StudentService(IRepository<sp_fetch_student_Result> studrepo)
        {
            this.studrepo = studrepo;
        }
        public void AddStudent(sp_fetch_student_Result stud)
        {
            string spname = "[sp_student]{0},{1},{2},{3},{4},{5}";
            object[] parameters = { "Insert", stud.stud_id, stud.Stud_name, stud.stud_emailaddress, stud.stud_address, stud.stud_mobilenumber };
            studrepo.ExecutrCommand(spname, parameters);
        }

        public void DeleteStudent(int stud_id)
        {
            string spname = "[sp_student]{0},{1},{2},{3},{4},{5}";
            object[] parameters = { "Delete", stud_id, "", 0 };
            studrepo.ExecutrCommand(spname, parameters);
        }

        public List<sp_fetch_student_Result> GetStudent()
        {
            string spname = "[sp_fetch_student]{0}";
            object[] parameters = { 0 };
            return studrepo.ExecuteQuery(spname, parameters).ToList();
        }

        public sp_fetch_student_Result GetStudentById(int stud_id)
        {
            string spname = "[sp_fetch_student]{0}";
            object[] parameters = { stud_id };
            return studrepo.ExecuteQuery(spname, parameters).First();
        }

        public void RestoreStudent(int stud_id)
        {
            string spname = "[sp_student]{0},{1},{2},{3},{4},{5}";
            object[] parameters = { "Restore", stud_id, "", 0 };
            studrepo.ExecutrCommand(spname, parameters);
        }

        public void UpdateStudent(sp_fetch_student_Result stud)
        {
            string spname = "[sp_student]{0},{1},{2},{3},{4},{5}";
            object[] paramerters = { "update", stud.stud_id, stud.Stud_name, stud.stud_emailaddress, stud.stud_address, stud.stud_mobilenumber };
            studrepo.ExecutrCommand(spname, paramerters);
        }

        //===============================================Subject Api==========================================

    }
}
