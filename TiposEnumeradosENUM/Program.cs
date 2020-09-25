using System;
using TiposEnumeradosENUM.Entities;
using TiposEnumeradosENUM.Entities.enums;

namespace TiposEnumeradosENUM
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Enumeração ou tipo enumerado é um tipo especial que serva para especificar de forma literal um conjunto de constantes relacionadas.
                Palavra chave em C#: enum (enum é um tipo valor)
                VANTAGEM: Melhor semântica, código mais legível e auxiliado pelo compilador.
             */

            Order order = new Order { Id = 1080, Moment = DateTime.Now, Status = OrderStatus.PendingPayment }; //Instanciando e já atribuindo os valores para o novo pedido.

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString(); //Convertendo o tipo enumerado para string

            Console.WriteLine(txt);

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered"); //Convertendo o tipo string para o tipo enumerado.

            Console.WriteLine(os);

        }
    }
}
