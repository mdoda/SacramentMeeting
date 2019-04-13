using System;
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
            Songs = new SelectList(_context.Hymn, "Title", "Title");
            Members = new SelectList(_context.Member, "Name", "Name");
            BishopricRoles = new SelectList(Constants.BishopricRoles);
        }

        public SelectList Songs { get; set; }
        public SelectList Members { get; set; }
        public SelectList BishopricRoles { get; set; }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Meeting Meeting { get; set; }

        public async Task<IActionResult> OnPostAsync(List<int> speakerIDs, List<string> topics)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Meeting.Add(Meeting);
            await _context.SaveChangesAsync();

            List<Speaker> speakers = new List<Speaker>();

            for(int i = 0; i < speakerIDs.Count; ++i)
            {
                speakers.Add(new Speaker()
                {
                    MeetingID = Meeting.ID,
                    MemberID = speakerIDs[i],
                    Topic = topics[i]
                });
            }

            _context.Speaker.AddRange(speakers);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}