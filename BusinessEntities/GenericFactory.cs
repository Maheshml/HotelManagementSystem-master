using System;
using System.Collections.Generic;

namespace BusinessEntities
{
    //
    //	To use just call GenericFactory.Create<ObjectType>(PARAMS FOR THE CONSTRUCTOR)
    //  Handles so that developers are not allowed to create Instances or abstract classes.
    //

    public class GenericFactory
    {
        private static GenericFactory factory = null;
        private static readonly object padlock = new object();

        private readonly Dictionary<Guid, Type> _dict;
        public static GenericFactory GetInstance()
        {
            lock (padlock)
            {
                if (factory == null)
                {
                    factory = new GenericFactory();
                }
                return factory;
            }
        }
        private GenericFactory()
        {
            _dict = new Dictionary<Guid, Type>();
        }

        public void Register<T>(Guid key)
        {
            if ((typeof(T).IsInterface) || (typeof(T).IsAbstract))
                throw new ArgumentException("GenericFactory::Register: type must not be an interface or abstract.");
            _dict.Add(key, typeof(T));
        }

        public TType Create<TType>(Guid key, params object[] args)
        {
            Type obj;
            if (_dict.TryGetValue(key, out obj))
                return (TType)Activator.CreateInstance(obj, args);

            throw new ArgumentException("GenericFactory::CreateObj: type has not been registered for this key.");
        }

        public static T CreateNewObject<T>(params object[] args)
        {
            if (factory == null)
            {
                GenericFactory.GetInstance();
            }
            try
            {
                Guid uid = Guid.NewGuid();
                factory.Register<T>(uid);
                return factory.Create<T>(uid, args);
            }
            catch (ArgumentException e)
            {
                throw new ArgumentException(e.ToString());
            }

        }
    }




}
