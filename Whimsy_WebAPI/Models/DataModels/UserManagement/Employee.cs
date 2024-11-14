using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Whimsy_WebAPI.Models.DataModels.Support;

namespace Whimsy_WebAPI.Models.DataModels.UserManagement
{
    /// <summary>
    /// Represents an employee who can handle support tickets and perform actions within the application.
    /// </summary>
    [Table("Employees")]
    public class Employee
    {
        /// <summary>
        /// Gets or sets the unique identifier of the user.
        /// </summary>
        [Key]
        public string UserId { get; set; } = null!;

        /// <summary>
        /// Gets or sets the user associated with this entity.
        /// </summary>
        [JsonIgnore]
        [ForeignKey(nameof(UserId))]
        public virtual ApplicationUser User { get; set; } = null!;

        /// <summary>
        /// Gets or sets the position or job title of the employee.
        /// </summary>
        public string Position { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the date of job start of the employee.
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or sets the department of the employee position.
        /// </summary>
        public string Department { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets whether the user is active.
        /// </summary>
        [Required]
        public bool IsActive { get; set; } = true;

        /// <summary>
        /// Gets or sets the collection of ticket histories associated with the employee.
        /// This includes records of actions taken by the employee on support tickets.
        /// </summary>
        public virtual ICollection<TicketHistory> TicketHistories { get; set; } = [];
    }
}
