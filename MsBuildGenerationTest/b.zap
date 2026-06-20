@0x83152e8eed443172;

using Common = import "common.zap".Common;
struct OuterB {
	interface B {
		methodB1 @0 () -> (a :Common.A);
	}
}
