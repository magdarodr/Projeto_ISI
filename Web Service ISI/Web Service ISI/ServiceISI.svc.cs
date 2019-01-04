using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web.Hosting;
using System.Xml;

namespace Web_Service_ISI
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class ServiceISI : IServiceISI
    {

        private static string FILEPATH;
        private string atividade;

        public ServiceISI()
        {
            FILEPATH = Path.Combine(HostingEnvironment.ApplicationPhysicalPath, "App_Data",
                "refeicoes.xml");
        }

        public object JsonConvert { get; private set; }
        public double BMRF { get; private set; }
        public double BMRM { get; private set; }
        public double BMR { get; private set; }



        //Calculadora de Calorias
        public double CalculadoraCalorias(double idade, string genero, double altura, double peso, string atividade)
        {
            BMRF = ((10 * peso) + (6.25 * altura) - (5 * idade) - 161);
            BMRM = ((10 * peso) + (6.25 * altura) - (5 * idade) + 5);
            double atividadeV = 0;
            double caloria = 0;
            double caloriasTotal = ((caloria * atividadeV));

            switch (atividade)
            {
                case "TMB":
                    if (genero == "Feminino")
                    {
                        BMR = (655.1 + (9.5 * peso) + (1.8 * altura) - (4.7 * idade));
                        return BMR;
                    }
                    else
                    {
                        BMR = (66.5 + (13.8 * peso) + (5 * altura) - (6.8 * idade));
                        return BMR;
                    }

                case "1":
                    if (genero == "Feminino")
                    {
                        caloria = (BMRF * 0.0012);
                        return caloria;
                    }
                    else
                    {
                        caloria = (BMRM * 0.0012);
                        return caloria;
                    }

                case "2":
                    if (genero == "Feminino")
                    {
                        caloria = (BMRF * 1.375);
                        return caloria;
                    }
                    else
                    {
                        caloria = (BMRM * 1.375);
                        return caloria;
                    }

                case "3":
                    if (genero == "Feminino")
                    {
                        caloria = (BMRF * 1.55);
                        return caloria;
                    }
                    else
                    {
                        caloria = (BMRM * 1.55);
                        return caloria;
                    }

                case "4":
                    if (genero == "Feminino")
                    {
                        caloria = (BMRF * 1.725);
                        return caloria;
                    }
                    else
                    {
                        caloria = (BMRM * 1.725);
                        return caloria;
                    }

                case "5":
                    if (genero == "Feminino")
                    {
                        caloria = (BMRF * 1.9);
                        return caloria;
                    }
                    else
                    {
                        caloria = (BMRM * 1.9);
                        return caloria;
                    }
            }
            return -1;
        }


        //Calculadora Peso Ideal
        public double CalculadoraPesoIdeal(string genero, int altura)
        {
            double inAMais = 0;
            double aux = 0;
            double fiveft = 152.4;

            aux = altura - fiveft;
            inAMais = aux / 2.54;

            //homem = 56.2 + (1.41 * inAMais);
            //mulher = 53.1 + (1.36 * inAMais);

            if (genero == "Masculino")
            {
                double pesoIdealM = 56.2 + (1.41 * inAMais);
                return pesoIdealM;
            }

            else if (genero == "Feminino")
            {
                double pesoIdealF = 53.1 + (1.36 * inAMais);
                return pesoIdealF;

            }
            
                return -1;
        }



        //Listar Refeições
        public List<Refeicao> ListarRefeicoes()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(FILEPATH);
            List<Refeicao> refeicoes = new List<Refeicao>();
            XmlNodeList refeicaoNodes = doc.SelectNodes("/refeicoes/refeicao");
            foreach (XmlNode refeicaoNode in refeicaoNodes)
            {
                XmlNode restauranteNode = refeicaoNode.SelectSingleNode("Restaurante");
                XmlNode itemNode = refeicaoNode.SelectSingleNode("Item");
                XmlNode quantidadeNode = refeicaoNode.SelectSingleNode("Quantidade");
                XmlNode caloriasNode = refeicaoNode.SelectSingleNode("Calorias");
                Refeicao refeicao = new Refeicao(
                restauranteNode.InnerText,
                itemNode.InnerText,
                quantidadeNode.InnerText,
                caloriasNode.InnerText
                );
                refeicoes.Add(refeicao);
            }
            return refeicoes;
        }


        //Adicionar Refeição
        public void AddRefeicao(Refeicao r)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(FILEPATH);
            XmlNode refeicoesNode = doc.SelectSingleNode("/refeicoes/refeicao");
            XmlElement refeicaoNode = doc.CreateElement("refeicao");
            //refeicaoNode.SetAttribute("Refeicoes", Refeicao.refeicoes);
            XmlElement restauranteNode = doc.CreateElement("Restaurante");
            restauranteNode.InnerText = Refeicao.Restaurante;
            refeicaoNode.AppendChild(restauranteNode);
            XmlElement itemNode = doc.CreateElement("Item");
            itemNode.InnerText = Refeicao.Item;
            refeicaoNode.AppendChild(itemNode);
            XmlElement quantidadeNode = doc.CreateElement("Quantidade");
            quantidadeNode.InnerText = Refeicao.Quantidade.ToString();
            refeicaoNode.AppendChild(quantidadeNode);
            XmlElement caloriasNode = doc.CreateElement("Calorias");
            caloriasNode.InnerText = Refeicao.Calorias;
            refeicaoNode.AppendChild(caloriasNode);
            refeicaoNode.AppendChild(refeicaoNode);
            doc.Save(FILEPATH);

        }

    }
}
