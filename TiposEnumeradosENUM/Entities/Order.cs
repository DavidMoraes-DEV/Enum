using System;
using System.Collections.Generic;
using System.Text;
using TiposEnumeradosENUM.Entities.enums;

namespace TiposEnumeradosENUM.Entities
{
    class Order
    {

        public int Id  { get; set; } //Identificação
        public DateTime Moment { get; set; } //A data do instânte ocorrido
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return Id
                + ", "
                + Moment
                + ", "
                + Status;
        }

    }
}
