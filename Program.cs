// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

DateTime deyt = DateTime.Now;
Console.WriteLine(deyt);

string str1 = string.Empty;
str1 = "hazar";
string ad = "hazar";
string soyad = "akgül";
string tamIsım = ad + " " + soyad;

/// int

int intgo = 3;
int intgo2 = 5;
int intgo3 = intgo * intgo2;

// bool

bool b1 = 10>3;

// değişken dönüşümleri

string str10 = "10";
int int10 = 10;

string yeniDeger = str10 + " " + int10.ToString();

Console.WriteLine(yeniDeger);

int int11 = int10 + Convert.ToInt32(str10);

Console.WriteLine(int11);

int int12 = int10 + int.Parse(str10);


// datetime

string zaman = DateTime.Now.ToString("dd.mm.yyyy"); 
Console.Write(zaman);
Console.Write(" " + "zaman akıp gidiyor");