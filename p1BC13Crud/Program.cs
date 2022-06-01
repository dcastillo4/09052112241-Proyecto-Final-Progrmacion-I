

using p1BC13Crud.Entidades;
using p1BC13Crud.Servicios;

ServicioAlumno ej = new ServicioAlumno();

////int promA = ej.promedios("A");
////int promB = ej.promedios("B");

////Console.WriteLine($"Seccion A:{promA}");
////Console.WriteLine($"Seccion B:{promB}");

//ej.lee();
//Console.WriteLine("ahora vamos a insertar");
//Console.ReadLine();
//ej.cambia("21-12151",15);

//string nombre = "Jesus Donald Sazo Lima";
//string carnet = "2024-2";
//string correo = "todos@xx.com";
//string clase = "progra 3 la venganza";
//string seccion = "D";



//ej.inserta(nombre, carnet, correo, clase, seccion);



//Console.WriteLine("ahora vamos a leer");
//Console.ReadLine();

//ej.lee();
//program.cs

MdAlumno alu = new MdAlumno();

//alu.nombre = "Andri Navas";
//alu.seccion = "D";
//alu.clase = "Progra 4";
//alu.carnet = "2024-5";

//ej.crearAlumno(alu);
//ej.lee();

//Console.WriteLine(alu.ToString());


alu = ej.ObtenerAlumno("21-11296");

if (alu == null)
{
    Console.WriteLine("Este carnet no existe");
} else
{
    Console.WriteLine(alu.ToString());
    alu.seccion = "Z";
    ej.actualizarAlumno(alu);

}







