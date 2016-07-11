using ConsoleClient.BindingImplementations;

namespace ConsoleClient.FactoryMethodPattern
{
    public abstract class BaseFactoryMethodCreator
    {
        public abstract AbstractSoapClientBindings CreateBinding();
    }
}
