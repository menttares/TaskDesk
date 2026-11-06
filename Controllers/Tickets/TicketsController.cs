using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaskDesk.Data;
using TaskDesk.Models;
using TaskDesk.ViewModels;

namespace TaskDesk.Views.Tickets
{
    public class TicketsController(TaskDeskDbContext context)  : Controller
    {

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var tickets = await context.Tickets
                .AsNoTracking()
                .OrderByDescending(ticket => ticket.CreatedDate)
                .ThenByDescending(ticket => ticket.Id)
                .ToListAsync();

            return View(tickets);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new CreateTicketViewModel());
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateTicketViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var ticket = new Ticket
            {
                Title = model.Title.Trim(),
                Description = model.Description?.Trim() ?? "",
                Priority = model.Priority,
                Status = TicketStatus.Opened,
                CreatedDate = DateTime.UtcNow
            };

            context.Tickets.Add(ticket);
            await context.SaveChangesAsync();

            TempData["Success"] = "Заявка создана";

            return RedirectToAction(nameof(Index));
        }
    }
}
