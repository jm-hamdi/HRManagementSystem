using HRManagementSystem.Models;
using HRManagementSystem.Services;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class EmployeeController : ControllerBase
{
    private readonly IEmployeeService _employeeService;

    public EmployeeController(IEmployeeService employeeService)
    {
        _employeeService = employeeService;
    }

    // GET: api/employee
    [HttpGet]
    public async Task<IActionResult> GetAllEmployees()
    {
        var employees = await _employeeService.GetAllEmployees();
        return Ok(employees);
    }

    // GET: api/employee/{id}
    [HttpGet("{id}")]
    public async Task<IActionResult> GetEmployeeById(int id)
    {
        var employee = await _employeeService.GetEmployeeById(id);
        if (employee == null)
        {
            return NotFound();
        }
        return Ok(employee);
    }

    // POST: api/employee
    [HttpPost]
    public async Task<IActionResult> AddEmployee([FromBody] Employee employee)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var newEmployee = await _employeeService.AddEmployee(employee);
        return CreatedAtAction(nameof(GetEmployeeById), new { id = newEmployee.Id }, newEmployee);
    }

    // PUT: api/employee/{id}
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateEmployee(int id, [FromBody] Employee employee)
    {
        if (id != employee.Id || !ModelState.IsValid)
        {
            return BadRequest();
        }

        var updatedEmployee = await _employeeService.UpdateEmployee(employee);
        if (updatedEmployee == null)
        {
            return NotFound();
        }
        return Ok(updatedEmployee);
    }

    // DELETE: api/employee/{id}
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteEmployee(int id)
    {
        var result = await _employeeService.DeleteEmployee(id);
        if (!result)
        {
            return NotFound();
        }
        return NoContent();
    }
}
