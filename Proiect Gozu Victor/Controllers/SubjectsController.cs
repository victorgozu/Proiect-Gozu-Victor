using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proiect_Gozu_Victor.Data;
using Proiect_Gozu_Victor.DTO;
using Proiect_Gozu_Victor.Models;

namespace Proiect_Gozu_Victor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectsController : ControllerBase
    {
        private readonly StudentsRegistryDbContext ctx;
        public SubjectsController(StudentsRegistryDbContext ctx)
        {
            this.ctx = ctx;
        }

        [HttpPost]
        public Subject AddSubject([FromBody] SubjectToCreateDTO subjectToCreate)
        {
            if (ctx.Subjects.Any(s => s.Name == subjectToCreate.Name))
            {
                return null;
            }
            var subject = new Subject
            {
                Name = subjectToCreate.Name,
            };
            ctx.Subjects.Add(subject);
            ctx.SaveChanges();
            return subject;
        }
    }
}
