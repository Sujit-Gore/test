using DatabaseOperation;
using DatabaseServices.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseServices.Implementations
{
    public class SubTechService : ISubTechService
    {
        IRepository<sp_fetch_subtech_Result> subterepo;
        public SubTechService(IRepository<sp_fetch_subtech_Result> subterepo)
        {
            this.subterepo = subterepo;
        }
        public void AddSubTech(sp_fetch_subtech_Result subtech)
        {
            string spname = "[sp_subtech]{0},{1},{2},{3}";
            object[] parameters = { "Insert", subtech.subtech_id, subtech.tech_id, subtech.subject_id };
            subterepo.ExecutrCommand(spname, parameters);
        }

        public void DeleteSubTech(int subtech_id)
        {
            string spname = "[sp_subtech]{0},{1},{2},{3},";
            object[] parameters = { "Delete", subtech_id, "", 0 };
            subterepo.ExecutrCommand(spname, parameters);
        }

        public List<sp_fetch_subtech_Result> GetSubTech()
        {
            string spname = "[sp_fetch_subtech]{0}";
            object[] parameters = { 0 };
            return subterepo.ExecuteQuery(spname, parameters).ToList();
        }

        public sp_fetch_subtech_Result GetSubTechById(int subtech_id)
        {
            string spname = "[sp_fetch_subtech]{0}";
            object[] parameters = { subtech_id };
            return subterepo.ExecuteQuery(spname, parameters).First();
        }

        public void RestoreSubTech(int subtech_id)
        {
            string spname = "[sp_subtech]{0},{1},{2},{3}";
            object[] parameters = { "Restore", subtech_id, "", 0 };
            subterepo.ExecutrCommand(spname, parameters);
        }

        public void UpdateSubTech(sp_fetch_subtech_Result subtech)
        {
            string spname = "[sp_subtech]{0},{1},{2},{3},{4},{5},{6}";
            object[] paramerters = { "update", subtech.subtech_id, subtech.tech_id, subtech.subject_id };
            subterepo.ExecutrCommand(spname, paramerters);
        }
    }
}
