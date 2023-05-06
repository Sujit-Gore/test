using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseOperation;
namespace DatabaseServices.Interface
{
    public interface ISubjectService
    {
        void AddSubject(sp_fetch_subject_Result sub);
        void UpdateSubject(sp_fetch_subject_Result sub);
        void DeleteSubject(int subject_id);
        void RestoreSubject(int subject_id);
        List<sp_fetch_subject_Result> GetSubject();
        sp_fetch_subject_Result GetSubjectById(int subject_id);
    }
}
