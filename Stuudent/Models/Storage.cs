using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;

namespace Stuudent.Models
{
    public class Storage
    {
        public void addStudent(Student student)
        {
            using (var db = new Context())
            {
                db.Students.Add(student);
                db.SaveChanges();
            }
        }

        public void deleteStudent(int? id)
        {
            using (var db = new Context())
            {
                Student student = db.Students.Find(id);

                db.Students.Remove(student);
                db.SaveChanges();
            }
        }

        public Student getStudentByID(int? id)
        {
            using (var db = new Context())
            {
                Student student = db.Students.Find(id);
                return student;
            }
        }

        public List<Student> getStudents()
        {
            using (var db = new Context())
            {
                var students = db.Students.ToList();
                return students;
            }
        }
    }
}