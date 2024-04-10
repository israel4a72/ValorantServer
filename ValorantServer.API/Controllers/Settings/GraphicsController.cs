using Microsoft.AspNetCore.Mvc;
using ValorantServer.API.DTOs.Settings;
using ValorantServer.API.DTOs.Settings.Extensions;
using ValorantServer.Infra.Repositories.Settings;

namespace ValorantServer.API.Controllers.Settings
{
    public class GraphicsController : BaseAPIController
    {
        private readonly GraphicsRepository _graphicsRepository = new GraphicsRepository();


        [HttpGet("player/{playerId:guid}")]
        public async Task<ActionResult<IEnumerable<ReadGraphicsDTO>>> GetFromPlayer(Guid playerId)
        {
            try
            {
                var graphicsSetting = await _graphicsRepository.GetFromPlayerAsync(playerId);
                var readGraphicsDTO = graphicsSetting.MapToReadGraphicsDTO();

                return Ok(readGraphicsDTO);
            }
            catch
            {
                return new StatusCodeResult(500);
            }
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ReadGraphicsDTO>>> Get()
        {
            try
            {
                var graphicsSettings = await _graphicsRepository.GetAllAsync();

                if (graphicsSettings.Count() == 0)
                    return NoContent();

                Console.WriteLine(graphicsSettings);
                var readAllGraphicsDTO = graphicsSettings.Select(g => g.MapToReadGraphicsDTO());

                return Ok(readAllGraphicsDTO);
            }
            catch
            {
                return new StatusCodeResult(500);
            }
        }

        [HttpPut]
        public async Task<ActionResult> Update([FromBody] UpdateGraphicsDTO updateGraphicsDTO)
        {
            try
            {
                var graphicsSetting = updateGraphicsDTO.MapToGraphicsSetting();
                await _graphicsRepository.UpdateAsync(graphicsSetting);

                return Ok();
            }
            catch
            {
                return new StatusCodeResult(500);
            }
        }
    }
}