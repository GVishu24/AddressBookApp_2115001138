using AutoMapper;
using BusinessLayer.Interface;
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
        private readonly IAddressBookBL _addressBookBL;

        public AddressBookController(IAddressBookBL addressBookBL)
        {
            _addressBookBL = addressBookBL;
        }

        [HttpGet]
        public IActionResult GetAllContacts()
        {
            var contacts = _addressBookBL.GetAllContacts();
            return Ok(contacts);
        }

        [HttpGet("{id}")]
        public IActionResult GetContactById(int id)
        {
            var contact = _addressBookBL.GetContactById(id);
            if (contact == null) return NotFound("Contact not found.");
            return Ok(contact);
        }

        [HttpPost]
        public IActionResult AddContact([FromBody] AddressBookDTO addressBookDTO)
        {
            var newContact = _addressBookBL.AddContact(addressBookDTO);
            return CreatedAtAction(nameof(GetContactById), new { id = newContact.AddressId }, newContact);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateContact(int id, [FromBody] AddressBookDTO addressBookDTO)
        {
            var updatedContact = _addressBookBL.UpdateContact(id, addressBookDTO);
            if (updatedContact == null) return NotFound("Contact not found.");
            return Ok(updatedContact);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteContact(int id)
        {
            var deleted = _addressBookBL.DeleteContact(id);
            if (!deleted) return NotFound("Contact not found.");
            return NoContent();
        }
    }
}
