using System;

namespace RouletteWheel{
	public class SystemRandGenerator : RandGenerator {
		Random random;

		public SystemRandGenerator () : this(new Random()) {
		}

		public SystemRandGenerator (Random random) {
			this.random = random;
		}
		
		public int Int (int n) {
			return random.Next(n);
		}
		
		/// <summary>
		/// casting double to float changes nearly 1 to exactly 1.
		/// 
		/// (1.0 - 0.00000000001) != 1.0)
		///   ---> true.
		/// ((float)(1.0 - 0.00000000001) != 1.0f)
		///   ---> false.
		/// 
		/// this method returns 0 if casted value is exactly one (and it will happen in probability (1 / 10)^7.)
		/// </summary>
		public float Float () {
			var result = (float)random.NextDouble();
			return result == 1f ? 0 : result;
		}
	}
}