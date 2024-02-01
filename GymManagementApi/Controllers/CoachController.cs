using KalCulate.Api.App.Dto;
using KalCulate.Api.App.Models;
using KalCulate.Api.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace KalCulate.Api.Controllers
{
    public class CoachController : ControllerBase
    {
        private readonly GymContext _dbContext;
        private readonly DbSet<Coach> _Coaches;

        public CoachController()
        {
            _dbContext = new GymContext();
            _Coaches = _dbContext.Set<Coach>();
        }

        [HttpPost]
        public void Add([FromBody] AddCoachDto dto)
        {
            if (!_Coaches.Any(x => x.FirstName == dto.FirstName && x.LastName == dto.LastName))
                throw new Exception("This User Is Already Exist !");
            _Coaches.Add(new Coach(dto.FirstName, dto.LastName));
            _dbContext.SaveChanges();
        }
    }
}
