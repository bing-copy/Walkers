using System;
using Cosmos.Walkers.Workflow.Nodes.Extensions;

namespace Cosmos.Walkers.Workflow.Nodes.BuildInNodes {
    public sealed class StartNode : IBuildInNode<string> {
        private readonly IWorkflowStation<string> _station;

        public StartNode(IWorkflowStation<string> station) {
            _station = station ?? throw new ArgumentNullException(nameof(station));
        }

        public string Id => "__COSMOS_Start_Node";
        public string Key => "COSMOS_START";
        public string Name => "Cosmos Start Node";

        public bool IsBuildIn => true;
        public bool IsRoot => false;
        public IWorkflowStation<string> Workflow => _station;
        public IFlowChartNode<string> GetRoot() => _station.Root;

        public void Start() {
            Workflow.Root?.Next(Workflow.CreateContext()).GetAwaiter().GetResult();
        }
    }
}