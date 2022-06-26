using AvaliadorDeCredito.DataBase;
using AvaliadorDeCredito.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;


    public static class ClienteEndPoints
    {
        public static void MapClienteEndPoints(this WebApplication app)
        {

            app.MapPost("AdicionarCliente", async (Cliente cliente, Contexto contexto) =>
            {
                cliente.DataCadastro = DateTime.Now;

                contexto.Cliente.Add(cliente);
                await contexto.SaveChangesAsync();
            });

            app.MapGet("ListarCliente", async (Contexto contexto) =>
            {
                return await contexto.Cliente.ToListAsync();
            });

            app.MapPost("ProcurarCliente/{cpf}", async (string cpf, Contexto contexto) =>
            {
                return await contexto.Cliente.FirstOrDefaultAsync(c => c.Cpf == cpf);
            });

            app.MapDelete("ExcluirCliente/{cpf}", async (string cpf, Contexto contexto) =>
            {
                var clienteExcluir = await contexto.Cliente.FirstOrDefaultAsync(c => c.Cpf == cpf);
                if (clienteExcluir != null)
                {
                    contexto.Cliente.Remove(clienteExcluir);
                    await contexto.SaveChangesAsync();
                }
            });

            app.MapPost("AvaliarCredito/{cpf}", async (string cpf, Contexto contexto, Cliente teste) =>
            {
         
                var cliente = await contexto.Cliente.FirstOrDefaultAsync(c => c.Cpf == cpf);
                var idade = cliente.DataCadastro.Value.Year - cliente.DataNascimento.Value.Year;
                cliente.Idade = idade;

                var aprovado = "Cliente Aprovado";
                var reprovado = "Cliente Reprovado";
                if (cliente.Idade >= 18 && cliente.Cidade.ToString() != "Santo Cristo")
                {
                    cliente.Situacao = aprovado;
                }
                else
                {
                    cliente.Situacao = reprovado;
                }

                double ateUm = 0.3;
                double ateCinco = 0.4;
                double ateDez = 0.6;
                double ateVinte = 0.7;
                double acimaVinte = 0.8;

                var limiteAteUm = cliente.Salario.Value * ateUm;
                var limiteAteCinco = cliente.Salario.Value * ateCinco;
                var limiteAteDez = cliente.Salario.Value * ateDez;
                var limiteAteVinte = cliente.Salario.Value * ateVinte;
                var limiteAcimaVinte = cliente.Salario.Value * acimaVinte;

                if(cliente.Situacao == aprovado)
                {
                    if (cliente.Salario <= 1000)
                    {   
                        cliente.Limite = limiteAteUm.ToString();
                    }
                    else if (cliente.Salario <= 5000)
                    {
                        cliente.Limite = limiteAteCinco.ToString();
                    }
                    else if (cliente.Salario <= 10000)
                    {
                        cliente.Limite = limiteAteDez.ToString();
                    }
                    else if (cliente.Salario <= 20000)
                    {
                        cliente.Limite = limiteAteVinte.ToString();
                    }
                    else if (cliente.Salario > 20000)
                    {
                        cliente.Limite = limiteAcimaVinte.ToString();
                    }
                }
                
                return cliente;
                
            });
        }   
    }

