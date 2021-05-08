using System;
using System.Collections;

namespace examen_2
{
    class Program
    {
     
        static void Main(string[] args)
        {

            int op=0;
            string value="";
            int c=0;
            Console.WriteLine("necflis");

            do{
            Console.WriteLine(
            "\n1. clientes "+
            "\n2. peliculas"+
            "\n3. salir"+
            "\n seleccione la opcion deseada");
            op=Convert.ToInt32(Console.ReadLine());

             
            
            switch(op){

                case 1:
                Stack sumarcliente= new Stack();
                do{
            Console.WriteLine(
            "\n1. ver listado de clientes "+
            "\n2. crear nuevo cliente "+
            "\n3 seleccionar cliente"+
            "\n4. salir"+
            "\n seleccione la opcion deseada");
            op=Convert.ToInt32(Console.ReadLine());


            switch(op){
                case 1:
                if(sumarcliente.Count==0){
                  Console.WriteLine("no hay clientes ");

                }else{
                  Console.WriteLine($"{sumarcliente}");
                }
                Console.ReadKey();
                

               

                break;
                  
                  case 2:
                Console.WriteLine("nombre a apilar ");
                value=Console.ReadLine();
                sumarcliente.Push(value);

                Console.WriteLine("direccion ");
                value=Console.ReadLine();
                sumarcliente.Push(value);

                Console.WriteLine("edad ");
                value=Console.ReadLine();
                sumarcliente.Push(value);

                Console.WriteLine("dato ingresado con exito");
                Console.ReadKey();
                break;

                 
                
                case 3:
                Stack sumarpelicula= new Stack();
                c=sumarcliente.Count;
                for(int x=1; x<=c; x++){
                Console.WriteLine($" {sumarcliente}");
                }
                Console.WriteLine(
                  
            "\n1. playlist "+
            "\n2. agregar pelicula "+
            "\n3. salir");
            Console.ReadKey();
            switch (op)
            {
                
                case 1:
                if(sumarcliente.Count==0){
                  Console.WriteLine("no hay pelicula ");

                }else{
                  Console.WriteLine($"{sumarpelicula}");
                }
                Console.ReadKey();

                break;
                case 2:
                Console.WriteLine("edad ");
                value=Console.ReadLine();
                sumarpelicula.Push(value);

                Console.WriteLine("dato ingresado con exito");
                Console.ReadKey();
                break;
                case 3:
                 Console.WriteLine("regresar al menu anterior");
                break;
            }
                
                break;

                  case 4:
                Console.WriteLine("regresar al menu anterior");
                break; 
                default: 
                Console.WriteLine("elija una de las opciones que se le presentan");
                break;
            }

             } while(op!=3);
             break;



                

               
            }
            }
            
}}
}
      