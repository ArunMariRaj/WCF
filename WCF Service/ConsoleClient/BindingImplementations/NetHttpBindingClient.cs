using System.Configuration;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace ConsoleClient.BindingImplementations
{
    public class NetHttpBindingClient : AbstractSoapClientBindings
    {
        private Binding _binding = null;
        private EndpointAddress _endpoint = null;

        public override Binding BindingType
        {
            get
            {
                if (_binding == null)
                {
                    _binding = new NetHttpBinding();
                }
                return _binding;
            }

            set
            {
                _binding = value;
            }
        }

        public override EndpointAddress EndPoint
        {
            get
            {
                if (_endpoint == null)
                {
                    _endpoint = new EndpointAddress(ConfigurationManager.AppSettings["netHttpBindingEndpoint"]);
                }
                return _endpoint;
            }

            set
            {
                _endpoint = value;
            }
        }
    }

}
