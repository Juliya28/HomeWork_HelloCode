// 18.	Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y.

bool x1 = false;
bool y1 = false;

bool x2 = false;
bool y2 = true;

bool x3 = true;
bool y3 = false;

bool x4 = true;
bool y4 = true;

if ((!(x1 || y1) == (!x1 && !y1)) 
&& (!(x2 || y2) == (!x2 && !y2)) 
&& (!(x3 || y3) == (!x3 && !y3)) 
&& (!(x4 || y4) == (!x4 && !y4)))
{
    Console.WriteLine("True");
}
else
{
    Console.WriteLine("False");
}


