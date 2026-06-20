@0xf463d204f5208b43;
$import "/zap/c++.zap".namespace("UnitTest4");

interface Node {
	getInfo @0 () -> Info;
}

struct Info {
	node @0 :Node;
	classes @1 :Classes;
}

struct Classes {
	i1 @0 :import "UnitTest4b.zap".I1.Classes;
	i2 @1: Void;
}