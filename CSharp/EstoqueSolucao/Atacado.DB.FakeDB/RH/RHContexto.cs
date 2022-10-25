using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Atacado.Dominio.RH;

namespace Atacado.DB.FakeDB.RH
{
    public class RHContexto
    {
        public List<Usuario> Usuarios 
        {
            get => UsuarioFakeDB.Usuarios;
        }

        public List<Prestador> Prestadores
        {
            get => PrestadorFakeDB.Prestadores;
        }

        public List<Parceiro> Parceiros
        {
            get => ParceiroFakeDB.Parceiros;
        }

        public List<Colaborador> Colaboradores
        {
            get => ColaboradorFakeDB.Colaboradores;
        }

        public List<Endereco> Enderecos
        {
            get => EnderecoFakeDB.Enderecos;
        }

        public RHContexto()
        { }

        public Usuario AddUsuario(Usuario instancia)
        {
            int novaChave = this.Usuarios.Count + 1;
            instancia.Codigo = novaChave;
            this.Usuarios.Add(instancia);
            return instancia;
        }

        public Prestador AddPrestador(Prestador instancia)
        {
            int novaChave = this.Prestadores.Count + 1;
            instancia.Id = novaChave;
            this.Prestadores.Add(instancia);
            return instancia;
        }

        public Parceiro AddParceiro(Parceiro instancia)
        {
            int novaChave = this.Parceiros.Count + 1;
            instancia.Id = novaChave;
            this.Parceiros.Add(instancia);
            return instancia;
        }

        public Colaborador AddColaborador(Colaborador instancia)
        {
            int novaChave = this.Colaboradores.Count + 1;
            instancia.Id = novaChave;
            this.Colaboradores.Add(instancia);
            return instancia;
        }

        public Endereco AddEndereco(Endereco instancia)
        {
            int novaChave = this.Enderecos.Count + 1;
            instancia.Id = novaChave;
            this.Enderecos.Add(instancia);
            return instancia;
        }
    }
}
