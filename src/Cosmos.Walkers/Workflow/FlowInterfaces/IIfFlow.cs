namespace Cosmos.Walkers.Workflow.FlowInterfaces {
    public interface IIfFlow<in TNextNode> {
        void SetIfCondition(string matchedValue, TNextNode matchedNode);
        void SetElseIfCondition(string matchedValue, TNextNode matchedNode, int index = -1);
        void SetElseCondition(TNextNode matchedNode);
    }
}