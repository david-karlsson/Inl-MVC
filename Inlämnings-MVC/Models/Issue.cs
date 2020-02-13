using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inlämnings_MVC.Models
{
    public class Issue
    {
        public int ID { get; set; }

        public int CustomerID { get; set; }



        public string Description { get; set; }



        public IssueStatus IssueStatus { get; set; }

        public Customer Customer { get; set; }
    }
}
