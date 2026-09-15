using GolBet.Services.DTOs;

namespace GolBet.Services.Interfaces;

public interface ITeamService
{
    Task<IEnumerable<TeamDto>> GetAllAsync();
}
