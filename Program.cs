using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FISCA;

namespace UIOrder
{
    /// <summary>
    /// 設定 UI 的 順序，包含 DetailContent, RibbonBarItem, ....
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [MainMethod()]
        public static void Main()
        {
            CustomizationService.Register<ILayoutProvider>(new EMBALayout());
        }
    }
}
