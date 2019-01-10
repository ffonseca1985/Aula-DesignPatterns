using ReflectionFactory.Contracts;
using System;
using System.Linq;

using System.Reflection;

namespace ReflectionFactory.Factories
{
    public class DesenhoFactory
    {
        public static IDesenho Create(string nome)
        {
            //O que tenho que fazer..???
            //Tenho que achar a classe com o nome informado
            //E a partir do nome criar a minha classe
            Assembly assembly = Assembly.GetExecutingAssembly();

            //Estou pegando o tipo da classe que corresponde ao nome informado
            var tipoDesenho =  assembly.GetTypes().FirstOrDefault(x => x.Name.ToLower() == nome.ToLower());

            //Criando a instancia
            //Tenho que fazer um cast porque o createInstance retorna object
            var instance = (IDesenho)Activator.CreateInstance(tipoDesenho);

            return instance;
        }
    }
}
