double l1, l2, l3, area, semiP;


Console.Write("Insira o valor do primeiro lado do triângulo: ");
l1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Insira o valor do segundo lado do triângulo.: ");
l2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Insira o valor do terceiro lado do triângulo: ");
l3 = Convert.ToDouble(Console.ReadLine());

semiP = (l1 + l2 + l3) / 2;


area = Math.Sqrt(semiP * (semiP - l1) * (semiP - l2) * (semiP - l3)); 

Console.WriteLine($"Semiperimetro.. : {semiP}");
Console.Write($"Area........... : {area}");


