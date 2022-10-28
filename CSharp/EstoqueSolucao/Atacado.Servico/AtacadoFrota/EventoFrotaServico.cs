using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Atacado.Servico.Base;
using Atacado.Dominio.AtacadoFrota;
using Atacado.Poco.AtacadoFrota;
using Atacado.Repositorio.AtacadoFrota;
using Atacado.Repositorio.Base;

namespace Atacado.Servico.AtacadoFrota
{
    public class EventoFrotaServico : BaseServico<EventoFrotaPoco, EventoFrota>
    {
        private EventoFrotaRepo repo;

        public EventoFrotaServico()
        {
            this.repo = new EventoFrotaRepo();
        }

        public override EventoFrotaPoco Add(EventoFrotaPoco poco)
        {
            EventoFrota nova = this.ConvertTo(poco);
            EventoFrota criada = this.repo.Create(nova);
            return this.ConvertTo(criada);
        }

        public override List<EventoFrotaPoco> Browse()
        {
            List<EventoFrotaPoco> listaPoco = this.repo.Read()
               .Select(eve =>
                   new EventoFrotaPoco()
                   {
                       Ativo = eve.Ativo,
                       Codigo = eve.Codigo,
                       DataInclusao = eve.DataInclusao,
                       Condutor = eve.Condutor,
                       DataInicial = eve.DataInicial,
                       DataFinal = eve.DataFinal,
                       KmInicial = eve.KmInicial,
                       KmFinal = eve.KmFinal,
                       MotivoEvento = eve.MotivoEvento
                   }
               )
               .ToList();
            return listaPoco;
        }

        public override EventoFrotaPoco ConvertTo(EventoFrota dominio)
        {
            return new EventoFrotaPoco()
            {
                Ativo = dominio.Ativo,
                Codigo = dominio.Codigo,
                DataInclusao = dominio.DataInclusao,
                Condutor = dominio.Condutor,
                DataInicial = dominio.DataInicial,
                DataFinal = dominio.DataFinal,
                KmInicial = dominio.KmInicial,
                KmFinal = dominio.KmFinal,
                MotivoEvento = dominio.MotivoEvento
            };
        }

        public override EventoFrota ConvertTo(EventoFrotaPoco poco)
        {
            return new EventoFrota(poco.Ativo, poco.Codigo, poco.DataInclusao, poco.Condutor, poco.DataInicial,
                poco.DataFinal, poco.KmInicial, poco.KmFinal, poco.MotivoEvento);
        }

        public override EventoFrotaPoco Delete(int chave)
        {
            EventoFrota del = this.repo.Delete(chave);
            EventoFrotaPoco delPoco = this.ConvertTo(del);
            return delPoco;

        }

        public override EventoFrotaPoco Delete(EventoFrotaPoco poco)
        {
            EventoFrota del = this.repo.Delete(poco.Codigo);
            EventoFrotaPoco delPoco = this.ConvertTo(del);
            return delPoco;
        }

        public override EventoFrotaPoco Edit(EventoFrotaPoco poco)
        {
            EventoFrota editada = this.ConvertTo(poco);
            EventoFrota alterada = this.repo.Update(editada);
            EventoFrotaPoco alteradaPoco = this.ConvertTo(alterada);
            return alteradaPoco;
        }

        public override EventoFrotaPoco Read(int chave)
        {
            EventoFrota lida = this.repo.Read(chave);
            EventoFrotaPoco lidaPoco = this.ConvertTo(lida);
            return lidaPoco;
        }
    }
}
