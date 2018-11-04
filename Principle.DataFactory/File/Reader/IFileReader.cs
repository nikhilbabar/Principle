using System.Collections.Generic;
using System.Data;

namespace Principle.DataFactory.File.Reader
{
    public interface IFileReader
    {
        List<string> GetFileHeader(string filePath);
        DataTable GetFileData(string filePath);
    }
}
