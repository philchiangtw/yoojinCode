global using yoojinCode.Models;
global using yoojinCode.Services.CharacterService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace yoojinCode.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterService _characterService;

        public CharacterController(ICharacterService characterService)
        {
            _characterService = characterService;
        }
        [HttpGet]
        [Route("GetAll")]
        public async Task<ActionResult<ServiceResponse<List<GetCharacterResponseDto>>>> Get() 
        {
            return Ok(await _characterService.GetAllCharacters());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<GetCharacterResponseDto>>> GetSingle(int id) 
        {
            return Ok(await _characterService.GetCharacterById(id));
        }
        [HttpPost("CreateCharacter")]
            public async Task<ActionResult<ServiceResponse<List<GetCharacterResponseDto>>>> AddCharacter(AddCharacterRequestDto newCharacter) 
            {
                return Ok(await _characterService.AddCharacter(newCharacter));
            }
        [HttpPut("UpdateCharacter")]
            public async Task<ActionResult<ServiceResponse<List<GetCharacterResponseDto>>>> UpdateCharacter(UpdateCharacterDto updatedCharacter) 
            {
                var response = await _characterService.UpdateCharacter(updatedCharacter);
                if (response.Data is null) {
                    return NotFound(response);
                }
                return Ok(response);
            }
        [HttpDelete("{id}")]
        public async Task<ActionResult<ServiceResponse<GetCharacterResponseDto>>> DeleteCharacter(int id) 
        {
            var response = await _characterService.DeleteCharacter(id);
                if (response.Data is null) {
                    return NotFound(response);
                }
                return Ok(response);
        }
    }
}