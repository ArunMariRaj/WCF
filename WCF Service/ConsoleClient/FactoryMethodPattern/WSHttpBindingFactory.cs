using ConsoleClient.BindingImplementations;

namespace ConsoleClient.FactoryMethodPattern
{
    public class WSHttpBindingFactory : BaseFactoryMethodCreator
    {
        public override AbstractSoapClientBindings CreateBinding()
        {
            return new WSHttpBindingClient();
        }
    }
}
