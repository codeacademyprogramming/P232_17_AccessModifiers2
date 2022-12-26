using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    internal class Student:Human
    {
        public string GroupNo;

        public override string GetInfo()
        {
            string baseInfo = base.GetInfo();
            return $"{baseInfo} GroupNo: {GroupNo}";
        }
    }
}
