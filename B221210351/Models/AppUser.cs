﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace B221210351.Models
{
    public class AppUser : IdentityUser<int>
    {
        public AppUser() 
        {
            Appointments = new HashSet<Appointment>();
        }
        public string PatientPersonalId { get; set; }
        public string PatientName { get; set; }
        public string PatientSurname { get; set; }
        public bool PatientGender { get; set; }
        public DateTime PatientBirthDay { get; set; }
        public ICollection<Appointment> Appointments { get; set; }
    }
}
