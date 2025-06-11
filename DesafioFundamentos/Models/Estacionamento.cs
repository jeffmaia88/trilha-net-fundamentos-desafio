namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        public decimal precoInicial { get; set; }
        public decimal precoPorHora { get; set; }
        public List<string> veiculos { get; set; }

        public Estacionamento()
        {
            veiculos = new List<string>();
        }


        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar");
            string veiculo = Console.ReadLine();
            veiculos.Add(veiculo);

        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover");
            string placa = Console.ReadLine();

            if (veiculos.Contains(placa))
            {
                Console.WriteLine("Digite a quantidade de horas que o veiculo permaneceu estacionado:");
                int hora = Convert.ToInt32(Console.ReadLine());
                decimal valorFinal = (precoPorHora * hora) + precoInicial;
                Console.WriteLine($"O veiculo {placa} foi removido e o preço total foi de: R${valorFinal}");
                veiculos.Remove(placa);
            }
            else
            {
                Console.WriteLine("Veiculo não encontrado");

            }




        }

        public void ListarVeiculos()
        {
            Console.WriteLine("Os Veículos Estacionados São:");
            foreach (string veiculo in veiculos)
            {
                Console.WriteLine(veiculo);
            }
        }

      
    }
}
