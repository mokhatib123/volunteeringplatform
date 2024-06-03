using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication10.Data;
using WebApplication10.Models;

namespace WebApplication10
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainingCoursesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TrainingCoursesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/TrainingCourses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TrainingCourse>>> GetTrainingCourses()
        {
            return await _context.TrainingCourses.ToListAsync();
        }

        // GET: api/TrainingCourses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TrainingCourse>> GetTrainingCourse(int id)
        {
            var trainingCourse = await _context.TrainingCourses.FindAsync(id);

            if (trainingCourse == null)
            {
                return NotFound();
            }

            return trainingCourse;
        }

        // PUT: api/TrainingCourses/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTrainingCourse(int id, TrainingCourse trainingCourse)
        {
            if (id != trainingCourse.Id)
            {
                return BadRequest();
            }

            _context.Entry(trainingCourse).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TrainingCourseExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/TrainingCourses
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TrainingCourse>> PostTrainingCourse(TrainingCourse trainingCourse)
        {
            _context.TrainingCourses.Add(trainingCourse);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTrainingCourse", new { id = trainingCourse.Id }, trainingCourse);
        }

        // DELETE: api/TrainingCourses/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTrainingCourse(int id)
        {
            var trainingCourse = await _context.TrainingCourses.FindAsync(id);
            if (trainingCourse == null)
            {
                return NotFound();
            }

            _context.TrainingCourses.Remove(trainingCourse);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TrainingCourseExists(int id)
        {
            return _context.TrainingCourses.Any(e => e.Id == id);
        }
    }
}
