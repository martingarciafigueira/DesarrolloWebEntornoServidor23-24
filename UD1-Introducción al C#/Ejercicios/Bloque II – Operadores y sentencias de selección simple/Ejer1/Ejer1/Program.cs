//a
int x = 5;
x += 10;
bool b = x < 15; //false

//b
short y = 100;
short z = 50;
int resto = y % z;
b = resto == 1; //false

//c
z = 9;
bool b2 = z > 5;
bool bb = !b2; //false

//d
b = true;
b2 = false;
bool b3 = b && b2;
bool b4 = b || b2;
bool b5 = !b3;
bool b6 = !b4;

Console.ReadLine();