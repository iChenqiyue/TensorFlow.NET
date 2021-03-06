﻿using System;
using System.Runtime.InteropServices;

namespace Tensorflow
{
    public struct TF_Tensor
    {
        IntPtr _handle;

        public TF_Tensor(IntPtr handle)
            => _handle = handle;

        public static implicit operator TF_Tensor(IntPtr handle)
            => new TF_Tensor(handle);

        public static implicit operator IntPtr(TF_Tensor tensor)
            => tensor._handle;

        public override string ToString()
            => $"TF_Tensor {_handle}";
    }
}
