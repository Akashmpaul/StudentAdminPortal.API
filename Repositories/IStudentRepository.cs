using StudentAdminPortal.API.Models.DomainModels;

namespace StudentAdminPortal.API.Repositories
{
    public interface IStudentRepository
    {
        Task<List<Student>> GetAllStudentsAsync();
        Task<Student?> GetStudentByIdAsync(Guid id);
        Task<Student> CreateStudentAsync(Student student);
        Task<Student?> UpdateStudentAsync(Guid id, Student student);
        Task<Student?> DeleteStudentAsync(Guid id);
    }
}
