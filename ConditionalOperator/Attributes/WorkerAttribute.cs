using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalOperator.Attributes
{
    [System.AttributeUsage(System.AttributeTargets.Class |
                           System.AttributeTargets.Struct)
    ]
    public class WorkerAttribute : Attribute
    {
        public AttributeStates State { get; private set; }
        public int Order { get; private set; }

        public WorkerAttribute(AttributeStates state)
        {
            State = state;
        }

        public WorkerAttribute(AttributeStates state, int order)
        {
            State = state;
            Order = order;
        }

        public WorkerAttribute(int order)
        {
            State = AttributeStates.Active;
            Order = order;
        }

        public WorkerAttribute()
        {
            State = AttributeStates.Active;
            Order = 0;
        }
    }
}
