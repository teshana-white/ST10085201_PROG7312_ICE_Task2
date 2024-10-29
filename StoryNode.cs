using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICE_Task2_LinkedLists
{
    public class StoryNode
    {
        public int Number { get; set; }
        public string Text { get; set; }

        public StoryNode(int number, string text)
        {
            Number = number;
            Text = text;
        }

        public override string ToString()
        {
            return $"{Number}: {Text}";
        }
    }
}
