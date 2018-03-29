using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Cosmos.Walkers.Workflow.FlowInterfaces;

namespace Cosmos.Walkers.Workflow.Nodes {
    public class SwitchNode : ConditionNode, ISwitchFlow<Node> {
        protected SwitchNode(string id, string key, string name) : base(id, key, name) { }

        public void SetCaseCondition(string matchedValue, Node matchedNode, int index = -1) {
            if (matchedNode == null) throw new ArgumentNullException(nameof(matchedNode));
            matchedNode.CheckSelf();
        }

        public void SetDefaultCondition(Node matchedNode) {
            if (matchedNode == null) throw new ArgumentNullException(nameof(matchedNode));
            matchedNode.CheckSelf();

        }

        public override async Task Next(WorkflowContext context) {
            //todo
        }

        public override void AppendParent(IFlowChartNode<string> node) {
            throw new InvalidOperationException($"Cannot call {nameof(AppendParent)} in {nameof(SwitchNode)} instance.");
        }

        public override void AppendParents(IEnumerable<IFlowChartNode<string>> nodes) {
            throw new InvalidOperationException($"Cannot call {nameof(AppendParents)} in {nameof(SwitchNode)} instance.");
        }

        public override void AppendChild(IFlowChartNode<string> node) {
            throw new InvalidOperationException($"Cannot call {nameof(AppendChild)} in {nameof(SwitchNode)} instance.");
        }

        public override void AppendChildren(IEnumerable<IFlowChartNode<string>> nodes) {
            throw new InvalidOperationException($"Cannot call {nameof(AppendChildren)} in {nameof(SwitchNode)} instance.");
        }
    }
}