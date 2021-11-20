using System;

namespace emsp
{
	public class Vector3D
	{
		public double x, y, z;
		public Vector3D(double x, double y, double z) {
			this.x = x;
			this.y = y;
			this.z = z;
		}
		public Vector3D(double length, double a, double b, bool T)
		{
			this.z = System.Math.Cos(b) * length;
			this.y = System.Math.Sin(a) * System.Math.Sin(a) * length;
			this.x = System.Math.Cos(a) * System.Math.Sin(b) * length;
		}
		public Vector3D(Vector3D v) {
			this.x = v.x;
			this.y = v.y;
			this.z = v.z;
		}
		public Vector3D() {
			this.x = 0;
			this.y = 0;
			this.z = 0;
		}
		public void SetLenght(double lenght)
		{
			double tempL = Size() / lenght;
			this.x *= tempL;
			this.y *= tempL;
			this.z *= tempL;
		}
		public void SetA(double a)
		{
			this.y /= System.Math.Sin(GetA()) / System.Math.Sin(a);
			this.x /= System.Math.Cos(GetA()) / System.Math.Sin(a);
		}
		public void SetB(double b)
		{
			this.z /= System.Math.Cos(GetB()) / System.Math.Cos(b);
			this.y /= System.Math.Sin(GetB()) / System.Math.Sin(b);
			this.x /= System.Math.Sin(GetB()) / System.Math.Sin(b);
		}
		public double GetA()
        {
			return System.Math.Asin(this.x / (Size() * System.Math.Sin(GetB())));
		}
		public double GetB()
		{
			return System.Math.Acos(this.z / Size());
		}
		public double Size()
		{
			return System.Math.Sqrt(this.x * this.x + this.y * this.y + this.z * this.z);
		}
		public double MylScalar(Vector3D v)
		{
			return this.x * v.x + this.y * v.y + this.z * v.z;
		}

		public void MylScalar(int a)
		{
			this.x *= a;
			this.y *= a;
			this.y *= a;
		}
		public void Add(Vector3D v)
		{
			this.x += v.x;
			this.y += v.y;
			this.y += v.y;
		}

		public void Sub(Vector3D v)
		{
			this.x -= v.x;
			this.y -= v.y;
			this.y -= v.y;
		}
		~Vector3D()
		{
		}
	}
}
