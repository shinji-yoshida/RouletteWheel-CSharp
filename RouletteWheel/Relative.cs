using System.Collections.Generic;

namespace RouletteWheel{
	public class Relative<T> : RelativeBase<T> {
		public Relative(RandGenerator randGenerator) : base(randGenerator){
		}

		public override T Spin(){
			return SelectPocket ().Prize;
		}
	}
}