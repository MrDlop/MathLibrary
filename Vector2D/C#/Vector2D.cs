using System;

namespace emsp
{
	public class Vector2D
	{
		public double x, y;
		public Vector2D(double x, double y) {
			this.x = x;
			this.y = y;
		}
		public Vector2D(double length, double a, bool T)
		{
			this.y = System.Math.Sin(a) * length;
			this.x = System.Math.Cos(a) * length;
		}
		public Vector2D(Vector2D v) {
			this.x = v.x;
			this.y = v.y;
		}
		public Vector2D() {
			this.x = 0;
			this.y = 0;
		}
		public void SetLenght(double lenght)
		{
			double tempL = Size() / lenght;
			this.x *= tempL;
			this.y *= tempL;

		}
		public void SetA(double a)
		{
			this.y = System.Math.Sin(a) * Size();
			this.x = System.Math.Cos(a) * Size();
		}
		public double GetA()
		{
			return System.Math.Asin(this.y / Size());
		}
		public double Size()
		{
			return System.Math.Sqrt(System.Math.Pow(x, 2) + System.Math.Pow(y, 2));
		}
		public double MylScalar(Vector2D v)
		{
			return v.x * v.y + this.x * this.y;
		}

		public void MylScalar(int a)
		{
			this.x *= a;
			this.y *= a;
		}
		public void Add(Vector2D v)
		{
			this.x += v.x;
			this.y += v.y;
		}

		public void Sub(Vector2D v)
		{
			this.x -= v.x;
			this.y -= v.y;
		}
		~Vector2D()
		{
		}
	}
}
