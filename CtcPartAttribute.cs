using System;
using BJMT.CTC3.Infrastructure.Business.Types;
using BJMT.Presentation;
using BJMT.Utility;

namespace BJMT.CTC3.Presentation
{
    

    /// <summary>
    /// 
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class CtcPartAttribute :PartAttribute
    {
        /// <summary>
        /// 
        /// </summary>
        public CtcPartAttribute(PresentationControlType controlType )
        {
            base.ControlType = (ushort)controlType;
            Title = EnumUtility.GetDescription(controlType);
        }       
    }
}
