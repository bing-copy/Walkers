using System.Collections.Generic;

namespace Cosmos.Walkers.Nodes {
    public sealed class EndNode : Node {
        public EndNode() {
            Id = "__COSMOS_end_node";
            ParentId = "__COSMOS_several";
        }

        public List<string> SeveralParentIds { get; set; } = new List<string>();

        public override bool IsBuildInNode => true;
    }
}