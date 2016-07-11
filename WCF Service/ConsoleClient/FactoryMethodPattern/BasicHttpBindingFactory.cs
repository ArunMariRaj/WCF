using ConsoleClient.BindingImplementations;

namespace ConsoleClient.FactoryMethodPattern
{
    public class BasicHttpBindingFactory : BaseFactoryMethodCreator
    {
        public override AbstractSoapClientBindings CreateBinding()
        {
            return new BasicHttpBindingClient();
        }
    }
}
