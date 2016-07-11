using ConsoleClient.BindingImplementations;

namespace ConsoleClient.FactoryMethodPattern
{
    public class NetTcpBindingFactory : BaseFactoryMethodCreator
    {
        public override AbstractSoapClientBindings CreateBinding()
        {
            return new NetHttpBindingClient();
        }
    }
}
