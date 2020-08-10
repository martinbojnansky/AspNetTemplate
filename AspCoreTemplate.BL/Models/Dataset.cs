using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspCoreTemplate.BL.Models
{
    public class Dataset<T>
    {
        public IEnumerable<T> Items { get; set; }
        public DatasetQuery<T> Query { get; set; }
        public DatasetEdits<T> Edits { get; set; }
    }

    public class DatasetQuery<T>
    {
        public int StartOffset { get; set; } = 0;
        public int PageSize { get; set; } = 0;
    }

    public class DatasetEdits<T>
    {
        public IList<DatasetEdit<T>> Add { get; set; }
        public IList<DatasetEdit<T>> Edit { get; set; }
        public IList<DatasetEdit<T>> Remove { get; set; }
    }

    public class DatasetEdit<T>
    {
        public int Id;
        public T Value;
    }
}
