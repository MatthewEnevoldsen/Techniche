using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Techniche.Widgets;

namespace Techniche
{
    public class System
    {
        public string BuildBill(ICollection<Widget> widgets)
        {
            try
            {
                Validate(widgets);
                return @"----------------------------------------------------------------
Bill of Materials
----------------------------------------------------------------
" + string.Join("\r\n", widgets) + @"
----------------------------------------------------------------";
            }
            catch (Exception e)
            {
                File.WriteAllText(DateTime.Now.ToString("yyyy-dd-M--HH-mm-ss") + ".txt",
                    e.ToString());
                return "+++++Abort+++++";
            }
        }

        public void Validate(ICollection<Widget> widgets)
        {
            var invalidWidgets = widgets.Where(w => !w.Validate());

            foreach (var widget in widgets)
                if (!widget.Validate())
                    throw new ArgumentException($"Invalid widgets found: {string.Join("\n", invalidWidgets)}");
        }
    }
}