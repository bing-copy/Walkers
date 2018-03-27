namespace Cosmos.Walkers.Workflow {
    public interface IWorkflowStation<T> {
        T Id { get; }
        string Name { get; }
    }
}