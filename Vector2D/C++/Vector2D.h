#pragma once
#include <cmath>

namespace emsp {
	class Vector2D
	{
	public:
		float x = 0, y = 0;
		Vector2D(float x, float y);
		Vector2D(float length, float a, bool T);
		Vector2D(Vector2D& v);
		Vector2D();
		void setLenght(float lenght);
		void setA(float a);
		float getA();
		float size();
		float mylScalar(Vector2D v);
		void mylScalar(int a);
		void add(Vector2D v);
		void sub(Vector2D v);
		~Vector2D();
	};
}
