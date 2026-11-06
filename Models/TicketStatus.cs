using System.ComponentModel.DataAnnotations;


namespace TaskDesk.Models;


public enum TicketStatus
{
    [Display(Name = "Открыт")]
    Opened = 0,

    [Display(Name = "В работе")]
    InProgress = 1,

    [Display(Name = "Закрыт")]
    Closed = 2
}