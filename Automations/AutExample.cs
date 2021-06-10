using System;
using System.Collections.Generic;
using Atl.Dal.Core;
using Atl.Bll.Core;

public class AutExample : AutomacaoBase
{
    public override void Run()
    {
        var sql = "SELECT codigo, razaosocial FROM empresa;";
        new DbHelper(Session).ExecuteReader(sql, reader =>
        {
            var empresas = new List<string>();
            while (reader.Read())
            {
                empresas.Add(reader.GetInt32(0) + " - " + reader["razaosocial"]);
            }

            var mensagem = String.Join(Environment.NewLine, empresas);
            var assunto = "Mensagem enviada pelo robô";
            var emailsDestino = new[] {"email_destino@hotmail.com"};
            EnviaMensagemEmail(emailsDestino, assunto, mensagem);
        });
    }
}