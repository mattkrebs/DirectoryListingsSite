using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Medtonic.mStar.DirectoryListings
{
    public class DirectoryView
    {
        public bool Directories { get; set; }
        public List<DirectoryInfo> Dirs { get; set; }
        public List<FileInfo> Files { get; set; }
    }
}