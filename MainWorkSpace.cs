using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BJMT.Presentation;
using BJMT.Presentation.Options;
using System.Drawing;
using BJMT.CTC3.Infrastructure.Business.Types;

namespace BJMT.CTC3.Presentation
{
    /// <summary>
    /// 
    /// </summary>
    public static class MainWorkSpace
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="part"></param>
        public static void AddPart(Control part)
        {
            Guard.NotNull(Workbench.MainWorkspace, "Workbench.MainWorkspace");
            Guard.NotNull(part, "part");

            var attri = part.GetType().GetCustomAttributes(typeof(PartAttribute), false)
                .OfType<PartAttribute>().FirstOrDefault();

            Guard.NotNull(attri, "attri");

            part.Text = attri.Title;

            Workbench.MainWorkspace.Show(part, attri);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="part"></param>
        /// <param name="attri"></param>
        public static void AddPart(Control part, PartAttribute attri)
        {
            Guard.NotNull(Workbench.MainWorkspace, "Workbench.MainWorkspace");
            Guard.NotNull(part, "part");
            Guard.NotNull(attri, "attri");

            part.Text = attri.Title;

            Workbench.MainWorkspace.Show(part, attri);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static Control GetControl(PresentationControlType type)
        {
            foreach (var smartPart in Workbench.MainWorkspace.SmartParts)
            {
                var attr = smartPart.GetType().GetCustomAttributes(typeof(CtcPartAttribute), false).
                    OfType<CtcPartAttribute>().FirstOrDefault();

                if (attr == null) continue;

                if (attr.ControlType == (ushort)type) return smartPart as Control;
            }

            return null;
        }
    }
}
