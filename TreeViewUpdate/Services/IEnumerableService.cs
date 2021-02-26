using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TreeViewUpdate.Services
{
    public static class IEnumerableService
    {
        public static IList<TreeNode> BuildTree(this IEnumerable<TreeNode> nodes) 
        {
            var groups = nodes.GroupBy(x => (x.Tag as Entities.TreeViewUpdate).ParentId);

            var parentElements = groups.FirstOrDefault(x => x.Key.HasValue == false).ToList();
            if (parentElements.Count() > 0) 
            {
                var dict = groups.Where(x => x.Key.HasValue).ToDictionary(x => x.Key.Value, x => x.ToList());
                for (int i = 0; i < parentElements.Count; i++)
                    AddChildren(parentElements[i], dict);
            }
            return parentElements;
        }
        public static void AddChildren(TreeNode parent, IDictionary<int, List<TreeNode>> nodes) 
        {
            Entities.TreeViewUpdate nodeParent = parent.Tag as Entities.TreeViewUpdate;
            if (nodes.ContainsKey(nodeParent.Id))
            {
                var elements = nodes[nodeParent.Id].ToArray();
                parent.Nodes.AddRange(elements);

                for (int i = 0; i < elements.Count(); i++)
                {
                    AddChildren(elements[i], nodes);
                }
            }
            else 
            {
                parent.Nodes.Add("");
            }
        }
    }
}
