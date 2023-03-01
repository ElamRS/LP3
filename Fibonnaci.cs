// See https://aka.ms/new-console-template for more information

int a = 0, b = 1, temp;
int n = 40;
int flag = 0;

while (flag<n) {
    temp = a;
    a = a + b;
    b = temp;
    Console.Write(a + " ");
    flag++;
}


