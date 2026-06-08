using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/[controller]")]
public class ContactsController : ControllerBase
{
    private readonly AppDbContext _context;

    public ContactsController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var contacts = await _context.Contacts.ToListAsync();

        return Ok(contacts.Select(c => c.ToDto()));
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var contact = await _context.Contacts.FindAsync(id);

        if (contact == null)
            return NotFound();

        return Ok(contact.ToDto());
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateContactDto dto)
    {
        var entity = dto.ToEntity();

        _context.Contacts.Add(entity);
        await _context.SaveChangesAsync();

        return CreatedAtAction(
            nameof(GetById),
            new { id = entity.Id },
            entity.ToDto()
        );
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var contact = await _context.Contacts.FindAsync(id);

        if (contact == null)
            return NotFound();

        _context.Contacts.Remove(contact);

        await _context.SaveChangesAsync();

        return NoContent();
    }
}