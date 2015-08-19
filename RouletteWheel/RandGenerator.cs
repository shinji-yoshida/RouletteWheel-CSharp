
namespace RouletteWheel{
	public interface RandGenerator {
		/// <summary>
		/// generate random int( 0 <= random_value < n )
		/// </summary>
		int Int (int n);

		/// <summary>
		/// generate random float( 0 <= random_value < 1 )
		/// </summary>
		float Float();
	}
}
