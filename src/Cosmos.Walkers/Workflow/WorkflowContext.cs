using System;

namespace Cosmos.Walkers.Workflow {
    public class WorkflowContext {
        public WorkflowContext(WalkerContext context) {
            WalkerContext = context ?? throw new ArgumentNullException(nameof(context));
        }

        public WalkerContext WalkerContext { get; }
    }
}