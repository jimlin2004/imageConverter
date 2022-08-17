using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imageConverter
{
    public class HorizontalContainer
    {
        public List<Control> elements;

        public HorizontalContainer()
        {
            this.elements = new List<Control>();
        }

        public HorizontalContainer(params Control[] items)
        {
            this.elements = new List<Control>();
            this.elements.AddRange(items);
        }

        public void add(params Control[] controls)
        {
            this.elements.AddRange(controls);
            return;
        }

        private int getMidlineLeftX(int midlineX, Control item)
        {
            return midlineX - (item.Width / 2);
        }

        public void autoArrange(int width)
        {
            int unitWidth = width / (this.elements.Count + 1);
            int midlineX = unitWidth;
            int x = 0;
            for (int i = 0; i < this.elements.Count; i++)
            {
                x = this.getMidlineLeftX(midlineX, this.elements[i]);
                this.elements[i].Location = new Point(x, this.elements[i].Location.Y);
                midlineX += unitWidth;
            }
        }
    }
}
