using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cosmos.Walkers.Workflow.Nodes {
    public abstract class NormalNode : Node {
        protected NormalNode(string id, string key, string name) : base(id, key, name) { }

        public override async Task Next(WorkflowContext context) {
            await Before(context);

            var next = GetFirstOrDefaultChild();

            if (next != null) {
                await next.Next(context);
            }

            await After(context);
        }

        public override void AppendParent(IFlowChartNode<string> node) {
            if (node == null) throw new ArgumentNullException(nameof(node));
            node.CheckSelf();
            RemoveAllParents();
            base.AppendParent(node);
        }

        public override void AppendParents(IEnumerable<IFlowChartNode<string>> nodes) {
            if (nodes == null) throw new ArgumentNullException(nameof(nodes));
            AppendParent(nodes.FirstOrDefault());
        }

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