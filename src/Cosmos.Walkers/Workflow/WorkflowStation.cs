using System;
using System.Collections.Generic;
using Cosmos.Walkers.Workflow.Nodes;
using Cosmos.Walkers.Workflow.Nodes.BuildInNodes;

namespace Cosmos.Walkers.Workflow {
    public class WorkflowStation : IWorkflowStation<string> {
        private readonly WalkerContext _walkerContext;
        private readonly NormalNode _rootNode;
        private readonly List<Node> _registeredNodeList;
        private readonly StartNode _startNode;
        private readonly EndNode _endNode;

        public WorkflowStation(string id, NormalNode rootNode, WalkerContext context) {
            _walkerContext = context ?? throw new ArgumentNullException(nameof(context));
            _rootNode = rootNode ?? throw new ArgumentNullException(nameof(rootNode));
            _registeredNodeList = new List<Node> {_rootNode};
            Id = id;
            Name = _rootNode.Name;
            _rootNode.IsRoot = true;
            _rootNode.UpdateWorkflowContainer(this);
            _startNode = new StartNode(this);
            _endNode = new EndNode(this);
        }

        public IFlowChartNode<string> Root => _rootNode;

        public string Id { get; }
        public string Name { get; }

        public StartNode GetStarter() => _startNode;
        public WalkerContext ExportWalkerContext() => _walkerContext;

        public override int GetHashCode() => Id.GetHashCode();
    }
}