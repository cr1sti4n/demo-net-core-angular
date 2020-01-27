using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfServiceDemo.Models;

namespace WcfServiceDemo
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServiceOpinion" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServiceOpinion
    {


        [OperationContract]
        List<Opinion> list();


        [OperationContract]
        Opinion getbyId(int Id);



    }

    
    
}
