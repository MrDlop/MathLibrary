#pragma once
#include <cmath>

namespace emsp {
	class Vector
	{
	public:
		float x = 0, y = 0;
		Vector(float x, float y);
		Vector(float length, float a, bool T);
		Vector(Vector& v);
		Vector();
		void setLenght(float lenght);
		void setA(float a);
		float getA();
		float size();
		float mylScalar(Vector v);
		void mylScalar(int a);
		void add(Vector v);
		void sub(Vector v);
		~Vector();
	};
}
