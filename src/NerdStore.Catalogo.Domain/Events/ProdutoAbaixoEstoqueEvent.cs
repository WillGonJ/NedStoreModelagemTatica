

using NerdStore.Core.DomainObjects;
using System;

namespace NerdStore.Catalogo.Domain.Events
{
    public class ProdutoAbaixoEstoqueEvent : DomainEvent
    {
        public int QuantidadeRestante { get; private set; }
        public ProdutoAbaixoEstoqueEvent(Guid aggregateId, int quantidadeRegistro) : base(aggregateId)
        {
            QuantidadeRestante = quantidadeRegistro;
        }
    }
}
