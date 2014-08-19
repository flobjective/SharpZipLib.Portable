#if PCLx
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICSharpCode.SharpZipLib.VirtualFileSystem
{
    /// <summary>
    /// File informations
    /// </summary>
    public interface IFileInfo
    {
        /// <summary>
        /// File name
        /// </summary>
        String Name { get; }
        /// <summary>
        /// File attributes
        /// </summary>
        FileAttributes Attributes { get; }
    }
}
#endif