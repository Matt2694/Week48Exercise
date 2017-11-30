using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Single)]
    public class Service : IService
    {
        public List<string> ProductValue = new List<string>();

        public List<string> GetData()
        {
            return ProductValue;
        }

        public void AddData(string value)
        {
            ProductValue.Add(value);
        }
    }
}
