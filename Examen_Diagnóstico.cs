﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Diagnóstico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables
            int jugo, tamaño, cantidad, pago;
            double precio = 0, importe, importe_final = 0;
            string jugo_elegido = " ", metodo_pago = " ";
            //Tipo de jugos
            Console.WriteLine("=========================================");
            Console.WriteLine("               JUGUERIA");
            Console.WriteLine("=========================================");
            Console.WriteLine("Ingrese el número del jugo que desea:");
            Console.WriteLine("[1] Jugo de naranja");
            Console.WriteLine("[2] Jugo de fresas");
            Console.WriteLine("[3] Jugo de lucuma");
            Console.WriteLine("[4] Jugo de papaya");
            Console.WriteLine("[5] Jugo surtido");
            Console.WriteLine("[6] Jugo de piña");
            jugo = int.Parse(Console.ReadLine());
            //Tamaño de jugos
            Console.WriteLine("Ingrese el tamaño del jugo que desea:");
            Console.WriteLine("[1] Largo");
            Console.WriteLine("[2] Mediano");
            Console.WriteLine("[3] Pequeño");
            tamaño = int.Parse(Console.ReadLine());
            //Cantidad de jugos
            Console.WriteLine("Ingrese la cantidad de jugos en números (máx 20)");
            cantidad = int.Parse(Console.ReadLine());
            //Método de pago
            Console.WriteLine("¿Por cuál medio va a realizar el pago?");
            Console.WriteLine("[1] Efectivo (10% de descuento)");
            Console.WriteLine("[2] Tarjeta (5% de recargo)");
            pago = int.Parse(Console.ReadLine());
            //Jugo elegido
            switch (jugo)
            {
                case 1: jugo_elegido = "Jugo de naranja"; break;
                case 2: jugo_elegido = "Jugo de fresas"; break;
                case 3: jugo_elegido = "Jugo de lucuma"; break;
                case 4: jugo_elegido = "Jugo de papaya"; break;
                case 5: jugo_elegido = "Jugo surtido"; break;
                case 6: jugo_elegido = "Jugo de piña"; break;
            }
            //Opción incorrecta
            if (jugo < 1 || jugo > 6 || tamaño < 1 || tamaño > 3 || cantidad < 1 || cantidad > 20 || pago < 1 || pago > 2)
            {
                Console.WriteLine("Número inválido, vuelva a intentarlo");
                return;
            }
            //Operaciones
            switch (jugo)
            {
                case 1: if (tamaño == 1) precio = 15.50;
                    else if (tamaño == 2) precio = 12;
                    else if (tamaño == 3) precio = 10.50; break;

                case 2: if (tamaño == 1) precio = 17;
                    else if (tamaño == 2) precio = 13.70;
                    else if (tamaño == 3) precio = 11.50; break;

                case 3: if (tamaño == 1) precio = 14.20;
                    else if (tamaño == 2) precio = 11.50;
                    else if (tamaño == 3) precio = 9.70; break;

                case 4: if (tamaño == 1) precio = 10;
                    else if (tamaño == 2) precio = 8.50;
                    else if (tamaño == 3) precio = 6.50; break;

                case 5: if (tamaño == 1) precio = 20;
                    else if (tamaño == 2) precio = 17;
                    else if (tamaño == 3) precio = 15; break;

                case 6: if (tamaño == 1) precio = 11.50;
                    else if (tamaño == 2) precio = 9.40;
                    else if (tamaño == 3) precio = 7.20; break;
            }
            importe = precio * cantidad;
            //Descuento o recargo
            if (pago == 1)
            {
                importe_final = importe * 0.90;
                metodo_pago = "Efectivo";
            }
            else if (pago == 2)
            {
                importe_final = importe * 1.05;
                metodo_pago = "Tarjeta";
            }
            //Boleta final
            Console.WriteLine("=========================================");
            Console.WriteLine("                BOLETA");
            Console.WriteLine("=========================================");
            Console.WriteLine("El jugo elegido es: " + jugo_elegido);
            Console.WriteLine("El precio de la bebida elegida es: S/" + precio);
            Console.WriteLine("Precio por la cantidad de bebidas ("+ cantidad +"): S/" + importe);
            Console.WriteLine("Método de pago: " + metodo_pago);
            Console.WriteLine("Importe final con el descuento/recargo aplicado: S/" + importe_final);
            Console.WriteLine("");
            Console.WriteLine("Gracias por su compra!");
            Console.ReadKey();
        }
    }
}