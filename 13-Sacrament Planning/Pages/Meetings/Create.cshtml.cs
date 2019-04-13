﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using _13_Sacrament_Planning.Models;

namespace _13_Sacrament_Planning.Pages.Meetings
{
    public class CreateModel : PageModel
    {
        private readonly _13_Sacrament_Planning.Models.SacramentPlanningContext _context;

        public CreateModel(_13_Sacrament_Planning.Models.SacramentPlanningContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["Songs"] = new SelectList(_context.Hymn, "Title", "Title");
            ViewData["Members"] = new SelectList(_context.Member, "Name", "Name");
            ViewData["BishopricRoles"] = new SelectList(Constants.BishopricRoles);
            return Page();
        }

        [BindProperty]
        public Meeting Meeting { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Meeting.Add(Meeting);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}