﻿using pavlov_d_kt_41_22.Filters.TeacherFilters;
using pavlov_d_kt_41_22.Interfaces.TeachersInterfaces;
using pavlov_d_kt_41_22.Models;
using Microsoft.AspNetCore.Mvc;
using pavlov_d_kt_41_22.Filters.TeacherFilters;
using pavlov_d_kt_41_22.Interfaces.TeachersInterfaces;
using pavlov_d_kt_41_22.Models;
using System.Threading;
using System.Threading.Tasks;

namespace pavlov_d_kt_41_22.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TeachersController : ControllerBase
    {
        private readonly ILogger<TeachersController> _logger;
        private readonly ITeacherService _teacherService;

        public TeachersController(ILogger<TeachersController> logger, ITeacherService teacherService)
        {
            _logger = logger;
            _teacherService = teacherService;
        }

        [HttpPost("get", Name = "GetTeachers")]
        public async Task<IActionResult> GetTeachersAsync([FromBody] TeacherFilter filter, CancellationToken cancellationToken)
        {
            var teachers = await _teacherService.GetTeachersAsync(filter, cancellationToken);
            return Ok(teachers);
        }

        [HttpPost("add", Name = "AddTeacher")]
        public async Task<IActionResult> AddTeacherAsync([FromBody] Teacher teacher, CancellationToken cancellationToken)
        {
            await _teacherService.AddTeacherAsync(teacher, cancellationToken);
            return Ok("Преподаватель успешно добавлен.");
        }

        [HttpPut("update", Name = "UpdateTeacher")]
        public async Task<IActionResult> UpdateTeacherAsync([FromBody] Teacher teacher, CancellationToken cancellationToken)
        {
            await _teacherService.UpdateTeacherAsync(teacher, cancellationToken);
            return Ok("Преподаватель успешно обновлен.");
        }

        [HttpDelete("delete/{teacherId}", Name = "DeleteTeacher")]
        public async Task<IActionResult> DeleteTeacherAsync(int teacherId, CancellationToken cancellationToken)
        {
            await _teacherService.DeleteTeacherAsync(teacherId, cancellationToken);
            return Ok("Преподаватель успешно удален.");
        }
    }
}