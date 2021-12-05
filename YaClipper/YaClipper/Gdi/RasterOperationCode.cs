using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YaClipper.Gdi
{
    public enum RasterOperationCode
    {
        Black = 1,
        NotMergePen,
        MaskNotPen,
        NotCopyPen,
        MaskPenNot,
        Not,
        XorPen,
        NotMaskPen,
        MaskPen,
        NotXorPen,
        Nop,
        MergeNotPen,
        CopyPen,
        MergePenNot,
        MergePen,
        White,
        Last
    }
}
