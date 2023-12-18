using Microsoft.EntityFrameworkCore;
using StudentAdminPortal.API.Data;
using StudentAdminPortal.API.Models.DomainModels;

namespace StudentAdminPortal.API.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly StudentDbContext studentDbContext;

        public StudentRepository(StudentDbContext studentDbContext)
        {
            this.studentDbContext = studentDbContext;
        }

        public async Task<Student> CreateStudentAsync(Student student)
        {
           await studentDbContext.students.AddAsync(student);
            await studentDbContext.SaveChangesAsync();
            return student;
        }

        public async Task<Student?> DeleteStudentAsync(Guid id)
        {
            var studentId = await studentDbContext.students.FirstOrDefaultAsync(x => x.Id == id);
            if (studentId == null)
            {
                return null;
            }
            studentDbContext.students.Remove(studentId);
            await studentDbContext.SaveChangesAsync();
            return studentId;
        }

        public async Task<List<Student>> GetAllStudentsAsync()
        {
            return await studentDbContext.students.ToListAsync();
        }

        public async Task<Student?> GetStudentByIdAsync(Guid id)
        {
            var studentId = await studentDbContext.students.FindAsync(id);
            if (studentId == null)
            {
                return null;
            }
            return studentId;
        }

        public async Task<Student?> UpdateStudentAsync(Guid id, Student student)
        {
            throw new NotImplementedException();
        }
    }
}
