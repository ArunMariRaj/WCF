using ConsoleClient.BindingImplementations;

namespace ConsoleClient.FactoryMethodPattern
{
    public class NetHttpBindingFactory : BaseFactoryMethodCreator
    {
        public override AbstractSoapClientBindings CreateBinding()
        {
            return new NetHttpBindingClient();
        }
    }
}
