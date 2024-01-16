using ejercicioletras1.Servicios;

namespace ejercicioletras1.Controladores
{
    class prgram
    {
        public static void Main(string[] args)
        {
            OperativaInterfaz oi = new OperativaImplementacion();

            //Declaracion de variables
            int valor;
            string nombre;
            string primerApellido;
            string segundoApellido;
            double numeroDni;
            string letraDni;
            int codigoPostal;

            //Pedida de nombre y validación
            do
            {
                nombre = oi.pedidaNombre();
                primerApellido = oi.pedidaPrimerApellido();
                segundoApellido = oi.pedidaSegundoApellido();
                valor = oi.validacionNombre(nombre, primerApellido, segundoApellido);
            } while (valor == 1);

            //Pedida de DNI y validación 
            do
            {
                numeroDni = oi.pedidaNumeroDni();
                letraDni = oi.pedidaLetraDni();
                valor = oi.dniCompletoyValidacion(numeroDni, letraDni);
            } while (valor == 1);

            //Pedida de codigo postal y validacion que es de sevilla
            codigoPostal = oi.codigoPostalYValidacion();

            //Concatenacion del nombre completo
            string nombreCompleto = (primerApellido + " " + segundoApellido + ", " + nombre);

            //Separar los apellidos del nombre y guardarlos
            string[] apellidosSolo = nombreCompleto.Split(",");
            string apellidosSoloString = apellidosSolo[0];

            //Calcula el tamaño de la variable con el nombre completo
            nombreCompleto.Count();

            //Recupera y muestra por consola el décimo carácter de la variable con los apellidos
            char caracterDiez = apellidosSoloString[10];
            Console.WriteLine(caracterDiez);

            //Busca la primera vez que aparece la letra a en el nombre completo
            int posicionLetraA = nombreCompleto.IndexOf('a');
            Console.WriteLine(posicionLetraA);

            //Busca la letra r desde la posicion 3 hasta la 10
            int buscarLetraR = nombreCompleto.IndexOf('r', 3, 10);

            if (buscarLetraR != -1)
            {
                Console.WriteLine("La primera r se encuentra en la posicion: " + buscarLetraR);
            }
            else
            {
                Console.WriteLine("No hay ninguna r");
            }
            //Separar letras del nombre
            char[] dividir = new char[nombre.Length];

            for (int i = 0; i < nombre.Length; i++)
            {
                dividir[i] = nombre[i];
            }

            Console.WriteLine("La variable nombre separada por letras es:");
            foreach (char letra in dividir)
            {
                Console.Write(letra + " ");
            }   

            //Buscar las "arc" 
            int posiciondeArc = nombreCompleto.IndexOf("arc");

            if (posiciondeArc != -1)
            {
                Console.WriteLine("arc esta en: " + posiciondeArc);
            }
            else
            {
                Console.WriteLine("No hay arc");
            }
        }
    }
}