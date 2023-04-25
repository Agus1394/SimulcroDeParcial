int correcta, enBlanco, incorrecta;
double nota;

Console.WriteLine("Ingresar respuestas correctas:");
correcta= Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingresar respuestas en blanco:");
enBlanco= Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingresar respuestas incorrectas:");
precio= Convert.ToInt32(Console.ReadLine());

nota= correcta - (incorrecta * 0.5);

if (enBlanco > (0.25 * (correcta + enBlanco + incorrecta))){
    nota= nota - 2;
}

Console.WriteLine("La nota final es: "+nota);