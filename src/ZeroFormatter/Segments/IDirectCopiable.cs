﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroFormatter.Segments
{
    public interface IZeroFormatterSegment
    {
        /// <summary>Can use inner buffer?</summary>
        bool CanDirectCopy();

        /// <summary>If CanDirectCopy, to use the original buffer.</summary>
        ArraySegment<byte> GetBufferReference();

        /// <summary>If can not DirectCopy, use this Serialize.</summary>
        int Serialize(ref byte[] targetBytes, int offset);
    }
}
