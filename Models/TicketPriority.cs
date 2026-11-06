using System.ComponentModel.DataAnnotations;

namespace TaskDesk.Models;

public enum TicketPriority
{
    [Display(Name = "Низкий")]
    Low = 0,

    [Display(Name = "Средний")]
    Medium = 1,

    [Display(Name = "Высокий")]
    High = 2
}