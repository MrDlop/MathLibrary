#include "Vector2D.h"
namespace emsp {
	Vector2D::Vector2D(float x, float y)
	{
		this->x = x;
		this->y = y;
	}
	Vector2D::Vector2D(float length, float a, bool T)
	{
		this->y = sin(a) * length;
		this->x = cos(a) * length;
	}
	Vector2D::Vector2D(Vector2D& v) {
		this->x = v.x;
		this->y = v.y;
	}
	Vector2D::Vector2D() {
		this->x = 0;
		this->y = 0;
	}
	void Vector2D::setLenght(float lenght)
	{
		double tempL = size() / lenght;
		this->x *= tempL;
		this->y *= tempL;

	}
	void Vector2D::setA(float a)
	{
		this->y = sin(a) * size();
		this->x = cos(a) * size();
	}
	float Vector2D::getA()
	{
		return asin(this->y / size());
	}
	float Vector2D::size()
	{
		return sqrt(pow(x, 2) + pow(y, 2));
	}
	float Vector2D::mylScalar(Vector2D v)
	{
		return v.x * v.y + this->x * this->y;
	}

	void Vector2D::mylScalar(int a)
	{
		this->x *= a;
		this->y *= a;
		}
	void Vector2D::add(Vector2D v)
	{
		this->x += v.x;
		this->y += v.y;
	}

	void Vector2D::sub(Vector2D v)
	{
		this->x -= v.x;
		this->y -= v.y;
	}
	Vector2D::~Vector2D()
	{
	}
}
