using System.Threading.Tasks;
using Cosmos.Walkers.Workflow.FlowInterfaces;

namespace Cosmos.Walkers.Workflow.Nodes {
    public class WhileNode : ConditionNode, IWhileFlow<Node> {
        protected WhileNode(string id, string key, string name) : base(id, key, name) { }
        public override Task Next(WorkflowContext context) {
            throw new System.NotImplementedException();
        }
    }
}