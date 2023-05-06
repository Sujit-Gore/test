using DatabaseOperation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseServices.Interface
{
    public interface ISubTechService
    {
        void AddSubTech(sp_fetch_subtech_Result subtech);
        void UpdateSubTech(sp_fetch_subtech_Result subtech);
        void DeleteSubTech(int subtech_id);
        void RestoreSubTech(int subtech_id);
        List<sp_fetch_subtech_Result> GetSubTech();
        sp_fetch_subtech_Result GetSubTechById(int subtech_id);
    }
}
