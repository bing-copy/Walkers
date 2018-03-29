using Cosmos.Walkers.Workflow.Nodes;
using Cosmos.Walkers.Workflow.Nodes.BuildInNodes;

namespace Cosmos.Walkers.Workflow {
    public interface IWorkflowStation<T> {
        T Id { get; }
        string Name { get; }
        IFlowChartNode<T> Root { get; }
        StartNode GetStarter();
        WalkerContext ExportWalkerContext();
    }
}