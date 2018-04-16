namespace Cosmos.Walkers.Workflow {
    public static class WorkflowContextFactory {
        public static WorkflowContext Create<T>(IWorkflowStation<T> workflow) {
            return new WorkflowContext(workflow.ExportWalkerContext());
        }
    }
}