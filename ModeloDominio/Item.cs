using System;
using System.Collections.Generic;
using System.Text;

namespace ModeloDominio
{
    class Item
    {

        //Modelo de domínio rico
        public Item(int itemId, int pedidoId, string itemNome, decimal itemPreco)
        {
            if (pedidoId <= 0)
            {
                throw new ArgumentException("O código do Pedido deve ser maior que 0");
            }
            if (itemId <= 0)
            {
                throw new ArgumentException("O código do Item deve ser maior que 0");
            }

            this.PedidoId = pedidoId;
            this.ItemId = itemId;
            this.ItemNome = itemNome;
            this.Itempreco = itemPreco;

        }

        public int ItemId { get; private set; }
        public int PedidoId { get; private set; }


        private string _itemNome;
        public string ItemNome
        {
            get => this._itemNome;
            private set 
            {
                this._itemNome = (value.Length > 100) ? throw new ArgumentOutOfRangeException(nameof(ItemNome), "O nome do Item não pode exeder 100 caracteres") : value;
            }            
        }

        private decimal _itemPreco;
        public decimal Itempreco
        {
            get => this._itemPreco;
            private set 
            {
                this._itemPreco = (value < 0) ? throw new ArgumentOutOfRangeException(nameof(Itempreco), "O preço deve ser maior que 0") : value;
            } 
        }

    }
}
