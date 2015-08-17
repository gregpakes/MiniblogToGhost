using System.Collections.Generic;
using MiniblogToGhost.Miniblog;

namespace MiniblogToGhost.Miniblog
{
    public class PostAnalysis
    {
        public int Successes { get; set; }

        public int Failures { get; set; }

        public List<post> Posts { get; set; }
    }
}