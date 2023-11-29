using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cours_web_Api.DTO.Character;

namespace cours_web_Api.Services.CharacterServices
{
    public interface ICHaracterService
    {
        Task<ServiceResponse<List<GetCharacterDto>>> GeAllCharacters();
        Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id);
        Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter);
        Task<ServiceResponse<GetCharacterDto>> UpdateCharacter(UpdateCharacterDto updatedCharacter);
        Task<ServiceResponse<List<GetCharacterDto>>> DeleteCharacter(int id);

    }
}