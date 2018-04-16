namespace Cosmos.Walkers.Workflow.FlowInterfaces {
    public interface ISwitchFlow<in TNextNode> {
        void SetCaseCondition(string matchedValue, TNextNode matchedNode, int index = -1);
        void SetDefaultCondition(TNextNode matchedNode);
    }
}