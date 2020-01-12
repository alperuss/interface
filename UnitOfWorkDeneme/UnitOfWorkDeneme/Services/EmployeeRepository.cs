using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnitOfWorkDeneme.Services
{
    public class EmployeeRepository : Repository<Models.Employee>, Interfaces.IEmployeeRepository
    {
        private readonly DataContext _dataContext;
        public EmployeeRepository(DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }
    }
}
