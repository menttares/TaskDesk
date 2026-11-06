using System.ComponentModel.DataAnnotations;
using TaskDesk.Models;

namespace TaskDesk.ViewModels;

public class CreateTicketViewModel
{
    [Display(Name = "Название")]
    [Required(ErrorMessage = "Укажи название заявки")]
    [StringLength(120, ErrorMessage = "Максимум 120 символов")]
    public string Title { get; set; } = string.Empty;

    [Display(Name = "Описание")]
    [StringLength(2000, ErrorMessage = "Максимум 2000 символов")]
    public string? Description { get; set; }

    [Display(Name = "Приоритет")]
    [EnumDataType(
        typeof(TicketPriority),
        ErrorMessage = "Выбери допустимый приоритет"
    )]
    public TicketPriority Priority { get; set; } = TicketPriority.Medium;
}