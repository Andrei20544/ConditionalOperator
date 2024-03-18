using ConditionalOperator.Attributes;
using ConditionalOperator.Model;
using ConditionalOperator.Workers;
using System.Reflection;

namespace ConditionalOperator
{
    public class WorkerEngine
    {
        public WorkerEngine() { }

        public void StartWorkers()
        {
            var workerTypes = Assembly.GetEntryAssembly().GetTypes();
            var workers = GetWorkers(workerTypes);

            if (workers == null || workers?.Count() == 0)
                Console.WriteLine("Задачи не найдены.");

            foreach (var worker in workers.OrderBy(x => x.Order))
            {
                if (worker.State == AttributeStates.NonActive)
                    continue;

                Console.WriteLine("\nЗадание номер: {0}", worker.Order);
                worker.Adapter.DoWork();
            }

            Console.WriteLine("...Конец программы");
        }

        private IEnumerable<WorkerInfo> GetWorkers(Type[] workersTypes)
        {
            var custom =
            from t in workersTypes
            let workAttribute = t.GetCustomAttributes(typeof(WorkerAttribute), true).FirstOrDefault() as WorkerAttribute
            where workAttribute != null
                select new WorkerInfo
                {
                    WorkerType = t,
                    WorkerName = t.Name,
                    State = workAttribute.State,
                    Order = workAttribute.Order
                };

            return custom.Select(c => {
                IniciateWorker(c);
                return c;
            });
        }

        private static void IniciateWorker(WorkerInfo workerInfo) =>
            workerInfo.Adapter = workerInfo.WorkerType?.GetConstructor(Type.EmptyTypes)?.Invoke(null) as IWorkBase;
    }
}
