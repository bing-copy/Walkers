using System.Collections.Generic;

namespace Cosmos.Walkers.Workflow.Nodes.Extensions {
    public static class CheckSelfExtensions {
        public static void CheckSelves<T>(this IEnumerable<IFlowChartNode<T>> nodes) {
            foreach (var node in nodes) {
                node.CheckSelf();
            }
        }
    }
}