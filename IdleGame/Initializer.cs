using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdleGame
{
    class Initializer
    {
        public void Initialize() {
            MenuTree.root = new TreeNode(null, null, null);
        }
    }
}
