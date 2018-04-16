namespace Cosmos.Walkers.Workflow.Nodes {
    public interface IBuildInNode<T> : INode<T> {
        IWorkflowStation<T> Workflow { get; }
        IFlowChartNode<T> GetRoot();
    }
}