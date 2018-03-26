namespace Cosmos.Walkers.Nodes {
    public abstract class Node {
        public virtual bool IsRoot => false;
        public virtual bool IsBuildInNode => false;
        public string Id { get; set; }
        public string ParentId { get; set; }
    }
}