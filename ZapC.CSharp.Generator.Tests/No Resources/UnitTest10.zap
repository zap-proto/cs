@0xbbfd48ae4b99d012;

using Cxx = import "/zap/c++.zap";

$Cxx.namespace("Foo::Bar::Baz");

struct Outer {
	inner @0: import "UnitTest10b.zap".Inner ;
}
