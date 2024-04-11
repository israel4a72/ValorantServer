using Microsoft.AspNetCore.Mvc;
using ValorantServer.API.DTOs.Settings;
using ValorantServer.API.DTOs.Settings.Extensions;
using ValorantServer.Domain.Shared;
using ValorantServer.Infra.Repositories.Settings;

namespace ValorantServer.API.Controllers.Settings
{
    public class GraphicsController : BaseAPIController
    {
        private readonly VideoSettingRepository _videoSettingRepository;

        public GraphicsController(VideoSettingRepository graphicsRepository)
        {
            _videoSettingRepository = graphicsRepository;
        }

        [HttpGet("player/{playerId:guid}")]
        public async Task<ActionResult<IEnumerable<ReadVideoSettingDTO>>> GetFromPlayer(Guid playerId)
        {
            try
            {
                var videoSetting = await _videoSettingRepository.GetFromPlayerAsync(playerId);

                if (videoSetting is null) return NotFound();

                var readVideoSettingDTO = videoSetting;//.MapToReadVideoSettingDTO();

                return Ok(readVideoSettingDTO);
            }
            catch
            {
                return new StatusCodeResult(500);
            }
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ReadVideoSettingDTO>>> Get()
        {
            try
            {
                var graphicsSettings = await _videoSettingRepository.GetAllAsync();

                if (graphicsSettings.Count() == 0)
                    return NotFound();

                Console.WriteLine(graphicsSettings);
                var readAllGraphicsDTO = graphicsSettings.Select(g => g/*.MapToReadVideoSettingDTO()*/);

                return Ok(new { status = 200, data = readAllGraphicsDTO, mensagem = "Deu tudo certo" });
            }
            catch
            {
                return new StatusCodeResult(500);
            }
        }

        [HttpPut]
        public async Task<ActionResult> Update([FromBody] UpdateVideoSettingDTO updateGraphicsDTO)
        {
            try
            {
                if (!ModelState.IsValid) return BadRequest();

                var graphicsSettingToUpdate = await _videoSettingRepository.GetFromPlayerAsync(updateGraphicsDTO.PlayerId);

                if (graphicsSettingToUpdate is null) return NotFound();

                var graphicsSettingUpdated = updateGraphicsDTO.MapToVideoSetting(graphicsSettingToUpdate);

                await _videoSettingRepository.UpdateAsync(graphicsSettingUpdated);

                return Ok();
            }
            catch
            {
                return new StatusCodeResult(500);
            }
        }
    }
}