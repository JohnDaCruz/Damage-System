using DamageSystem.Buffs;
using DamageSystem.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DamageSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            GameInit gameStart = new();

            while (true)
            {
                Console.WriteLine(" ____   ____    ____   ____                                          ____              \r\n|  _ \\ |  _ \\  / ___| |  _ \\   __ _  _ __ ___    __ _   __ _   ___  / ___|  _   _  ___ \r\n| |_) || |_) || |  _  | | | | / _` || '_ ` _ \\  / _` | / _` | / _ \\ \\___ \\ | | | |/ __|\r\n|  _ < |  __/ | |_| | | |_| || (_| || | | | | || (_| || (_| ||  __/  ___) || |_| |\\__ \\\r\n|_| \\_\\|_|     \\____| |____/  \\__,_||_| |_| |_| \\__,_| \\__, | \\___| |____/  \\__, ||___/\r\n                                                       |___/                |___/     ");
                Console.WriteLine("Selecione uma opção");
                Console.WriteLine("1 - Iniciar Game \n2 - Sair");
                Console.Write("Opção escolhida: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        gameStart.GameStart();
                        return;
                    case 2:
                        Console.WriteLine("Saindo do game...");
                        return;
                    default:
                        return;
                }

            }


        }
    }
}
