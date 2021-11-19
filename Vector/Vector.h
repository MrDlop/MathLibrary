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
		float size();
		float mylScalar(Vector v);
		void mylScalar(int a);
		float getA();
		void setLenght(float lenght);
		float heading();
		void setA(float a);
		void add(Vector v);
		float angle(Vector v);
		void sub(Vector v);
		~Vector();
	};
}
