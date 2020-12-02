using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    [ServiceContract]
    public interface IClass
    {

        [OperationContract]
        [FaultContract(typeof(FaultException))]
        double first(Person person);

        [OperationContract]
        [FaultContract(typeof(FaultException))]
        double second(Person person, string str, int time);

        [OperationContract]
        [FaultContract(typeof(DivideByZeroException))]
        double third(Person person, string str, int time);

        [OperationContract]
        [FaultContract(typeof(FaultException))]
        Person GetPerson(int ID);

        [OperationContract]
        [FaultContract(typeof(FaultException))]
        void sellInBd(int ID, double one, double two, int three);

    }
}
