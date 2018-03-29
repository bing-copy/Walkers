namespace Cosmos.Walkers.Workflow.Nodes {
    public abstract class ChangeStateNode : Node {

        protected ChangeStateNode(string id, string key, string name) : base(id, key, name) { }
    }
}