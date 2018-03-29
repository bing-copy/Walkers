namespace Cosmos.Walkers.Workflow.Nodes {
    public interface INode<out T> {
        T Id { get; }
        string Key { get; }
        string Name { get; }
        
        bool IsBuildIn { get; }
        bool IsRoot { get; }
    }
}