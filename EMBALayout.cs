using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FISCA;
using System.Xml.Linq;

namespace UIOrder
{
    class EMBALayout : ILayoutProvider
    {
        #region ILayoutProvider 成員

        public System.Xml.Linq.XElement LayoutDescription
        {
            get {
                return XElement.Parse(Properties.Resources.LayoutDescription);
            }
        }

        #endregion
    }
}
