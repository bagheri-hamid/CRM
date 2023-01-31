using Microsoft.AspNetCore.Mvc;
using CRM.Application.Services.Abstracts;
using CRM.Dtos;
using CRM.Application.Services.Concretes;

namespace CRM.Controllers
{
    [Route("api/notifications")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        private readonly INotificationService _notificationService;

        public NotificationController(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllNotes()
        {
            try
            {
                var notes = _notificationService.GetNotfications();
                return Ok(notes);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public IActionResult CreateNote([FromBody] NotificationDto notifDto)
        {
            try
            {
                var code = _notificationService.CreateNotification(notifDto);
                if (code == 1)
                    return BadRequest("Recipient Not Found !");
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
    }
}
