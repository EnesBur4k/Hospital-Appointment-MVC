﻿using B221210351.Models;

namespace B221210351.Areas.YonetimPaneli.Models.ViewModels
{
    public class AppDatasForAdminVM
    {
        public List<User> Users { get; set; }
        public List<Doctor> Doctors { get; set; }
        public List<Policlinic> Policlinics { get; set; }
        public List<Department> Departments { get; set; }
    }
}