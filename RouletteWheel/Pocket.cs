
namespace RouletteWheel{
	public class Pocket<T> {
		int size;
		T prize;

		public int Size {
			get {
				return size;
			}
		}

		public T Prize {
			get {
				return prize;
			}
		}

		public Pocket (int size, T prize)
		{
			this.size = size;
			this.prize = prize;
		}
	}
}