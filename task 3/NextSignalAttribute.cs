using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    [AttributeUsage(AttributeTargets.Property)]
    public class NextSignalAttribute : Attribute
    {
        public string Next { get; }

        public NextSignalAttribute(string next)
        {
            Next = next;
        }
    }
}
