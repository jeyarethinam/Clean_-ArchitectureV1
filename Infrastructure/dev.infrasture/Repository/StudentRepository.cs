using dev.application.IRepository;
using dev.domain;
using dev.infrasture.Presistance;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dev.infrasture.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly StudentDbContext _studentDb;

        public StudentRepository(StudentDbContext studentDb)
        {
            _studentDb = studentDb;
        }

        public async Task<List<Student>> GetAll()
        {
            return await _studentDb.Students.ToListAsync();
        }
    }
}
