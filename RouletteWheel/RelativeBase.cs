using System.Collections.Generic;

namespace RouletteWheel{
	public abstract class RelativeBase<T> {
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

		public RelativeBase(RandGenerator randGenerator){
			this.randGenerator = randGenerator;
			pockets = new List<Pocket<T>>();
			totalSize = 0;
		}

		public RelativeBase<T> AddPocket(int size, T prize){
			if(size < 0)
				throw new System.Exception("size < 0");
			pockets.Add(new Pocket<T>(size, prize));
			totalSize += size;
			return this;
		}

		public void RemovePocket (Pocket<T> pocket) {
			pockets.Remove (pocket);
			totalSize -= pocket.Size;
		}

		public bool HasPockets {
			get { return pockets.Count > 0; }
		}

		public abstract T Spin ();

		protected Pocket<T> SelectPocket() {
			int indicator = randGenerator.Int(totalSize);
			foreach(var each in pockets){
				indicator -= each.Size;
				if(indicator < 0)
					return each;
			}
			throw new System.Exception("total size is " + totalSize);
		}
	}
}