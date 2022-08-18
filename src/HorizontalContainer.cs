using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imageConverter.src
{
    public class HorizontalContainer
    {
        public List<Control> elements;

        public HorizontalContainer()
        {
            elements = new List<Control>();
        }

        public HorizontalContainer(params Control[] items)
        {
            elements = new List<Control>();
            elements.AddRange(items);
        }

        public void add(params Control[] controls)
        {
            elements.AddRange(controls);
            return;
        }

        private int getMidlineLeftX(int midlineX, Control item)
        {
            return midlineX - item.Width / 2;
        }

        public void autoArrange(int width)
        {
            int unitWidth = width / (elements.Count + 1);
            int midlineX = unitWidth;
            int x = 0;
            for (int i = 0; i < elements.Count; i++)
            {
                x = getMidlineLeftX(midlineX, elements[i]);
                elements[i].Location = new Point(x, elements[i].Location.Y);
                midlineX += unitWidth;
            }
        }
    }
}
