using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    public class TrafficLight
    {
        [NextSignal("Green")]
        public string Red { get; set; } = "Red";

        [NextSignal("Yellow")]
        public string Green { get; set; } = "Green";

        [NextSignal("Red")]
        public string Yellow { get; set; } = "Yellow";

        private string currentSignal;

        public TrafficLight(string initialSignal)
        {
            currentSignal = initialSignal;
        }

        public void ChangeSignal()
        {
            Type type = this.GetType();
            PropertyInfo currentProperty = type.GetProperty(currentSignal);
            NextSignalAttribute nextSignalAttr = currentProperty.GetCustomAttribute<NextSignalAttribute>();

            currentSignal = nextSignalAttr.Next;
        }

        public string GetCurrentSignal()
        {
            return currentSignal;
        }
    }
}
