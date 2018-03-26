namespace Cosmos.Walkers.Nodes {
    public abstract class RootNode : Node {
        protected RootNode() {
            ParentId = "__COSMOS_start_node";
        }

        public override bool IsRoot => true;
    }
}