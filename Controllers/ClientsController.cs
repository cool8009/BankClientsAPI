using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BankClientApi.Data;
using BankClientApi.Models.Client;
using BankClientApi.Configurations;
using AutoMapper;
using BankClientApi.Contracts;

namespace BankClientApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        // Inject the IClientsRepository and IMapper dependencies
        private readonly IClientsRepository _clientsRepository;
        private readonly IMapper _mapper;

        public ClientsController(IClientsRepository clientsRepository, IMapper mapper)
        {
            _clientsRepository = clientsRepository;
            _mapper = mapper;
        }

        // GET: api/Clients
        /// <summary>
        /// GETs a list of all clients.
        /// </summary>
        /// <returns>List of clients from the database</returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GetClientDto>>> GetClients()
        {
            try
            {
                var clients = await _clientsRepository.GetAllAsync();
                var records = _mapper.Map<List<GetClientDto>>(clients);
                return Ok(records);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        /// <summary>
        /// Gets a specific client by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>ClientDto from the database</returns>
        // GET: api/Clients/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GetClientDto>> GetClient(int id)
        {
            try
            {
                var client = await _clientsRepository.GetAsync(id);
                var records = _mapper.Map<GetClientDto>(client);
                if (client == null)
                {
                    return NotFound();
                }

                return Ok(records);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST: api/Clients
        /// <summary>
        /// Creates a new client in the database
        /// </summary>
        /// <param name="createClient"></param>
        /// <returns>The new client object if successful, error message if not</returns>
        [HttpPost]
        public async Task<ActionResult<CreateClientDto>> PostClient(CreateClientDto createClient)
        {
            try
            {
                var client = _mapper.Map<Client>(createClient);
                await _clientsRepository.AddAsync(client);

                return CreatedAtAction("GetClient", new { id = client.Id }, createClient);
            }
            catch (ArgumentNullException ex)
            {
                return BadRequest("Missing required parameter: " + ex.ParamName);
            }
            catch (DbUpdateException ex)
            {
                return Conflict("Error saving data: " + ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }
        /// <summary>
        /// Deletes a client from the database by on id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>NoContent</returns>
        // DELETE: api/Clients/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClient(int id)
        {
            try
            {
                var client = await _clientsRepository.GetAsync(id);
                if (client == null)
                {
                    return NotFound();
                }

                await _clientsRepository.DeleteAsync(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        private async Task<bool> ClientExists(int id)
        {
            return await _clientsRepository.Exists(id);
        }
    }
}
