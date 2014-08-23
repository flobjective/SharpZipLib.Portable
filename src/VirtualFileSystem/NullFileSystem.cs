#if PCL
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ICSharpCode.SharpZipLib.VirtualFileSystem
{

    /// <summary>
    /// Empty file system
    /// </summary>
    public class NullFileSystem : IVirtualFileSystem
    {

        /// <summary>
        /// List directory files
        /// </summary>
        public IEnumerable<String> GetFiles(string directory)
        {
            throw new InvalidOperationException();
        }

        /// <summary>
        /// List directories
        /// </summary>
        public IEnumerable<String> GetDirectories(string directory)
        {
            throw new InvalidOperationException();
        }

        /// <summary>
        /// Create a temporary file name
        /// </summary>
        public string GetTempFileName()
        {
            throw new InvalidOperationException();
        }

        /// <summary>
        /// Copy a file
        /// </summary>
        public void CopyFile(string fromFileName, string toFileName, bool overwrite)
        {
            throw new InvalidOperationException();
        }

        /// <summary>
        /// Move a file
        /// </summary>
        public void MoveFile(string fromFileName, string toFileName)
        {
            throw new InvalidOperationException();
        }

        /// <summary>
        /// Delete a file
        /// </summary>
        public void DeleteFile(string fileName)
        {
            throw new InvalidOperationException();
        }

        /// <summary>
        /// Get the full path for a file
        /// </summary>
        public string GetFullPath(string path)
        {
            return path;
        }

        /// <summary>
        /// Get the informations of a file
        /// </summary>
        public IFileInfo GetFileInfo(string filename)
        {
            throw new InvalidOperationException();
        }

        /// <summary>
        /// Get the informations of a directory
        /// </summary>
        public IDirectoryInfo GetDirectoryInfo(string directoryName)
        {
            throw new InvalidOperationException();
        }

        /// <summary>
        /// Define the last write time
        /// </summary>
        public void SetLastWriteTime(string name, DateTime dateTime)
        {
            throw new InvalidOperationException();
        }

        /// <summary>
        /// Define the attributes
        /// </summary>
        /// <param name="name"></param>
        /// <param name="attributes"></param>
        public void SetAttributes(string name, FileAttributes attributes)
        {
            throw new InvalidOperationException();
        }

        /// <summary>
        /// Create a new directory
        /// </summary>
        public void CreateDirectory(string directory)
        {
            throw new InvalidOperationException();
        }

        /// <summary>
        /// Create a new file
        /// </summary>
        public VfsStream CreateFile(string filename)
        {
            throw new InvalidOperationException();
        }

        /// <summary>
        /// Open a file for read
        /// </summary>
        public VfsStream OpenReadFile(string filename)
        {
            throw new InvalidOperationException();
        }

        /// <summary>
        /// Open an existing file for writing
        /// </summary>
        public VfsStream OpenWriteFile(string filename)
        {
            throw new InvalidOperationException();
        }

        /// <summary>
        /// Current directory
        /// </summary>
        public String CurrentDirectory { get { throw new InvalidOperationException(); } }


        /// <summary>
        /// Directory separator
        /// </summary>
        public Char DirectorySeparatorChar { get { throw new InvalidOperationException(); } }

    }

}
#endif
