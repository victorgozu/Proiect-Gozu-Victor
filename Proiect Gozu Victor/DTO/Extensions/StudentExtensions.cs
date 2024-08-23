using Proiect_Gozu_Victor.Models;

namespace Proiect_Gozu_Victor.DTO.Extensions
{
    public static class StudentExtensions
    {
        public static StudentToGetDto ToStudentToGet(this Student student)
        {
            if (student == null)
            {
                return null;
            }
            return new StudentToGetDto
            {
                LastName = student.LastName,
                FirstName = student.FirstName,
                Age = student.Age,
            };


        }
        public static Student ToEntity(this StudentToUpdate studentToCreate) =>
           new Student
           {
               FirstName = studentToCreate.FirstName,
               LastName = studentToCreate.LastName,
               Age = studentToCreate.Age
           };
    }
}
