using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICSharpCode.SharpZipLib.VirtualFileSystem
{
    /// <summary>
    /// Virtual File System Stream
    /// </summary>
    public abstract class VfsStream : Stream
    {
        /// <summary>
        /// Name of file name
        /// </summary>
        public abstract String Name { get; }
    }

}
