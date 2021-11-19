using System;

namespace emsp
{
	public class Vector2D
	{
		double x, y;
		Vector2D(double x, double y) {
			this.x = x;
			this.y = y;
		}
		Vector2D(double length, double a, bool T)
		{
			this.y = System.Math.Sin(a) * length;
			this.x = System.Math.Cos(a) * length;
		}
		Vector2D(Vector2D v) {
			this.x = v.x;
			this.y = v.y;
		}
		Vector2D() {
			this.x = 0;
			this.y = 0;
		}
		void SetLenght(double lenght)
		{
			double tempL = Size() / lenght;
			this.x *= tempL;
			this.y *= tempL;

		}
		void SetA(double a)
		{
			this.y = System.Math.Sin(a) * Size();
			this.x = System.Math.Cos(a) * Size();
		}
		double GetA()
		{
			return System.Math.Asin(this.y / Size());
		}
		double Size()
		{
			return System.Math.Sqrt(System.Math.Pow(x, 2) + System.Math.Pow(y, 2));
		}
		double MylScalar(Vector2D v)
		{
			return v.x * v.y + this.x * this.y;
		}

		void MylScalar(int a)
		{
			this.x *= a;
			this.y *= a;
		}
		void Add(Vector2D v)
		{
			this.x += v.x;
			this.y += v.y;
		}

		void Sub(Vector2D v)
		{
			this.x -= v.x;
			this.y -= v.y;
		}
		~Vector2D()
		{
		}
	}
}
