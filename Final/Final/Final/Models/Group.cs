using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Final.Models
{
    public class Group
    {
        public virtual int GroupId { get; set; }
        public virtual string Name { get; set; }       

        public virtual AcademicPlan AcademicPlan { get; set; }
        public virtual int AcademicPlanId { get; set; }
    }
}