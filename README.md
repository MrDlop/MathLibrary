# MathLibrary
## Vector2D 
*Все поля класса публичные*
### Constructors
- Vector(float x, float y); *Задание вектора в Декартовой системе координат*
- Vector(float length, float a, bool T); *Задание вектора в полярной системе координат*
- Vector(Vector& v); *Конструктор копирования*
- Vector() *Конструктор по умолчанию (создает нулевой вектор)*
### Methods
- float size(); *Получение длины вектора*
- float mylScalar(Vector v); *Скалярное умножение векторов*
- void mylScalar(int a); *Умножение вектора на скаляр*
- float getA(); *Получение угла*
- void setLenght(float lenght); *Задание длины*
- void setA(float a); *Задание угла*
- void add(Vector v); *Сложение векторов*
- void sub(Vector v); *Разность векторов*
### Fields
- float x, y; *Декартовы координаты вектора*
## Vector3D
### Constructors
- Vector3D(double x, double y, double z); *Задание вектора в Декартовой системе координат*
- Vector3D(double length, double a, double b, bool T); *Задание вектора в полярной системе координат*
- Vector3D(Vector3D v); *Конструктор копирования*
- Vector3D(); *Конструктор по умолчанию (создает нулевой вектор)*
### Methods
- float size(); *Получение длины вектора*
- float mylScalar(Vector v); *Скалярное умножение векторов*
- void mylScalar(int a); *Умножение вектора на скаляр*
- float getA(); *Получение угла*
- void setLenght(float lenght); *Задание длины*
- void setA(float a); *Задание угла*
- void add(Vector v); *Сложение векторов*
- void sub(Vector v); *Разность векторов*
### Fields
- float x, y; *Декартовы координаты вектора*
