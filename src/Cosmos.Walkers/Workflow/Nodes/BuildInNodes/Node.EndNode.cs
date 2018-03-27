namespace Cosmos.Walkers.Workflow.Nodes.BuildInNodes {
    public sealed class EndNode : IBuildInNode<string> {
        public string Id => "__COSMOS_End_Node";
        public string Key => "COSMOS_END";
        public string Name => "Cosmos End Node";

        public bool IsBuildIn => true;
    }
}