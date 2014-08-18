using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICSharpCode.SharpZipLib.VirtualFileSystem
{
    /// <summary>
    /// Virtual File System singleton
    /// </summary>
    public static class VirtualFileSystem
    {
        private static IVirtualFileSystem _Current;

        /// <summary>
        /// Define the current VFS
        /// </summary>
        public static void SetCurrent(IVirtualFileSystem vfs)
        {
            _Current = vfs; 
        }

        /// <summary>
        /// Current VFS
        /// </summary>
        public static IVirtualFileSystem Current
        {
            get { return _Current ?? (_Current = new EmptyFileSystem()); }
        }

    }
}
