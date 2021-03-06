﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using _13_Sacrament_Planning.Models;

namespace _13_Sacrament_Planning.Pages.Meetings
{
    public class EditModel : PageModel
    {
        private readonly _13_Sacrament_Planning.Models.SacramentPlanningContext _context;

        public EditModel(_13_Sacrament_Planning.Models.SacramentPlanningContext context)
        {
            _context = context;
            Songs = new SelectList(_context.Hymn, "Title", "Title");
            Members = new SelectList(_context.Member, "Name", "Name");
            BishopricRoles = new SelectList(Constants.BishopricRoles);
        }

        public SelectList Songs { get; set; }
        public SelectList Members { get; set; }
        public SelectList BishopricRoles { get; set; }

        [BindProperty]
        public Meeting Meeting { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
    
            if (id == null)
            {
                return NotFound();
            }


            Meeting = await _context.Meeting
                                    .Include(m => m.Speakers)
                                    .ThenInclude(s => s.Member)
                                    .AsNoTracking()
                                    .FirstOrDefaultAsync(m => m.ID == id);

            if (Meeting == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Meeting).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MeetingExists(Meeting.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool MeetingExists(int id)
        {
            return _context.Meeting.Any(e => e.ID == id);
        }
    }
}
