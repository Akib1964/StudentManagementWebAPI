using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiDemo.Data;
using WebApiDemo.Models;

namespace WebApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext _context;
        public StudentController(ApplicationDbContext context)
        {
            _context = context;//dependecy injection
        }
        //get:api/student
        [HttpGet]
        public async Task<IActionResult> GetStudents()
        {
            return Ok(await _context.Students.ToListAsync());                                                                                    
        }
        //get:api/student/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetStudent(int id)
        {
            var student = await _context.Students.FindAsync(id);
            if(student==null)
            {
                return NotFound();
            }
            return Ok(student);
        }
        //post:api/student
        [HttpPost]
        public async Task<IActionResult> CreateStudent(Student student)
        {
            _context.Students.Add(student);
            await _context.SaveChangesAsync();
            return Ok(student);
        }
        //put:api/student/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateStudent(int id,Student student)
        {
            var exist = await _context.Students.FindAsync(id);
            if(exist==null)
            {
                return NotFound();
            }
           // exist.Id = student.Id;
            exist.Name = student.Name;
            exist.Age = student.Age;
            exist.Email = student.Email;
            await _context.SaveChangesAsync();
            return Ok(exist);
        }
        //delete:api/student/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStudent(int id)
        {
            var exist = await _context.Students.FindAsync(id);
            if(exist==null)
            {
                return NotFound();
            }
            _context.Students.Remove(exist);
            await _context.SaveChangesAsync();
            return Ok("Student deleted successfully");
        }
    }
}
