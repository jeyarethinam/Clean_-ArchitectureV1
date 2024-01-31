using dev.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dev.application.IRepository
{
    public interface IStudentRepository
    {
        Task<List<Student>> GetAll();
    }
}
