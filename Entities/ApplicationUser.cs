﻿using Microsoft.AspNetCore.Identity;

namespace InvitaTest.Models
{
    public class ApplicationUser : IdentityUser
    {
        public List<Event>? Events { get; set; }
    }
}
