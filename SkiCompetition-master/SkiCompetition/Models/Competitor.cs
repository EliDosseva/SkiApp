using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkiCompetition.Models
{
    public class Competitor
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Sex { get; set; }
        public Team Team { get; set; }
        public int Place { get; set; }
        public int Points { get; set; }
        public List<Competition> Competitions { get; set; }
    }
}