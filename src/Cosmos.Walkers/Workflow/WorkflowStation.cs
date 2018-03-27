using System;
using System.Collections.Generic;
using Cosmos.Walkers.Workflow.Nodes;

namespace Cosmos.Walkers.Workflow {
    public class WorkflowStation : IWorkflowStation<string> {
        private readonly Node _rootNode;
        private readonly List<Node> _registeredNodeList;

        public WorkflowStation(string id, Node rootNode) {
            _rootNode = rootNode ?? throw new ArgumentNullException(nameof(rootNode));
            _registeredNodeList = new List<Node> {_rootNode};
            Id = id;
            Name = _rootNode.Name;
            _rootNode.UpdateWorkflowContainer(this);
        }

        public IFlowChartNode<string> Root => _rootNode;

        public string Id { get; }
        public string Name { get; }

        public override int GetHashCode() {
            return Id.GetHashCode();
        }
    }
}