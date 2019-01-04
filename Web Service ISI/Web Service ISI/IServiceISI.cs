using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Web_Service_ISI
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IServiceISI
    {
        //Listar Refeições
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/refeicoes")]
        [Description("Listar todas as refeições")]
        List<Refeicao> ListarRefeicoes();

        //Adicionar Refeições
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/refeicoes")]
        [Description("Adicionar refeição.")]
        void AddRefeicao(Refeicao r);


        //Calculadora de Calorias
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/Calorias?idade={idade}&genero={genero}&altura={altura}&peso={peso}&actividade={actividade}")]
        [Description("Calorias")]
        double CalculadoraCalorias(double idade, string genero, double altura, double peso, string atividade);

        //Calculadora de Peso Ideal
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/PesoIdeal?genero={genero}&altura={altura}")]
        [Description("Peso Ideal")]
        double CalculadoraPesoIdeal(string genero, int altura);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.

    [DataContract]
    public class Refeicao
    {
        internal static string refeicoes;

        public Refeicao(string restaurante, string item, string quantidade, string calorias)
        {
            this.restaurante = restaurante;
            this.item = item;
            this.quantidade = quantidade;
            this.calorias = calorias;
        }

        public static string Restaurante { get; internal set; }
        public static string Item { get; internal set; }
        public static object Quantidade { get; internal set; }
        public static string Calorias { get; internal set; }
        [DataMember]
        public string restaurante { get; set; }
        [DataMember]
        public string item { get; set; }
        [DataMember]
        public string quantidade { get; set; }
        [DataMember]
        public string calorias { get; set; }
      
        public override string ToString()
        {
            string res = string.Empty;
            res += "Restaurante: " + restaurante + Environment.NewLine;
            res += "Item: " + item + Environment.NewLine;
            res += "Qauntidade: " + quantidade + Environment.NewLine;
            res += "Calorias: " + calorias + Environment.NewLine;
            return res;
        }
    }




    [DataContract]
    public class DadosPessoaisPI
    {
        public DadosPessoaisPI(int idade, string genero, int altura)
        {
            this.idade = idade;
            this.genero = genero;
            this.altura = altura;
        }

        [DataMember]
        public int idade { get; set; }
        [DataMember]
        public string genero { get; set; }
        [DataMember]
        public int altura { get; set; }

        public override string ToString()
        {
            string res = string.Empty;
            res += "idade: " + idade + Environment.NewLine;
            res += "género: " + genero + Environment.NewLine;
            res += "altura: " + altura + Environment.NewLine;
            return res;
        }

    }

    [DataContract]
    public class DadosPessoaisC
    {
        public DadosPessoaisC(int idade, string genero, int altura, double peso, string atividade)
        {
            this.idade = idade;
            this.genero = genero;
            this.altura = altura;
            this.peso = peso;
            this.atividade = atividade;
                
        }

        [DataMember]
        public int idade { get; set; }
        [DataMember]
        public string genero { get; set; }
        [DataMember]
        public int altura { get; set; }
        [DataMember]
        public double peso { get; set; }
        [DataMember]
        public string atividade { get; set; }


        public override string ToString()
        {
            string res = string.Empty;
            res += "idade: " + idade + Environment.NewLine;
            res += "género: " + genero + Environment.NewLine;
            res += "altura: " + altura + Environment.NewLine;
            res += "peso: " + peso + Environment.NewLine;
            res += "atividade: " + atividade + Environment.NewLine;
            return res;
        }

    }

}
