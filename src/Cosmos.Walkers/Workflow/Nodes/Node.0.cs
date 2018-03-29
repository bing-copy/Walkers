using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cosmos.Abstractions.Workflow;

namespace Cosmos.Walkers.Workflow.Nodes {
    public abstract class Node : IFlowChartNode<string>, IModifiable<string> {
        private readonly List<IFlowChartNode<string>> _parents;
        private readonly List<IFlowChartNode<string>> _children;

        protected Node(string id, string key, string name) {
            Id = id;
            Key = key;
            Name = name;
            _parents = new List<IFlowChartNode<string>>();
            _children = new List<IFlowChartNode<string>>();
        }

        public string Id { get; }
        public string Key { get; }
        public string Name { get; }

        public IWorkflowStation<string> Workflow { get; set; }
        public IDynamicFormsDesign DynamicFormsDesign { get; set; }
        public IReadOnlyList<IFlowChartNode<string>> Parents => _parents;
        public IReadOnlyList<IFlowChartNode<string>> Children => _children;
        public IEnumerable<string> ParentIdList => _parents.Select(x => x.Id);
        public IEnumerable<string> ChildIdList => _children.Select(x => x.Id);

        protected IFlowChartNode<string> GetFirstOrDefaultChild() {
            return _children.FirstOrDefault();
        }

        public virtual void CheckSelf() {
            if (string.IsNullOrWhiteSpace(Id)) throw new ArgumentNullException(nameof(Id));
            if (string.IsNullOrWhiteSpace(Key)) throw new ArgumentNullException(nameof(Key));
            if (string.IsNullOrWhiteSpace(Name)) throw new ArgumentNullException(nameof(Name));
        }

        public abstract Task Next(WorkflowContext context);
        public abstract Task Before(WorkflowContext context);
        public abstract Task After(WorkflowContext context);

        public virtual bool IsBuildIn => false;
        public virtual bool IsRoot { get; set; }

        public virtual void UpdateWorkflowContainer(IWorkflowStation<string> workflow) {
            if (Workflow == null || Workflow != workflow) {
                Workflow = workflow;
            }

            foreach (var item in _children) {
                if (item is IModifiable<string> child) {
                    child.UpdateWorkflowContainer(workflow);
                }
            }
        }

        public virtual void AppendParent(IFlowChartNode<string> node) {
            if (node == null) throw new ArgumentNullException(nameof(node));
            node.CheckSelf();
            if (_parents.Any(x => x.Id == node.Id)) return;
            _parents.Add(node);
        }

        public virtual void AppendParents(IEnumerable<IFlowChartNode<string>> nodes) {
            if (nodes == null) throw new ArgumentNullException(nameof(nodes));
            foreach (var item in nodes) {
                AppendParent(item);
            }
        }

        public virtual void AppendChild(IFlowChartNode<string> node) {
            if (node == null) throw new ArgumentNullException(nameof(node));
            node.CheckSelf();
            if (_children.Any(x => x.Id == node.Id)) return;
            _children.Add(node);
        }

        public virtual void AppendChildren(IEnumerable<IFlowChartNode<string>> nodes) {
            if (nodes == null) throw new ArgumentNullException(nameof(nodes));
            foreach (var item in nodes) {
                AppendChild(item);
            }
        }

        public virtual void RemoveParent(string id) {
            if (string.IsNullOrWhiteSpace(id)) return;
            RemoveParent(_parents.FirstOrDefault(x => x.Id == id));
        }

        public virtual void RemoveParent(IFlowChartNode<string> node) {
            if (node == null) return;
            _parents.Remove(node);
        }

        public virtual void RemoveChild(string id) {
            if (string.IsNullOrWhiteSpace(id)) return;
            RemoveChild(_children.FirstOrDefault(x => x.Id == id));
        }

        public virtual void RemoveChild(IFlowChartNode<string> node) {
            if (node == null) return;
            _children.Remove(node);
        }

        public virtual void RemoveAllParents() {
            _parents.Clear();
        }

        public virtual void RemoveAllChildren() {
            _children.Clear();
        }

        public override int GetHashCode() {
            return Id.GetHashCode();
        }
    }
}