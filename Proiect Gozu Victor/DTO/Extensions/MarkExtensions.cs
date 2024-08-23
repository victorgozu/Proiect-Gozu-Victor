using Proiect_Gozu_Victor.Models;

namespace Proiect_Gozu_Victor.DTO.Extensions
{
    public static class MarkExtensions
    {
        public static MarkToGetDto GetAllMarks(this Mark mark)
        {
            return new MarkToGetDto
            {
                MarkValue = mark.MarkValue,
                StudentId = mark.StudentId,
                Moment = mark.Moment,
                SubjectId = mark.SubjectId,
            };
        }
    }
}
