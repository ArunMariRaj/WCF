
using ConsoleClient.BindingImplementations;

namespace ConsoleClient.SimpleFactory
{
    /// <summary>
    /// Implementing Simple Factory pattern
    /// </summary>
    public static class SimpleBindingFactory
    {
        public static AbstractSoapClientBindings GetBindingFactory(BindingTypes bindingType)
        {
            if (bindingType == BindingTypes.BasicHttpBinding)
            {
                return new BasicHttpBindingClient();
            }
            else if (bindingType == BindingTypes.WSHttpBinding)
            {
                return new WSHttpBindingClient();
            }
            else if (bindingType == BindingTypes.NetHttpBinding)
            {
                return new NetHttpBindingClient();
            }
            else if (bindingType == BindingTypes.NetTcpBinding)
            {
                return new NetTcpBindingClient();
            }
            else return null;
        }
    }
}
