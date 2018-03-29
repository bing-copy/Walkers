using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cosmos.Walkers.Workflow.Nodes {
    public class CombineNode : Node {

        public CombineNode(string id, string key, string name) : base(id, key, name) { }

        public override async Task Next(WorkflowContext context) {
            var next = GetFirstOrDefaultChild();
            if (next != null) {
                await next.Next(context);
            }
        }

        public override Task Before(WorkflowContext context) => Task.CompletedTask;

        public override Task After(WorkflowContext context) => Task.CompletedTask;

        public override void AppendChild(IFlowChartNode<string> node) {
            if (node == null) throw new ArgumentNullException(nameof(node));
            node.CheckSelf();
            RemoveAllChildren();
            base.AppendChild(node);
        }

        public override void AppendChildren(IEnumerable<IFlowChartNode<string>> nodes) {
            if (nodes == null) throw new ArgumentNullException(nameof(nodes));
            AppendChild(nodes.FirstOrDefault());
        }
    }
}