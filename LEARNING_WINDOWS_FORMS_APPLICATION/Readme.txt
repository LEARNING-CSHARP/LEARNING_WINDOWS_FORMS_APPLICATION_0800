Color:

RGB

Red				Green			Blue
0-255			0-255			0-255

اصل ضرب
A	2	B	3	C => 2 * 3 = 6

Red				Green			Blue
0-255			0-255			0-255
256				256				256
 8				 8				 8		24
2				2				2	=> 2	=> Almost => 16,000,000

Decimal:

0
1
2
3
4
5
6
7
8
9
10
11
...
255

Hexa Decimal:

00
01
02
...
09
0A
0B
0C
0D
0E
0F
10
11
...
1F
...
FF

Standard Colors (Web Colors):

00
33
66
99
CC
FF

-----------------------------

6		6		6 = 216

-----------------------------

Custom		Colors
Web			Colors
System		Colors

-----------------------------

Steady State

-----------------------------

Circle myCircle = new Circle();

myCircle.Draw(10, 20, 30, 5);

myCircle.Draw(x: 10, y: 20, radius: 30, width: 5); // OK

myCircle.Draw(radius: 30, x: 10, width: 5, y: 20); // OK

myCircle.Draw(10, 20, radius: 30, width: 5); // OK

myCircle.Draw(10, 20, radius: 30, 5); // Error!

myCircle.Draw(10, 20, width: 5, radius: 30); // OK
