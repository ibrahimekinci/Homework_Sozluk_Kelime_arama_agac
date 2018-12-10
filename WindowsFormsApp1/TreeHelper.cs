using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class TreeHelper
    {
        public List<Node> nodes = new List<Node>();
        public void addNode(string word)
        {
            if (string.IsNullOrWhiteSpace(word))
                return;
            else
                word = word.Trim().ToUpper();

            List<Node> temp = nodes;
            for (int i = 0; i < word.Length; i++)
            {
                bool isAddNode = false;

                foreach (Node item in temp)
                {
                    if (word[i] == item.Character)
                    {
                        temp = item.SubNodes;

                        isAddNode = true;
                        if (i == word.Length - 1)
                            item.IsWord = true;

                        break;
                    }
                }

                if (!isAddNode)
                {
                    Node node = new Node();
                    node.Character = word[i];
                    if (i == word.Length - 1)
                        node.IsWord = true;
                    temp.Add(node);
                    temp = node.SubNodes;
                }
            }

        }
        public List<string> GetWords(string word)
        {
            if (string.IsNullOrWhiteSpace(word))
                return null;
            else
                word = word.Trim().ToUpper();


            List<Node> temp = nodes;
            bool isMatch;
            for (int i = 0; i < word.Length; i++)
            {
                isMatch = false;

                foreach (Node item in temp)
                {
                    if (word[i] == item.Character)
                    {
                        temp = item.SubNodes;
                        isMatch = true;
                        break;
                    }
                }

                if (!isMatch)
                    return null;
            }

            return treeGet(temp, word);
        }
        private List<string> treeGet(List<Node> nodes, string word)
        {
            List<string> result = new List<string>();
            foreach (var item in nodes)
            {
                if (item.IsWord)
                    result.Add(word + item.Character);
                var temp = treeGet(item.SubNodes, word + item.Character);
                foreach (string str in temp)
                {
                    result.Add(str);
                }
            }
            return result;
        }
    }

}
