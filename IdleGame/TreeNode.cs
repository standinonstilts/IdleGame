using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdleGame
{
    class TreeNode
    {
        public Menu menu;
        public TreeNode parent;
        public Dictionary<int, TreeNode> children;
        public TreeNode(Menu m, TreeNode p, Dictionary<int, TreeNode> c)
        {
            menu = m;
            parent = p;
            children = c;
        }
    }
}
