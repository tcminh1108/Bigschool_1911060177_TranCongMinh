using Bigschool_1911060177_TranCongMinh.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bigschool_1911060177_TranCongMinh.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}