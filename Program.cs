using System.Numerics;



    Console.WriteLine("Olá herói! Seja bem-vindo ao classificador de pontos. Como você se chama?");

    string nome = Console.ReadLine();

    Console.WriteLine("Quantos pontos de experiência (XP) você possui?");

    string resposta = Console.ReadLine();
    int pontos  = Convert.ToInt32(resposta);
            

            string? nivel; 

            if (pontos <= 1000)
            {
                nivel = "Ferro";
            }

            else if (pontos >= 1001 && pontos <= 2000)
            {
                nivel = "Bronze";
            }

            else if (pontos >= 2001 && pontos <= 5000)
            {
                nivel = "Prata";
            }

            else if (pontos >= 5001 && pontos <= 7000)
            {
                nivel = "Ouro";
            }

            else if (pontos >= 7001 && pontos <= 8000)
            {
                nivel = "Platina";
            }

            else if (pontos >= 8001 && pontos <= 9000)
            {
                nivel = "Ascendente";
            }

            else if (pontos >= 9001 && pontos <= 10000)
            {
                nivel = "Imortal";
            }

            else
            {
                nivel = "Radiante";
            }
     
 Console.WriteLine($"O Herói de nome {nome} está no nível de {nivel}");

