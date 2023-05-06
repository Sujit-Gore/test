using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseOperation;
using DatabaseServices.Interface;

namespace DatabaseServices.Implementations
{
    public class SubjectService : ISubjectService
    {
        IRepository<sp_fetch_subject_Result> subrepo;
        public SubjectService(IRepository<sp_fetch_subject_Result> subrepo)
        {
            this.subrepo = subrepo;
        }
        public void AddSubject(sp_fetch_subject_Result sub)
        {
            string spname = "[sp_subject]{0},{1},{2}";
            object[] parameters = { "Insert", sub.subject_id, sub.subject_name };
            subrepo.ExecutrCommand(spname, parameters);
        }

        public void DeleteSubject(int subject_id)
        {
            string spname = "[sp_subject]{0},{1},{2}";
            object[] parameters = { "Delete", subject_id, "", 0 };
            subrepo.ExecutrCommand(spname, parameters);
        }

        public List<sp_fetch_subject_Result> GetSubject()
        {
            string spname = "[sp_fetch_subject]{0}";
            object[] parameters = { 0 };
            return subrepo.ExecuteQuery(spname, parameters).ToList();
        }

        public sp_fetch_subject_Result GetSubjectById(int subject_id)
        {
            string spname = "[sp_fetch_subject]{0}";
            object[] parameters = { subject_id };
            return subrepo.ExecuteQuery(spname, parameters).First();
        }

        public void RestoreSubject(int subject_id)
        {
            string spname = "[sp_subject]{0},{1},{2}";
            object[] parameters = { "Restore", subject_id, "", 0 };
            subrepo.ExecutrCommand(spname, parameters);
        }

        public void UpdateSubject(sp_fetch_subject_Result sub)
        {
            string spname = "[sp_subject]{0},{1},{2}";
            object[] paramerters = { "update", sub.subject_id, sub.subject_name };
            subrepo.ExecutrCommand(spname, paramerters);
        }
    }
}
