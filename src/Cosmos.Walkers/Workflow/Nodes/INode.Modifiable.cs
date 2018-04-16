using System.Collections.Generic;

namespace Cosmos.Walkers.Workflow.Nodes {
    public interface IModifiable<T> : INode<T> {
        void UpdateWorkflowContainer(IWorkflowStation<T> workflow);
        void AppendParent(IFlowChartNode<T> node);
        void AppendParents(IEnumerable<IFlowChartNode<T>> nodes);
        void AppendChild(IFlowChartNode<T> node);
        void AppendChildren(IEnumerable<IFlowChartNode<T>> nodes);
        void RemoveParent(T id);
        void RemoveParent(IFlowChartNode<T> node);
        void RemoveChild(T id);
        void RemoveChild(IFlowChartNode<T> node);
        void RemoveAllParents();
        void RemoveAllChildren();
    }
}