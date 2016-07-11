using System.ServiceModel;
using System.ServiceModel.Channels;

namespace ConsoleClient.BindingImplementations
{
    public enum BindingTypes
    {
        BasicHttpBinding,
        WSHttpBinding,
        NetHttpBinding,
        NetTcpBinding
    }
    public abstract class AbstractSoapClientBindings
    {
        public virtual Binding BindingType { get; set; }
        public virtual EndpointAddress EndPoint { get; set; }
    }
}
