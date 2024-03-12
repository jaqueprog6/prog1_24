//OPERADORES
int a = 3;
int b = a++; // ++ e um acumulador
//neste ++ vai somar a + 1
//entretanto o acúmulo vai ocorrer depois da atribuiçao pois o ++ esta do lado direito de a
WriteLine($"a é{a}, b é {b}");
//-------------
int c = 3;
int d = ++c;
WriteLine($"c é {c}, d é {d}");
//neste caso o ++ esta do lado esquerdo de c,
// portado o acúmulo ocorre antes da atribuicao
//------------
//combinando operadoesres de atribuicao
int p = 6;
p += 3; // equivalente p = p + 3;
p -= 3; //equivalente a p = p -3;
p *= 3; //equivalente a p = p *3;
p /= 3; // equivalente a p = p / 3;


//OPERADORES LOGICOS
bool b_A =  true;
bool b_B = false;
WriteLine($"AND  | b_A  | b_B  ");
WriteLine($"b_A  | {b_A &b_A, -5}| {b_A & b_B, -5}");
WriteLine($"b_B  | {b_B &b_A, -5}| {b_B & b_B, -5}");
WriteLine();
WriteLine($"OR   | b_A  | b_B  ");
WriteLine($"b_A  | {b_A |b_A, -5}| {b_A | b_B, -5}");
WriteLine($"b_B  | {b_B |b_A, -5}| {b_B | b_B, -5}");
WriteLine();
WriteLine($"XOR  | b_A  | b_B  ");
WriteLine($"b_A  | {b_A ^b_A, -5}| {b_A ^ b_B, -5}");
WriteLine($"b_B  | {b_B ^b_A, -5}| {b_B ^ b_B, -5}");

