using core3._1api.DTOs;
using core3._1api.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core3._1api.Services
{
     public interface IStudentRepository
    {
  
        IEnumerable<Student> GetAllStudent();

        Student StudentById(int Id);

        void AddStudent(Student student);

        void UpdateStudent(int Id,Student student);
        void UpdateStudent(Student student);

        void RemoveStudent( Student student);
    }
}
