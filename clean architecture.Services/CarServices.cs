using clean_architecture.Core.Entity;
using clean_architecture.Core.Interfaces;
using clean_architecture.infastrcured.persistnace.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clean_architecture.Services
{
    public class CarServices : ICarServices
    {
        private readonly IRepository<Car> _repository;

        public CarServices(IRepository<Car> Repository)
        {
            _repository = Repository;


        }
        public async ValueTask Create(Car car)
        {
            await _repository.AddAsync(car);
        }
    }
}
