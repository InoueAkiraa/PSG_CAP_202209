using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Atacado.Repositorio.Base;
using Atacado.DB.EF.Database;
using System.Linq.Expressions;

namespace Atacado.Repositorio.Pecuaria
{
    public class RebanhoRepo : BaseRepositorio<Rebanho>
    {
        private ProjetoAcademiaContext contexto;

        public RebanhoRepo()
        {
            this.contexto = new ProjetoAcademiaContext();
        }
        public override Rebanho Create(Rebanho instancia)
        {
            this.contexto.Rebanhos.Add(instancia);
            this.contexto.SaveChanges();
            return instancia;
        }

        public override Rebanho Delete(int chave)
        {
            Rebanho del = this.Read(chave);
            if (del == null)
            {
                return null;
            }
            else
            {
                this.contexto.Rebanhos.Remove(del);
                this.contexto.SaveChanges();
                return del;
            }
        }

        public override Rebanho Delete(Rebanho instancia)
        {
            return this.Delete(instancia.CodigoRebanho);
        }

        public override Rebanho Read(int chave)
        {
            return this.contexto.Rebanhos.SingleOrDefault(reb => reb.CodigoRebanho == chave);
        }

        public override IQueryable<Rebanho> Read(Expression<Func<Rebanho, bool>> predicate = null)
        {
            if (predicate == null)
            {
                return this.contexto.Rebanhos.AsQueryable();
            }
            else
            {
                return this.contexto.Rebanhos.Where(predicate).AsQueryable();
            }
        }

        public override List<Rebanho> Read()
        {
            return this.contexto.Rebanhos.ToList();
        }

        public override Rebanho Update(Rebanho instancia)
        {
            Rebanho atu = this.Read(instancia.CodigoRebanho);
            if (atu == null)
            {
                return null;
            }
            else
            {
                instancia.AnoRef = atu.AnoRef;
                instancia.CodigoMunicipio = atu.CodigoMunicipio;
                instancia.CodigoTipoRebanho = atu.CodigoTipoRebanho;
                instancia.DescricaoTipoRebanho = atu.DescricaoTipoRebanho;
                instancia.Quantidade = atu.Quantidade;
                instancia.Situacao = atu.Situacao;
                instancia.DataAlteracao = atu.DataAlteracao;
                instancia.DataExclusao = atu.DataExclusao;
                this.contexto.SaveChanges();
                return atu;
            }
        }
    }
}
