using System.Threading.Tasks;

namespace Cosmos.Walkers.Workflow.Nodes {
    public abstract class ConditionNode : Node {

        protected ConditionNode(string id, string key, string name) : base(id, key, name) { }

        public override Task Before(WorkflowContext context) => Task.CompletedTask;

        public override Task After(WorkflowContext context) => Task.CompletedTask;

    }
}