using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Metier.Entities
{
    [Serializable()]
    public class Statut : ISerializable
    {
        public int Id { get; set; }
        public string Libelle { get; set; }

        public Statut() { }
        public Statut(String libelle)
        {
            Libelle = libelle;
        }

        //Désarialisation
        public Statut(SerializationInfo info, StreamingContext context)
        {
            Id = (int)info.GetValue("Id", typeof(int));
            Libelle = (string)info.GetValue("Libelle", typeof(string));
        }

        //Serialisation
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Id", Id);
            info.AddValue("Libelle", Libelle);
        }
    }
}
