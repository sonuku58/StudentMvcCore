using AutoMapper;
using core3._1api.DTOs;
using core3._1api.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core3._1api.Services
{
    public class StudentRepository : IStudentRepository
    {

        private readonly ApplicationDbContext context;
       
        public StudentRepository( ApplicationDbContext _context )
        {
            this.context = _context;
            
        }

     

        public  IEnumerable<Student> GetAllStudent()
        {
            var studentList = context.Students.AsNoTracking().ToList();
           
            return studentList;
        }

        public Student StudentById(int Id)
        {
            return  context.Students.FirstOrDefault(x => x.Id == Id);
        }

        public void AddStudent(Student student)
        {
            context.Add(student);
            context.SaveChanges();
        }

        public void UpdateStudent(int Id,Student student)
        {
           
            var students = context.Students.FirstOrDefault(s => s.Id == Id);
            students.FirstName = student.FirstName;
            students.LastName = student.LastName;
            students.Gender = student.Gender;
            students.Salary = student.Salary;
            context.SaveChanges();
        }

        public void UpdateStudent(Student student)
        {
            var students = context.Students.FirstOrDefault(s => s.Id == student.Id);
            students.FirstName = student.FirstName;
            students.LastName = student.LastName;
            students.Gender = student.Gender;
            students.Salary = student.Salary;
            context.SaveChanges();
        }

        public void RemoveStudent(Student student)
        {
            context.Remove(student);
            context.SaveChanges();
        }

        
    }
}
