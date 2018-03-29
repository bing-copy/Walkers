using System;

namespace Cosmos.Walkers.Workflow.Nodes.BuildInNodes {
    public sealed class EndNode : IBuildInNode<string> {
        private readonly IWorkflowStation<string> _station;

        public EndNode(IWorkflowStation<string> station) {
            _station = station ?? throw new ArgumentNullException(nameof(station));
        }

        public string Id => "__COSMOS_End_Node";
        public string Key => "COSMOS_END";
        public string Name => "Cosmos End Node";

        public bool IsBuildIn => true;
        public bool IsRoot => false;
        public IWorkflowStation<string> Workflow => _station;
        public IFlowChartNode<string> GetRoot() => _station.Root;
        
        
    }
}