using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Node
    {
        //her nodun bir karakteri var.
        public char Character { get; set; }

        //Bu nodun aynı zamanda bir kelime olup olmadığını belirleye prop
        public bool IsWord { get; set; }
        //Var sa alt nodelar
        public List<Node> SubNodes = new List<Node>();
    }
}
