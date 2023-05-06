using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DatabaseOperation;
using DatabaseServices.Implementations;
using DatabaseServices.Interface;

namespace InstituteSystem.Controllers
{
    public class MasterApiController : ApiController
    {
        IStudentService studentService;
        ITeacherService teacherServices;
        ISubjectService subjectService;
        ISubTechService subTechService;
        
        public MasterApiController(IStudentService studentService, ITeacherService teacherServices, ISubjectService subjectService, ISubTechService subTechService)
        {
            this.studentService = studentService;
            this.teacherServices = teacherServices;
            this.subjectService = subjectService;
            this.subTechService = subTechService;
        }
       //--------------------------------------------- Teacher Api -----------------------------\\
        [HttpGet]
        [Route("api/teacher")]
        public List<sp_fetch_teacher_Result> GetTeacher()
        {
            return teacherServices.GetTeacher();
        }

        [HttpGet]
        [Route("api/teacher/{id}")]
        public sp_fetch_teacher_Result GetTeacherBYId(int id)
        {
            return teacherServices.GetTeacherById(id);
        }

        [HttpPost]
        [Route("api/teacher")]
        public string AddTeacher(sp_fetch_teacher_Result t)
        {
            teacherServices.AddTeacher(t);
            return "Teacher Added Successfully";
        }
        [HttpPut]
        [Route("api/teacher")]
        public string UpdateTeacher(sp_fetch_teacher_Result t)
        {
            teacherServices.UpdateTeacher(t);
            return "Teacher Update Successfully";
        }
        [HttpDelete]
        [Route("api/deleteteacher/{id}")]
        public string DeleteTeacher(int id)
        {
            teacherServices.DeleteTeacher(id);
            return "Teacher Deleted Successfully";
        }
        [HttpDelete]
        [Route("api/restoreteacher/{id}")]
        public string RestoreTeacher(int id)
        {
            teacherServices.RestoreTeacher(id);
            return "Teacher Restored Successfully";
        }

        //============================================= Student Api =========================================

        [HttpGet]
        [Route("api/student")]
        public List<sp_fetch_student_Result> GetStudent()
        {
            return studentService.GetStudent();
        }

        [HttpGet]
        [Route("api/student/{id}")]
        public sp_fetch_student_Result GetStudentBYId(int id)
        {
            return studentService.GetStudentById(id);
        }

        [HttpPost]
        [Route("api/student")]
        public string AddStudent(sp_fetch_student_Result t)
        {
            studentService.AddStudent(t);
            return "Student Added Successfully";
        }
        [HttpPut]
        [Route("api/student")]
        public string UpdateStudent(sp_fetch_student_Result t)
        {
            studentService.UpdateStudent(t);
            return "Student Update Successfully";
        }
        [HttpDelete]
        [Route("api/deleteStudent/{id}")]
        public string DeleteStudent(int id)
        {
            studentService.DeleteStudent(id);
            return "Student Deleted Successfully";
        }
        [HttpDelete]
        [Route("api/restorestudent/{id}")]
        public string RestoreStudent(int id)
        {
            studentService.RestoreStudent(id);
            return "Student Restored Successfully";
        }

        //=============+++++===========================+++++++++++++ Subject Api ++++++++++++========================


        [HttpGet]
        [Route("api/subject")]
        public List<sp_fetch_subject_Result> GetSubject()
        {
            return subjectService.GetSubject();
        }

        [HttpGet]
        [Route("api/subject/{id}")]
        public sp_fetch_subject_Result GetSubjectBYId(int id)
        {
            return subjectService.GetSubjectById(id);
        }

        [HttpPost]
        [Route("api/subject")]
        public string AddSubject(sp_fetch_subject_Result t)
        {
            subjectService.AddSubject(t);
            return "Subject Added Successfully";
        }
        [HttpPut]
        [Route("api/subject")]
        public string UpdateSubject(sp_fetch_subject_Result t)
        {
            subjectService.UpdateSubject(t);
            return "Subject Update Successfully";
        }
        [HttpDelete]
        [Route("api/deletesubject/{id}")]
        public string DeleteSubject(int id)
        {
            subjectService.DeleteSubject(id);
            return "Subject Deleted Successfully";
        }
        [HttpDelete]
        [Route("api/restorestudent/{id}")]
        public string RestoreSubject(int id)
        {
            subjectService.RestoreSubject(id);
            return "Subject Restored Successfully";
        }
        //===================================================== SubTech Api ====================================

        [HttpGet]
        [Route("api/subtech")]
        public List<sp_fetch_subtech_Result> GetSubTech()
        {
            return subTechService.GetSubTech();
        }

        [HttpGet]
        [Route("api/subtech/{id}")]
        public sp_fetch_subtech_Result GetSubTechBYId(int id)
        {
            return subTechService.GetSubTechById(id);
        }

        [HttpPost]
        [Route("api/subtech")]
        public string AddSubTech(sp_fetch_subtech_Result t)
        {
            subTechService.AddSubTech(t);
            return "SubTech Added Successfully";
        }
        [HttpPut]
        [Route("api/subtech")]
        public string UpdateSubTech(sp_fetch_subtech_Result t)
        {
            subTechService.UpdateSubTech(t);
            return "SubTech Update Successfully";
        }
        [HttpDelete]
        [Route("api/deletesubtech/{id}")]
        public string DeleteSubTech(int id)
        {
            subTechService.DeleteSubTech(id);
            return "SubTech Deleted Successfully";
        }
        [HttpDelete]
        [Route("api/restoresubtech/{id}")]
        public string RestoreSubTech(int id)
        {
            subTechService.RestoreSubTech(id);
            return "SubTech Restored Successfully";
        }
    }
}
