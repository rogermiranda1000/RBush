using System.Collections.Generic;

namespace RBush
{
	public interface ISpatialDatabase<T> : ISpatialIndex<T>
	{
		bool Insert(T item);
		void Delete(T item);
		void Clear();

		void BulkLoad(IEnumerable<T> items);
	}
}