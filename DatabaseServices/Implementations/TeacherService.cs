using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseOperation;
using DatabaseServices.Interface;

namespace DatabaseServices.Implementations
{
    public class TeacherService : ITeacherService
    {
        IRepository<sp_fetch_teacher_Result> techrepo;
        public TeacherService(IRepository<sp_fetch_teacher_Result> techrepo)
        {
            this.techrepo = techrepo;
        }
        public void AddTeacher(sp_fetch_teacher_Result tech)
        {
            string spname = "[sp_teacher]{0},{1},{2},{3},{4},{5},{6}";
            object[] parameters = { "Insert", tech.tech_id, tech.tech_name, tech.tech_emailaddress, tech.tech_address, tech.tech_mobilenumber, tech.subject_id, tech.subject_name };
            techrepo.ExecutrCommand(spname, parameters);
        }

        public void DeleteTeacher(int tech_id)
        {
            string spname = "[sp_teacher]{0},{1},{2},{3},{4},{5},{6}";
            object[] parameters = { "Delete", tech_id, "", 0 };
            techrepo.ExecutrCommand(spname, parameters);
        }

        public List<sp_fetch_teacher_Result> GetTeacher()
        {
            string spname = "[sp_fetch_teacher]{0}";
            object[] parameters = { 0 };
            return techrepo.ExecuteQuery(spname, parameters).ToList();
        }

        public sp_fetch_teacher_Result GetTeacherById(int tech_id)
        {
            string spname = "[sp_fetch_teacher]{0}";
            object[] parameters = { tech_id };
            return techrepo.ExecuteQuery(spname, parameters).First();
        }

        public void RestoreTeacher(int tech_id)
        {
            string spname = "[sp_teacher]{0},{1},{2},{3},{4},{5},{6}";
            object[] parameters = { "Restore", tech_id, "", 0 };
            techrepo.ExecutrCommand(spname, parameters);
        }

        public void UpdateTeacher(sp_fetch_teacher_Result tech)
        {
            string spname = "[sp_teacher]{0},{1},{2},{3},{4},{5},{6}";
            object[] paramerters = { "update", tech.tech_id, tech.tech_name, tech.tech_emailaddress, tech.tech_address, tech.tech_mobilenumber, tech.subject_id, tech.subject_name };
            techrepo.ExecutrCommand(spname, paramerters);
        }
    }
}
