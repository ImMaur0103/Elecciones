using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace Proyecto_final_nath
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Elecciones Generales 2019";
            Console.WriteLine("Ingrese el maximo de votos para las elecciones");
            int MaximoVotos = Convert.ToInt32(Console.ReadLine());
            int ContadorVotos = 0;
            int[] VotosAmarilloP = new int[5];
            int[] VotosVerdeP = new int[5];
            int[] VotosRojoP = new int[5];
            int[] VotosNuloP = new int[5];

            int[] VotosAmarilloS = new int[6];
            int[] VotosVerdeS = new int[6];
            int[] VotosRojoS = new int[6];
            int[] VotosNuloS = new int[6];
            string R1 = "";
            string contrasena = "ADMIN";
            string R2 = "";
            bool primarias = true;
            while (true)
            {
                Console.Beep();//  funcion para realizar un sonido tipo beep
                Console.Clear();// Limpiar la pantalla
                Console.WriteLine("\tBiemvenidos\nIngrese la opcion desea");
                Console.WriteLine("1) Votante\n2) Administrador\n3) Salir");
                R1 = Console.ReadLine();
                if ((R1 == "1" || R1 == "Votante") && ContadorVotos < MaximoVotos && primarias)
                {
                    ContadorVotos++;
                    Console.Clear();
                    //Presidente, Alcalde, DiputadoNacional, DiputadoDistrital, DiputadoParlacen
                    string Opcion = "";
                    string R3 = "";
                    for(int i = 0; i < 5; i++)
                    {
                        Console.Clear();
                        switch (i + 1)
                        {
                            case 1:
                                Opcion = "Presidente";
                                break;
                            case 2:
                                Opcion = "Alcalde";
                                break;
                            case 3:
                                Opcion = "Diputado Nacional";
                                break;
                            case 4:
                                Opcion = "Diputado Distrital";
                                break;
                            case 5:
                                Opcion = "Diputado Parlacen";
                                break;
                        }
                        Console.WriteLine("Ingrese su voto por el " + Opcion);
                        Console.WriteLine("1) Partido Amarillo\n2) Partido Verde\n3) Partido Rojo\n4) Nulo");
                        R3 = Console.ReadLine();
                        switch (R3)
                        {
                            case "1":
                                VotosAmarilloP[i]++;
                                break;

                            case "2":
                                VotosVerdeP[i]++;
                                break;

                            case "3":
                                VotosRojoP[i]++;
                                break;

                            case "4":
                                VotosNuloP[i]++;
                                break;

                            default:
                                i--;
                                break;
                        }
                    }
                }
                else if ((R1 == "1" || R1 == "Votante") && ContadorVotos == MaximoVotos && primarias)
                {
                    Console.Clear();
                    Console.WriteLine("No Se Puede votar, maximo de votos alcanzado\nPara visualizar los resultados presionar cualquier tecla");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Los Resultados de la Votacion son");
                    Console.Clear();
                    Console.WriteLine("Presidente\tAlcalde\t\tDiputado Nacional\tDiputado Distrital\tDiputado Parlacen");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("     " + VotosAmarilloP[0] + "\t\t   " + VotosAmarilloP[1] + "\t\t\t" + VotosAmarilloP[2] + "\t\t\t" + VotosAmarilloP[3] + "\t\t\t" + VotosAmarilloP[4]);
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("     " + VotosVerdeP[0] + "\t\t   " + VotosVerdeP[1] + "\t\t\t" + VotosVerdeP[2] + "\t\t\t" + VotosVerdeP[3] + "\t\t\t" + VotosVerdeP[4]);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("     " + VotosRojoP[0] + "\t\t   " + VotosRojoP[1] + "\t\t\t" + VotosRojoP[2] + "\t\t\t" + VotosRojoP[3] + "\t\t\t" + VotosRojoP[4]);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("     " + VotosNuloP[0] + "\t\t   " + VotosNuloP[1] + "\t\t\t" + VotosNuloP[2] + "\t\t\t" + VotosNuloP[3] + "\t\t\t" + VotosNuloP[4]);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadKey();

                }
                else if ((R1 == "1" || R1 == "Votante") && ContadorVotos < MaximoVotos && !primarias)
                {
                    ContadorVotos++;
                    Console.Clear();
                    //Presidente,Viseprecidente , Alcalde, DiputadoNacional, DiputadoDistrital, DiputadoParlacen
                    string Opcion = "";
                    string R3 = "";
                    for (int i = 0; i < 6; i++)
                    {
                        Console.Clear();
                        switch (i + 1)
                        {
                            case 1:
                                Opcion = "Presidente";
                                break;
                            case 2:
                                Opcion = "Vicepresidente";
                                break;
                            case 3:
                                Opcion = "Alcalde Municial";
                                break;
                            case 4:
                                Opcion = "Diputados en lista nacional";
                                break;
                            case 5:
                                Opcion = "Diputado en lista distrital";
                                break;
                            case 6:
                                Opcion = "Diputados al parlacen Parlacen";
                                break;
                        }
                        Console.WriteLine("Ingrese su voto por el " + Opcion);
                        Console.WriteLine("1) Partido Amarillo\n2) Partido Verde\n3) Partido Rojo\n4) Nulo");
                        R3 = Console.ReadLine();
                        switch (R3)
                        {
                            case "1":
                                VotosAmarilloS[i]++;
                                break;

                            case "2":
                                VotosVerdeS[i]++;
                                break;

                            case "3":
                                VotosRojoS[i]++;
                                break;

                            case "4":
                                VotosNuloS[i]++;
                                break;

                            default:
                                i--;
                                break;
                        }
                    }
                }
                else if ((R1 == "1" || R1 == "Votante") && ContadorVotos == MaximoVotos && !primarias)
                {
                    Console.Clear();
                    Console.WriteLine("No Se Puede votar, maximo de votos alcanzado\nPara visualizar los resultados presionar cualquier tecla");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Los Resultados de la Votacion son");
                    Console.Clear();
                    Console.WriteLine("Presidente\tVicepresidente\tAlcalde\t\tDiputado Nacional\tDiputado Distrital\tDiputado Parlacen");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("     " + VotosAmarilloS[0] + "\t\t\t" + VotosAmarilloS[1] + "\t   " + VotosAmarilloS[2] + "\t\t\t" + VotosAmarilloS[3] + "\t\t\t" + VotosAmarilloS[4] + "\t\t\t" + VotosAmarilloS[5]);
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("     " + VotosVerdeS[0] + "\t\t\t" + VotosVerdeS[1] + "\t   " + VotosVerdeS[2] + "\t\t\t" + VotosVerdeS[3] + "\t\t\t" + VotosVerdeS[4] + "\t\t\t" + VotosVerdeS[5]);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("     " + VotosRojoS[0] + "\t\t\t" + VotosRojoS[1] + "\t   " + VotosRojoS[2] + "\t\t\t" + VotosRojoS[3] + "\t\t\t" + VotosRojoS[4] + "\t\t\t" + VotosRojoS[5]);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("     " + VotosNuloS[0] + "\t\t\t" + VotosNuloS[1] + "\t   " + VotosNuloS[2] + "\t\t\t" + VotosNuloS[3] + "\t\t\t" + VotosNuloS[4] + "\t\t\t" + VotosNuloS[5]);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadKey();
                }
                else if (R1 == "2" || R1 == "Administrador" || R1 == "administrador" || R1 == "admin" || R1 == "Admin")
                {
                    string R3 = "";
                    Console.Clear();
                    Console.WriteLine("Bienvenido Administrador\nIngrese la cantroseña:");
                    R2 = Console.ReadLine();
                    if (R2 != contrasena)
                    {
                        R2 = "";
                        R1 = "";
                        Console.WriteLine("Ingreso la contraseña Equivocada");
                        Console.ReadKey();
                    }
                    while (R2 == contrasena)
                    {
                        Console.Clear();
                        Console.Beep();
                        Console.WriteLine("Bienvenido Administrador");
                        Console.WriteLine("1) Modificar Maximo de votos\n2) Iniciar Nuevas Elecciones\n3) Ingresar votaciones");
                        Console.WriteLine("4) Ganador Parcial\n5) Distribucion Grafica\n6) Anular eleccion\n7) Reportes con graficos");
                        Console.WriteLine("8) Auditar\n9) Log-out");
                        R3 = Console.ReadLine();
                        if (R3 == "1")
                        {
                            Console.Clear();
                            Console.WriteLine("Ingrese el maximo de votos");
                            MaximoVotos = Convert.ToInt32(Console.ReadLine());
                            R3 = "";
                        }
                        else if (R3 == "2")
                        {
                            primarias = false;
                            ContadorVotos = 0;
                            R3 = "";
                        }
                        else if (R3 == "3")
                        {
                            Console.Clear();
                            Console.WriteLine("Ingrese la direccion donde se encuentra el archivo de texto");
                            int[] VotosTxtAmarillos = new int[5];//Se crean variables auxiliares las cuales puedan usarse para almacenar los votos
                            int[] VotosTxtVerdes = new int[5];
                            int[] VotosTxtRojos = new int[5];
                            int[] VotosTxtNulos = new int[5];
                            int Contador = 0;
                            string Votacion = Console.ReadLine();
                            string Auxiliar = "";
                            StreamReader Importar = new StreamReader(Votacion);
                            while (Importar.EndOfStream == false)//Un ciclo que no termina hasta leer todas las lineas del bloc de notas
                            {
                                Contador++;
                                Auxiliar = Importar.ReadLine();
                                string[] split = Auxiliar.Split(',');
                                for (int b = 0; b < 5; b++)
                                {
                                    if (split[b] == "A")
                                    {
                                        VotosTxtAmarillos[b]++;
                                    }
                                    else if (split[b] == "V")
                                    {
                                        VotosTxtVerdes[b]++;
                                    }
                                    else if (split[b] == "R")
                                    {
                                        VotosTxtRojos[b]++;
                                    }
                                    else if (split[b] == "")
                                    {
                                        VotosTxtNulos[b]++;
                                    }
                                }
                            }
                            Importar.Close();// siempre despues de abrir un archivo hay que cerrarlo
                            if (Contador <= MaximoVotos)
                            {
                                Console.Clear();
                                Console.WriteLine("Los Resultados de la Votacion son");
                                Console.Clear();
                                Console.WriteLine("Presidente\tAlcalde\t\tDiputado Nacional\tDiputado Distrital\tDiputado Parlacen");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("     " + VotosTxtAmarillos[0] + "\t\t   " + VotosTxtAmarillos[1] + "\t\t\t" + VotosTxtAmarillos[2] + "\t\t\t" + VotosTxtAmarillos[3] + "\t\t\t" + VotosTxtAmarillos[4]);
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.WriteLine("     " + VotosTxtVerdes[0] + "\t\t   " + VotosTxtVerdes[1] + "\t\t\t" + VotosTxtVerdes[2] + "\t\t\t" + VotosTxtVerdes[3] + "\t\t\t" + VotosTxtVerdes[4]);
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("     " + VotosTxtRojos[0] + "\t\t   " + VotosTxtRojos[1] + "\t\t\t" + VotosTxtRojos[2] + "\t\t\t" + VotosTxtRojos[3] + "\t\t\t" + VotosTxtRojos[4]);
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.WriteLine("     " + VotosTxtNulos[0] + "\t\t   " + VotosTxtNulos[1] + "\t\t\t" + VotosTxtNulos[2] + "\t\t\t" + VotosTxtNulos[3] + "\t\t\t" + VotosTxtNulos[4]);
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("Error\n\ringreso unas votaciones con exeso de votos");
                            }
                        }
                        else if (R3 == "4" && primarias)
                        {
                            Console.Clear();
                            Console.WriteLine("Los Resultados de la Votacion son");
                            Console.WriteLine("Presidente\tAlcalde\t\tDiputado Nacional\tDiputado Distrital\tDiputado Parlacen");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("     " + VotosAmarilloP[0] + "\t\t   " + VotosAmarilloP[1] + "\t\t\t" + VotosAmarilloP[2] + "\t\t\t" + VotosAmarilloP[3] + "\t\t\t" + VotosAmarilloP[4]);
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("     " + VotosVerdeP[0] + "\t\t   " + VotosVerdeP[1] + "\t\t\t" + VotosVerdeP[2] + "\t\t\t" + VotosVerdeP[3] + "\t\t\t" + VotosVerdeP[4]);
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("     " + VotosRojoP[0] + "\t\t   " + VotosRojoP[1] + "\t\t\t" + VotosRojoP[2] + "\t\t\t" + VotosRojoP[3] + "\t\t\t" + VotosRojoP[4]);
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine("     " + VotosNuloP[0] + "\t\t   " + VotosNuloP[1] + "\t\t\t" + VotosNuloP[2] + "\t\t\t" + VotosNuloP[3] + "\t\t\t" + VotosNuloP[4]);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.ReadKey();
                            R3 = "";

                        }
                        else if (R3 == "4" && !primarias)
                        {
                            Console.Clear();
                            Console.WriteLine("Los Resultados de la Votacion son");
                            Console.WriteLine("Presidente\tVicepresidente\tAlcalde\t\tDiputado Nacional\tDiputado Distrital\tDiputado Parlacen");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("     " + VotosAmarilloS[0] + "\t\t\t" + VotosAmarilloS[1] + "\t   " + VotosAmarilloS[2] + "\t\t\t" + VotosAmarilloS[3] + "\t\t\t" + VotosAmarilloS[4] + "\t\t\t" + VotosAmarilloS[5]);
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("     " + VotosVerdeS[0] + "\t\t\t" + VotosVerdeS[1] + "\t   " + VotosVerdeS[2] + "\t\t\t" + VotosVerdeS[3] + "\t\t\t" + VotosVerdeS[4] + "\t\t\t" + VotosVerdeS[5]);
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("     " + VotosRojoS[0] + "\t\t\t" + VotosRojoS[1] + "\t   " + VotosRojoS[2] + "\t\t\t" + VotosRojoS[3] + "\t\t\t" + VotosRojoS[4] + "\t\t\t" + VotosRojoS[5]);
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine("     " + VotosNuloS[0] + "\t\t\t" + VotosNuloS[1] + "\t   " + VotosNuloS[2] + "\t\t\t" + VotosNuloS[3] + "\t\t\t" + VotosNuloS[4] + "\t\t\t" + VotosNuloS[5]);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.ReadKey();
                            R3 = "";
                        }
                        else if (R3 == "5")
                        {


                        }
                        else if (R3 == "6")
                        {
                            Console.Clear();
                            Console.WriteLine("Ingrese motivo de anulaion");
                            string Motivo = "";
                            Motivo = Console.ReadLine();
                            if (primarias)
                            {
                                Console.Clear();
                                Console.WriteLine("No Se Puede votar, maximo de votos alcanzado\nPara visualizar los resultados presionar cualquier tecla");
                                Console.ReadKey();
                                Console.Clear();
                                Console.WriteLine("Los Resultados de la Votacion son");
                                Console.Clear();
                                Console.WriteLine("Presidente\tAlcalde\t\tDiputado Nacional\tDiputado Distrital\tDiputado Parlacen");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("     " + VotosAmarilloP[0] + "\t\t   " + VotosAmarilloP[1] + "\t\t\t" + VotosAmarilloP[2] + "\t\t\t" + VotosAmarilloP[3] + "\t\t\t" + VotosAmarilloP[4]);
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.WriteLine("     " + VotosVerdeP[0] + "\t\t   " + VotosVerdeP[1] + "\t\t\t" + VotosVerdeP[2] + "\t\t\t" + VotosVerdeP[3] + "\t\t\t" + VotosVerdeP[4]);
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("     " + VotosRojoP[0] + "\t\t   " + VotosRojoP[1] + "\t\t\t" + VotosRojoP[2] + "\t\t\t" + VotosRojoP[3] + "\t\t\t" + VotosRojoP[4]);
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.WriteLine("     " + VotosNuloP[0] + "\t\t   " + VotosNuloP[1] + "\t\t\t" + VotosNuloP[2] + "\t\t\t" + VotosNuloP[3] + "\t\t\t" + VotosNuloP[4]);
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.ReadKey();
                            }
                            else if (!primarias)
                            {
                                Console.Clear();
                                Console.WriteLine("No Se Puede votar, maximo de votos alcanzado\nPara visualizar los resultados presionar cualquier tecla");
                                Console.ReadKey();
                                Console.Clear();
                                Console.WriteLine("Los Resultados de la Votacion son");
                                Console.Clear();
                                Console.WriteLine("Presidente\tVicepresidente\tAlcalde\t\tDiputado Nacional\tDiputado Distrital\tDiputado Parlacen");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("     " + VotosAmarilloS[0] + "\t\t\t" + VotosAmarilloS[1] + "\t   " + VotosAmarilloS[2] + "\t\t\t" + VotosAmarilloS[3] + "\t\t\t" + VotosAmarilloS[4] + "\t\t\t" + VotosAmarilloS[5]);
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.WriteLine("     " + VotosVerdeS[0] + "\t\t\t" + VotosVerdeS[1] + "\t   " + VotosVerdeS[2] + "\t\t\t" + VotosVerdeS[3] + "\t\t\t" + VotosVerdeS[4] + "\t\t\t" + VotosVerdeS[5]);
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("     " + VotosRojoS[0] + "\t\t\t" + VotosRojoS[1] + "\t   " + VotosRojoS[2] + "\t\t\t" + VotosRojoS[3] + "\t\t\t" + VotosRojoS[4] + "\t\t\t" + VotosRojoS[5]);
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.WriteLine("     " + VotosNuloS[0] + "\t\t\t" + VotosNuloS[1] + "\t   " + VotosNuloS[2] + "\t\t\t" + VotosNuloS[3] + "\t\t\t" + VotosNuloS[4] + "\t\t\t" + VotosNuloS[5]);
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.ReadKey();
                            }

                            Console.ReadKey();

                            if (primarias)
                            {
                                VotosAmarilloP[0] = 0;
                                VotosAmarilloP[1] = 0;
                                VotosAmarilloP[2] = 0;
                                VotosAmarilloP[3] = 0;
                                VotosAmarilloP[4] = 0;

                                VotosVerdeP[0] = 0;
                                VotosVerdeP[1] = 0;
                                VotosVerdeP[2] = 0;
                                VotosVerdeP[3] = 0;
                                VotosVerdeP[4] = 0;

                                VotosRojoP[0] = 0;
                                VotosRojoP[1] = 0;
                                VotosRojoP[2] = 0;
                                VotosRojoP[3] = 0;
                                VotosRojoP[4] = 0;

                                VotosNuloP[0] = 0;
                                VotosNuloP[1] = 0;
                                VotosNuloP[2] = 0;
                                VotosNuloP[3] = 0;
                                VotosNuloP[4] = 0;
                            }
                            else if (!primarias)
                            {
                                VotosAmarilloS[0] = 0;
                                VotosAmarilloS[1] = 0;
                                VotosAmarilloS[2] = 0;
                                VotosAmarilloS[3] = 0;
                                VotosAmarilloS[4] = 0;

                                VotosVerdeS[0] = 0;
                                VotosVerdeS[1] = 0;
                                VotosVerdeS[2] = 0;
                                VotosVerdeS[3] = 0;
                                VotosVerdeS[4] = 0;

                                VotosRojoS[0] = 0;
                                VotosRojoS[1] = 0;
                                VotosRojoS[2] = 0;
                                VotosRojoS[3] = 0;
                                VotosRojoS[4] = 0;

                                VotosNuloS[0] = 0;
                                VotosNuloS[1] = 0;
                                VotosNuloS[2] = 0;
                                VotosNuloS[3] = 0;
                                VotosNuloS[4] = 0;
                            }
                            R3 = "";
                        }
                        else if (R3 == "7")
                        {
                            Console.Clear();
                            int[] porsentajeAmarilloP = new int[5];
                            int[] porsentajeVerdeP = new int[5];
                            int[] porsentajeRojoP = new int[5];

                            int[] porsentajeAmarilloS = new int[6];
                            int[] porsentajeVerdeS = new int[6];
                            int[] porsentajeRojoS = new int[6];

                            for (int i = 0; i < 5; i++)
                            {
                                porsentajeAmarilloP[i] = VotosAmarilloP[i] * 100 / MaximoVotos / 10;
                                porsentajeVerdeP[i] = VotosVerdeP[i] * 100 / MaximoVotos / 10;
                                porsentajeRojoP[i] = VotosRojoP[i] * 100 / MaximoVotos / 10;
                            }
                            for (int i = 0; i < 6; i++)
                            {
                                porsentajeAmarilloS[i] = VotosAmarilloS[i] * 100 / MaximoVotos / 10;
                                porsentajeVerdeS[i] = VotosVerdeS[i] * 100 / MaximoVotos / 10;
                                porsentajeRojoS[i] = VotosRojoS[i] * 100 / MaximoVotos / 10;
                            }

                            if (primarias)
                            {
                                string Opcion = "";
                                Console.WriteLine("\tPorcentaje Partido Amarillo");
                                for (int j = 0; j < 5; j++)
                                {
                                    switch (j + 1)
                                    {
                                        case 1:
                                            Opcion = "Presidente";
                                            break;
                                        case 2:
                                            Opcion = "Alcalde";
                                            break;
                                        case 3:
                                            Opcion = "Diputado Nacional";
                                            break;
                                        case 4:
                                            Opcion = "Diputado Distrital";
                                            break;
                                        case 5:
                                            Opcion = "Diputado Parlacen";
                                            break;
                                    }
                                    Console.WriteLine(Opcion);
                                    for (int i = 10; i >= 0; i--)
                                    {
                                        if (i > 0)
                                        {
                                            if (porsentajeAmarilloP[j] > i)
                                            {
                                                Console.WriteLine(" ");
                                            }
                                            else if (porsentajeAmarilloP[j] <= i)
                                            {
                                                Console.WriteLine("█");
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("El porcentaje equivale al " + porsentajeAmarilloP[j] * 10 + "%");
                                        }
                                    }
                                }

                                Console.WriteLine("\n\tPorcentaje Partido Rojo");
                                for (int j = 0; j < 5; j++)
                                {
                                    switch (j + 1)
                                    {
                                        case 1:
                                            Opcion = "Presidente";
                                            break;
                                        case 2:
                                            Opcion = "Alcalde";
                                            break;
                                        case 3:
                                            Opcion = "Diputado Nacional";
                                            break;
                                        case 4:
                                            Opcion = "Diputado Distrital";
                                            break;
                                        case 5:
                                            Opcion = "Diputado Parlacen";
                                            break;
                                    }
                                    Console.WriteLine(Opcion);
                                    for (int i = 10; i >= 0; i--)
                                    {
                                        if (i > 0)
                                        {
                                            if (porsentajeRojoP[j] > i)
                                            {
                                                Console.WriteLine(" ");
                                            }
                                            if (porsentajeRojoP[j] <= i)
                                            {
                                                Console.WriteLine("█");
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("El porcentaje equivale al " + porsentajeRojoP[j] * 10 + "%");
                                        }
                                    }
                                }

                                Console.WriteLine("\n\tPorcentaje Partido Verde");
                                for (int j = 0; j < 5; j++)
                                {
                                    switch (j + 1)
                                    {
                                        case 1:
                                            Opcion = "Presidente";
                                            break;
                                        case 2:
                                            Opcion = "Alcalde";
                                            break;
                                        case 3:
                                            Opcion = "Diputado Nacional";
                                            break;
                                        case 4:
                                            Opcion = "Diputado Distrital";
                                            break;
                                        case 5:
                                            Opcion = "Diputado Parlacen";
                                            break;
                                    }
                                    Console.WriteLine(Opcion);
                                    for (int i = 10; i >= 0; i--)
                                    {
                                        if (i < 10)
                                        {
                                            if (porsentajeVerdeP[j] > i)
                                            {
                                                Console.WriteLine(" ");
                                            }
                                            if (porsentajeVerdeP[j] <= i)
                                            {
                                                Console.WriteLine("█");
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("El porcentaje equivale al " + porsentajeVerdeP[j] * 10 + "%");
                                        }
                                    }
                                }
                            }
                            if (!primarias)
                            {
                                string Opcion = "";
                                Console.WriteLine("\tPorcentaje Partido Amarillo");
                                for (int j = 0; j < 6; j++)
                                {
                                    switch (j + 1)
                                    {
                                        case 1:
                                            Opcion = "Presidente";
                                            break;
                                        case 2:
                                            Opcion = "Vicepresidente";
                                            break;
                                        case 3:
                                            Opcion = "Alcalde Municial";
                                            break;
                                        case 4:
                                            Opcion = "Diputados en lista nacional";
                                            break;
                                        case 5:
                                            Opcion = "Diputado en lista distrital";
                                            break;
                                        case 6:
                                            Opcion = "Diputados al parlacen Parlacen";
                                            break;
                                    }
                                    Console.WriteLine(Opcion);
                                    for (int i = 10; i >= 0; i--)
                                    {
                                        if (i > 0)
                                        {
                                            if (porsentajeAmarilloP[i] > j)
                                            {
                                                Console.WriteLine(" ");
                                            }
                                            if (porsentajeAmarilloP[j] <= i)
                                            {
                                                Console.WriteLine("█");
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("El porcentaje equivale al " + porsentajeAmarilloP[j] * 10 + "%");
                                        }
                                    }
                                }

                                Console.WriteLine("\n\tPorcentaje Partido Rojo");
                                for (int j = 0; j < 6; j++)
                                {
                                    switch (j + 1)
                                    {
                                        case 1:
                                            Opcion = "Presidente";
                                            break;
                                        case 2:
                                            Opcion = "Vicepresidente";
                                            break;
                                        case 3:
                                            Opcion = "Alcalde Municial";
                                            break;
                                        case 4:
                                            Opcion = "Diputados en lista nacional";
                                            break;
                                        case 5:
                                            Opcion = "Diputado en lista distrital";
                                            break;
                                        case 6:
                                            Opcion = "Diputados al parlacen Parlacen";
                                            break;
                                    }
                                    Console.WriteLine(Opcion);
                                    for (int i = 10; i >= 0; i--)
                                    {
                                        if (i > 0)
                                        {
                                            if (porsentajeRojoP[j] > i)
                                            {
                                                Console.WriteLine(" ");
                                            }
                                            if (porsentajeRojoP[j] <= i)
                                            {
                                                Console.WriteLine("█");
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("El porcentaje equivale al " + porsentajeRojoP[j] + "%");
                                        }
                                    }
                                }

                                Console.WriteLine("\n\tPorcentaje Partido Verde");
                                for (int j = 0; j < 6; j++)
                                {
                                    switch (j + 1)
                                    {
                                        case 1:
                                            Opcion = "Presidente";
                                            break;
                                        case 2:
                                            Opcion = "Vicepresidente";
                                            break;
                                        case 3:
                                            Opcion = "Alcalde Municial";
                                            break;
                                        case 4:
                                            Opcion = "Diputados en lista nacional";
                                            break;
                                        case 5:
                                            Opcion = "Diputado en lista distrital";
                                            break;
                                        case 6:
                                            Opcion = "Diputados al parlacen Parlacen";
                                            break;
                                    }
                                    Console.WriteLine(Opcion);
                                    for (int i = 10; i >= 0; i--)
                                    {
                                        if (i > 0)
                                        {
                                            if (porsentajeVerdeP[j] > i)
                                            {
                                                Console.WriteLine(" ");
                                            }
                                            if (porsentajeVerdeP[j] <= i)
                                            {
                                                Console.WriteLine("█");
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("El porcentaje equivale al " + porsentajeVerdeP[j] + "%");
                                        }
                                    }
                                }
                            }
                            R3 = "";
                            Console.ReadKey();
                        }
                        else if (R3 == "8")
                        {
                            Console.Clear();
                            Console.WriteLine("Ingrese la direccion donde se exportara las votaciones");
                            string direccion = "";
                            direccion = Console.ReadLine();
                            direccion = direccion + "\\";
                            StreamWriter Exportar = new StreamWriter(direccion + "Votaciones.csv");
                            int[] auxiliar1 = new int[5];
                            int[] auxiliar2 = new int[5];
                            int[] auxiliar3 = new int[5];
                            int[] auxiliar4 = new int[5];
                            for(int i = 0; i < 5; i++)
                            {
                                auxiliar1[i] = VotosAmarilloP[i];
                                auxiliar2[i] = VotosRojoP[i];
                                auxiliar3[i] = VotosVerdeP[i];
                                auxiliar4[i] = VotosNuloP[i];
                            }
                            string auxiliar = "";
                            for (int i = 0; i < MaximoVotos; i++)
                            {
                                for(int j = 0; j < 5; j++)
                                {
                                    if(auxiliar1[j] > 0)
                                    {
                                        auxiliar1[j]--;
                                        auxiliar = auxiliar + "A";
                                    }
                                    else if (auxiliar2[j] > 0)
                                    {
                                        auxiliar2[j]--;
                                        auxiliar = auxiliar + "R";
                                    }
                                    else if (auxiliar3[j] > 0)
                                    {
                                        auxiliar3[j]--;
                                        auxiliar = auxiliar + "V";
                                    }
                                    else if (auxiliar4[j] > 0)
                                    {
                                        auxiliar4[j]--;
                                        auxiliar = auxiliar + "";
                                    }

                                    if(j < 4)
                                    {
                                        auxiliar = auxiliar + ",";
                                    }
                                }
                                Exportar.WriteLine(auxiliar);
                            }
                            Exportar.Close();
                        }
                        else if(R3 == "9")
                        {
                            break;
                        }
                    }
                }
                else if (R1 == "3")
                {
                    break;
                }
            }
        }
    }
}
