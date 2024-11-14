using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Whimsy_WebAPI.Models.DataModels.Messaging;
using Whimsy_WebAPI.Services.Data;

namespace Whimsy_WebAPI.Controllers.Communication
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessagingController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public MessagingController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Endpoint to send a message
        [HttpPost("send-message")]
        public async Task<IActionResult> SendMessage(int conversationId, string senderId, string receiverId, string content)
        {
            var message = new Message
            {
                ConversationId = conversationId,
                SenderId = senderId,
                ReceiverId = receiverId,
                Content = content,
                SentAt = DateTime.UtcNow
            };

            _context.Messages.Add(message);
            await _context.SaveChangesAsync();

            // Optionally: Notify platform moderators about the message
            await NotifyModerators(message);

            return Ok(message);
        }

        // Endpoint to get all messages in a conversation
        [HttpGet("conversation/{id}")]
        public IActionResult GetConversation(int id)
        {
            var conversation = _context.Conversations
                .Where(c => c.Id == id)
                .Select(c => new
                {
                    c.Id,
                    c.BuyerId,
                    c.SellerId,
                    Messages = c.Messages.Select(m => new
                    {
                        m.Id,
                        m.SenderId,
                        m.ReceiverId,
                        m.Content,
                        m.SentAt,
                        m.IsRead
                    })
                })
                .FirstOrDefault();

            if (conversation == null)
                return NotFound();

            return Ok(conversation);
        }

        // Method to notify platform moderators
        private async Task NotifyModerators(Message message)
        {
            // Implement notification logic here (e.g., sending an email or creating a log entry)
        }
    }
}
