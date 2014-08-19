#if PCLx
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICSharpCode.SharpZipLib.VirtualFileSystem
{

    /// <summary>
    /// Interface providing Virtual File System access
    /// </summary>
    public interface IVirtualFileSystem
    {

        /// <summary>
        /// Create an new file
        /// </summary>
        VfsStream CreateFile(String filename);

        /// <summary>
        /// Open file for read
        /// </summary>
        VfsStream OpenReadFile(String filename);

        /// <summary>
        /// Open existing file for write
        /// </summary>
        VfsStream OpenWriteFile(String filename);

    }

}
#endif