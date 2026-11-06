using System.ComponentModel.DataAnnotations;


namespace TaskDesk.Models;


public class Ticket
{
    public int Id { get; set; }

    [Display(Name = "Название")]
    [Required(ErrorMessage = "Поле 'Название' обязательно для заполнения.")]
    [StringLength(120, ErrorMessage = "Название не может превышать 100 символов.")]
    public string Title { get; set; } = string.Empty;


    [Display(Name = "Описание")]
    [StringLength(2000, ErrorMessage = "Описание не может превышать 2000 символов.")]
    public string Description { get; set; } = string.Empty;




    [Display(Name = "Статус")]
    [Required(ErrorMessage = "Поле 'Статус' обязательно для заполнения.")]
    public TicketStatus Status { get; set; }

    [Display(Name = "Приоритет")]
    [Required(ErrorMessage = "Поле 'Приоритет' обязательно для заполнения.")]
    public TicketPriority Priority { get; set; }


    [Display(Name = "Дата создания")]
    public DateTime CreatedDate { get; set; }

}