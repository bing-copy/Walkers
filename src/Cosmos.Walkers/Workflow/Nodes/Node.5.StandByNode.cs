using System.Threading.Tasks;

namespace Cosmos.Walkers.Workflow.Nodes {
    public class StandByNode : Node {

        public StandByNode(string id, string key, string name) : base(id, key, name) { }

        public override Task Next(WorkflowContext context) {
            throw new System.NotImplementedException();
        }

        public override Task Before(WorkflowContext context) => Task.CompletedTask;

        public override Task After(WorkflowContext context) => Task.CompletedTask;
    }
}