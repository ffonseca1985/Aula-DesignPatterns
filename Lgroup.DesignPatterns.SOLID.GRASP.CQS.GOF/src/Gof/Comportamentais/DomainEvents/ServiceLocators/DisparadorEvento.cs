using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Reflection;
using DomainEvents.Contracts;

namespace DomainEvents.ServiceLocators
{
    public class DisparadorEvento<T> 
        where T : IDomainEvent
    {
        //Preciso localizar estes caras para enviar o evento para eles.
        public static IList<Type> handlers = new List<Type>();
        
        static DisparadorEvento()
        {
            //1 - preciso pegar as instancias em execução
            var types = Assembly.GetExecutingAssembly().GetTypes();


            //2 - precisamos saber as classes que herdam de IHandler<>
            foreach (var type in types)
            {
                //O tipo pode herdar de mais de uma interface
                foreach (var interf in type.GetInterfaces())
                {
                    if (interf.IsGenericType && 
                        //interf.GetGenericTypeDefinition() == typeof(IHandler<IDomainEvent>))
                        interf.GetGenericTypeDefinition() == typeof(IHandler<>))
                    {
                        handlers.Add(type);
                    }
                }
            }
        }

        public static void Disparar(T evento)
        {
            handlers.ToList().ForEach(x =>
                ((IHandler<T>)Activator.CreateInstance(x)).Handler(evento));
        }
    }
}
