using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Glider7DataMergeTool
{
    public class Glider7Reading
    {
        private double time;
        public double Time
        {
            get { return this.time; }
        }

        public String line;
        public String Line
        {
            get { return this.line; }
        }

        public Glider7Reading(double time, String line)
        {
            this.time = time;
            this.line = line;
        }
    }
}
