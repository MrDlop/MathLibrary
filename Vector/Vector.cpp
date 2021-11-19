#include "Vector.h"
namespace emsp {
	Vector::Vector(float x, float y)
	{
		this->x = x;
		this->y = y;
	}
	Vector::Vector(float length, float a, bool T)
	{
		this->y = sin(a) * length;
		this->x = cos(a) * length;
	}
	Vector::Vector(Vector& v) {
		this->x = v.x;
		this->y = v.y;
	}
	Vector::Vector() {
		this->x = 0;
		this->y = 0;
	}
	void Vector::setLenght(float lenght)
	{
		double tempL = size() / lenght;
		this->x *= tempL;
		this->y *= tempL;

	}
	float Vector::size()
	{
		return sqrt(pow(x, 2) + pow(y, 2));
	}
	float Vector::mylScalar(Vector v)
	{
		return v.x * v.y + this->x * this->y;
	}

	void Vector::mylScalar(int a)
	{
		this->x *= a;
		this->y *= a;
	}
	float Vector::getA()
	{
		return asin(this->y / size());
	}
	float Vector::heading()
	{
		return this->y / this->x;
	}
	void Vector::setA(float a)
	{
		this->y = sin(a) * size();
		this->x = cos(a) * size();
	}
	void Vector::add(Vector v)
	{
		this->x += v.x;
		this->y += v.y;
	}

	float Vector::angle(Vector v)
	{
		return mylScalar(v) / (size() * v.size());
	}

	void Vector::sub(Vector v)
	{
		this->x -= v.x;
		this->y -= v.y;
	}
	Vector::~Vector()
	{
	}
}
