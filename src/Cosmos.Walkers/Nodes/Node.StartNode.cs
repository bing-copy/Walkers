namespace Cosmos.Walkers.Nodes {
    public sealed class StartNode : Node {
        public StartNode() {
            Id = "__COSMOS_start_node";
            ParentId = "__COSMOS_kami_sama";
        }

        public override bool IsBuildInNode => true;

    }
}