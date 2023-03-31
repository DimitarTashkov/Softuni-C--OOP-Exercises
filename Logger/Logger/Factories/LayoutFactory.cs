using Log.Layouts;
using Log.Layouts.Interfaces;
using Logger.CustomLayout;
using Logger.Factories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Factories
{
    public class LayoutFactory : ILayoutFactory
    {
        public ILayout CreateLayout(string type)
        {
            switch (type)
            {
                case "SimpleLayout": return new SimpleLayout();
                case "XmlLayout": return new XmlLayout();
                default: throw new InvalidOperationException("Invalid layout type");
            }
        } 
    }
}
