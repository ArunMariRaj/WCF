using System.Configuration;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace ConsoleClient.BindingImplementations
{
    public class BasicHttpBindingClient : AbstractSoapClientBindings
    {
        private Binding _binding = null;
        private EndpointAddress _endpoint = null;

        public override Binding BindingType
        {
            get
            {
                if (_binding == null)
                {
                    _binding = new BasicHttpBinding();
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
                    _endpoint = new EndpointAddress(ConfigurationManager.AppSettings["basicHttpBindingEndpoint"]);
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
