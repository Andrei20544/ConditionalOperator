using ConditionalOperator.Workers;

namespace ConditionalOperator.Model
{
    public class WorkerInfo
    {
        public string WorkerName { get; set; }
        public Type WorkerType { get; set; }
        public IWorkBase Adapter { get; set; }
        public Attributes.AttributeStates State { get; set; }
        public int Order { get; set; }
    }
}
