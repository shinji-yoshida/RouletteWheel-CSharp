using System;
using gotanda;

namespace RouletteWheel{
	public class Roulette {
		public static Roulette soleInstance = new Roulette();

		public static Roulette Instance {
			get { return soleInstance; }
		}

		RandGenerator randGenerator;

		public Roulette(RandGenerator randGenerator){
			this.randGenerator = randGenerator;
		}
		
		public Roulette() : this(new SystemRandGenerator()){
		}

		public Relative<T> CreateRelativeProb<T>(Action<Relative<T>> setup){
			var result = new Relative<T>(randGenerator);
			setup(result);
			return result;
		}

		public bool Binary(float probability) {
			Assertion._assert_(probability >= 0);
			Assertion._assert_(probability <= 1);
			return randGenerator.Float() < probability;
		}
	}
}