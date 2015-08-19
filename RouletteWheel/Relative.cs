using System.Collections.Generic;

namespace RouletteWheel{
	public class Relative<T> {
		int totalSize;
		RandGenerator randGenerator;
		List<Pocket<T>> pockets;

		public List<Pocket<T>> Pockets {
			get {
				return new List<Pocket<T>>(pockets);
			}
		}

		public int TotalSize {
			get {
				return totalSize;
			}
		}

		public Relative(RandGenerator randGenerator){
			this.randGenerator = randGenerator;
			pockets = new List<Pocket<T>>();
			totalSize = 0;
		}

		public Relative<T> AddPocket(int size, T prize){
			if(size < 0)
				throw new System.Exception("size < 0");
			pockets.Add(new Pocket<T>(size, prize));
			totalSize += size;
			return this;
		}

		public T Spin(){
			int indicator = randGenerator.Int(totalSize);
			foreach(var each in pockets){
				indicator -= each.Size;
				if(indicator < 0)
					return each.Prize;
			}
			throw new System.Exception("total size is " + totalSize);
		}
	}
}