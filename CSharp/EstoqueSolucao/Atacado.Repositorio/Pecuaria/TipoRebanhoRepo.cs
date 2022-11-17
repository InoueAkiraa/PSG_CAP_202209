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
    public class TipoRebanhoRepo : BaseRepositorio<TipoRebanho>
    {
        private ProjetoAcademiaContext contexto;

        public TipoRebanhoRepo()
        {
            this.contexto = new ProjetoAcademiaContext();
        }

        public override TipoRebanho Create(TipoRebanho instancia)
        {
            this.contexto.TipoRebanhos.Add(instancia);
            this.contexto.SaveChanges();
            return instancia;
        }

        public override TipoRebanho Delete(int chave)
        {
            TipoRebanho del = this.Read(chave);
            if (del == null)
            {
                return null;
            }
            else
            {
                this.contexto.TipoRebanhos.Remove(del);
                this.contexto.SaveChanges();
                return del;
            }
        }

        public override TipoRebanho Delete(TipoRebanho instancia)
        {
            return this.Delete(instancia.CodigoTipoRebanho);
        }

        public override TipoRebanho Read(int chave)
        {
            return this.contexto.TipoRebanhos.SingleOrDefault(tip => tip.CodigoTipoRebanho == chave);
        }

        public override IQueryable<TipoRebanho> Read(Expression<Func<TipoRebanho, bool>> predicate = null)
        {
            if (predicate == null)
            {
                return this.contexto.TipoRebanhos.AsQueryable();
            }
            else
            {
                return this.contexto.TipoRebanhos.Where(predicate).AsQueryable();
            }
        }

        public override List<TipoRebanho> Read()
        {
            return this.contexto.TipoRebanhos.ToList();
        }

        public override TipoRebanho Update(TipoRebanho instancia)
        {
            TipoRebanho atu = this.Read(instancia.CodigoTipoRebanho);
            if (atu == null)
            {
                return null;
            }
            else
            {
                instancia.Descricao = atu.Descricao;
                instancia.Situacao = atu.Situacao;
                instancia.DataAlteracao = atu.DataAlteracao;
                instancia.DataExclusao = atu.DataExclusao;
                this.contexto.SaveChanges();
                return atu;
            }
        }
    }
}
