using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericReviceForExam
{
    internal class GenericMethods
    {
        public static bool CopyInsert<T>(T e, uint idx,T[] src, T[] target)
        {
            // See if target array is big enough.
            if (target.Length < src.Length + 1)
                return false;
            // Copy src to target, inserting e at idx in the process.
            for (int i = 0, j = 0; i < src.Length; i++, j++)
            {
                if (i == idx)
                {
                    target[j] = e;
                    j++;
                }
                target[j] = src[i];
            }
            return true;
        }
    }
}
