namespace Cosmos.Walkers.Workflow.Nodes.Extensions {
    public static class WorkflowStationExtensions {
        public static WorkflowContext CreateContext<T>(this IWorkflowStation<T> workflow) {
            return WorkflowContextFactory.Create(workflow);
        }
    }
}