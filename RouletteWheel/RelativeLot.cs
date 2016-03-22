using System.Collections.Generic;

namespace RouletteWheel{
	public class RelativeLot<T> : RelativeBase<T> {
		public RelativeLot(RandGenerator randGenerator) : base(randGenerator) {
		}

		public override T Spin(){
			var pocket = SelectPocket ();
			RemovePocket (pocket);
			return pocket.Prize;
		}
	}
}