using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClient
{
    public abstract class ClientBindings
    {
        public virtual Binding BindingType { get; set; }
        public virtual EndpointAddress EndPoint { get; set; }
    }
    public class BasicHttpBindingClient:ClientBindings
    {
        private Binding _binding = null;
        private EndpointAddress _endpoint = null;

        public override Binding BindingType
        {
            get
            {
                if(_binding==null)
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
                if(_endpoint==null)
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
    public class WSHttpBindingClient:ClientBindings
    {
        private Binding _binding = null;
        private EndpointAddress _endpoint = null;

        public override Binding BindingType
        {
            get
            {
                if (_binding == null)
                {
                    _binding = new WSHttpBinding();
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
                    _endpoint = new EndpointAddress(ConfigurationManager.AppSettings["wsHttpBindingEndpoint"]);
                }
                return _endpoint;
            }

            set
            {
                _endpoint = value;
            }
        }
    }
    public class NetHttpBindingClient : ClientBindings
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
    public class NetTcpBindingClient : ClientBindings
    {
        private Binding _binding = null;
        private EndpointAddress _endpoint = null;

        public override Binding BindingType
        {
            get
            {
                if (_binding == null)
                {
                    _binding = new NetTcpBinding();
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
                    _endpoint = new EndpointAddress(ConfigurationManager.AppSettings["netTcpBindingEndpoint"]);
                }
                return _endpoint;
            }

            set
            {
                _endpoint = value;
            }
        }
    }
    public static class BindingFactory
    {
        public static ClientBindings GetBindingFactory(BindingTypes bindingType)
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
    public enum BindingTypes
    {
        BasicHttpBinding,
        WSHttpBinding,
        NetHttpBinding,
        NetTcpBinding
    }
}
