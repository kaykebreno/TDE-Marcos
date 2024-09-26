using System;
using System.Collections.Generic;
using System.Linq;

namespace Inventario
{
    internal class Garagem
    {
        public class Carro
        {
            public int Id { get; set; }
            public string Marca { get; set; }
            public string Modelo { get; set; }
            public string Cor { get; set; }
            public int Ano { get; set; }
          

            public Carro(int id, string marca, string modelo, string cor, int ano, string placa)
            {
                Id = id;
                Marca = marca;
                Modelo = modelo;
                Cor = cor;
                Ano = ano;
            }
        }

        public class Inventory
        {
            private List<Carro> _garagem = new List<Carro>();

            public void AdicionarCarro(Carro item)
            {
                _garagem.Add(item);
            }

            public void RemoverCarro(int itemId)
            {
                var itemToRemove = _garagem.FirstOrDefault(i => i.Id == itemId);
                if (itemToRemove != null)
                {
                    _garagem.Remove(itemToRemove);
                }
            }

            public void AtualizarCarro(int itemId, string marca, string modelo, string cor, int ano, string placa)
            {
                var itemToUpdate = _garagem.FirstOrDefault(i => i.Id == itemId);
                if (itemToUpdate != null)
                {
                    itemToUpdate.Marca = marca;
                    itemToUpdate.Modelo = modelo;
                    itemToUpdate.Cor = cor;
                    itemToUpdate.Ano = ano;
                }
            }

            public List<Carro> GetItens()
            {
                return _garagem;
            }
        }
    }
}
