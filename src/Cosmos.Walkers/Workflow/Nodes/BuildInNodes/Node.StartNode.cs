namespace Cosmos.Walkers.Workflow.Nodes.BuildInNodes {
    public sealed class StartNode : IBuildInNode<string> {
        public string Id => "__COSMOS_Start_Node";
        public string Key => "COSMOS_START";
        public string Name => "Cosmos Start Node";

        public bool IsBuildIn => true;
    }
}