using System.Collections.Generic;
using Cosmos.Abstractions.Workflow;

namespace Cosmos.Walkers.Workflow.Nodes {
    public interface IFlowChartNode<T> : INode<T> {
        IWorkflowStation<T> Workflow { get; set; }
        IDynamicFormsDesign DynamicFormsDesign { get; set; }
        IReadOnlyList<IFlowChartNode<T>> Parents { get; }
        IReadOnlyList<IFlowChartNode<T>> Children { get; }
        IEnumerable<T> ParentIdList { get; }
        IEnumerable<T> ChildIdList { get; }

        void CheckSelf();
    }
}