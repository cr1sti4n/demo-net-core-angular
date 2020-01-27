using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfServiceDemo.Models;

namespace WcfServiceDemo
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServiceOpinion" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServiceOpinion.svc o ServiceOpinion.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServiceOpinion : IServiceOpinion
    {
        public Opinion getbyId(int Id)
        {
            return new Opinion();
        }

        public List<Opinion> list()
        {
            return new List<Opinion>();
        }
    }
}
