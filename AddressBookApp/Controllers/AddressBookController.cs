using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using ModelLayer.DTO;
using RepositoryLayer.Entity;

namespace AddressBookApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AddressBookController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IValidator<AddressBookDTO> _validator;

        public AddressBookController(IMapper mapper, IValidator<AddressBookDTO> validator)
        {
            _mapper = mapper;
            _validator = validator;
        }


        // GET: api/addressbook , Fetch all contacts
        [HttpGet]
        public IActionResult GetAllContacts()
        {
            // Placeholder response (replace with actual logic later)
            return Ok("Fetching all contacts...");
        }

        // GET: api/addressbook/{id} , Get contact by ID
        [HttpGet("{id}")]
        public IActionResult GetContactById(int id)
        {
            // Placeholder response (replace with actual logic later)
            return Ok($"Fetching contact with ID: {id}");
        }

        // POST: api/addressbook , Add a new contact
        [HttpPost]
        public IActionResult AddContact([FromBody] AddressBookEntity newContact)
        {
            if (newContact == null)
                return BadRequest("Contact data is required");

            // Placeholder response (replace with actual logic later)
            return Ok($"Contact added: {newContact.PersonName}");
        }

        // PUT: api/addressbook/{id} , Update contact
        [HttpPut("{id}")]
        public IActionResult UpdateContact(int id, [FromBody] AddressBookEntity updatedContact)
        {
            if (updatedContact == null || id <= 0)
                return BadRequest("Valid contact data is required");

            // Placeholder response (replace with actual logic later)
            return Ok($"Contact updated with ID: {id}");
        }

        // DELETE: api/addressbook/{id} , Delete contact
        [HttpDelete("{id}")]
        public IActionResult DeleteContact(int id)
        {
            if (id <= 0)
                return BadRequest("Valid contact ID is required");

            // Placeholder response (replace with actual logic later)
            return Ok($"Contact deleted with ID: {id}");
        }
    }
}
