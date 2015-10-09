using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace RevStack.IO
{
    public class IODataContext
    {
        private readonly string _path;
        private readonly string _searchPattern;
        private readonly SearchOption _searchOption;
        public IODataContext(string path, string searchPattern,SearchOption searchOption)
        {
            _path = path;
            _searchPattern = searchPattern;
            _searchOption = searchOption;
        }

        public IEnumerable<FileData> Get()
        {
            return FastDirectoryEnumerator.EnumerateFiles(_path, _searchPattern, _searchOption);
        }
    }
}
