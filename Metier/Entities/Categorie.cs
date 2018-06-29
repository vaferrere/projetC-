using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Metier.Entities
{
    [Serializable()]
    public class Categorie : ISerializable
    {
        public int Id { get; set; }
        public string Libelle{ get; set;}
        public bool Actif{ get; set; }

        public Categorie() { }
        public Categorie(string libelle, bool actif)
        {
            Libelle = libelle;
            Actif = actif;
        }

        //Désarialisation
        public Categorie(SerializationInfo info, StreamingContext context)
        {
            Id = (int)info.GetValue("Id", typeof(int));
            Libelle = (string)info.GetValue("Libelle", typeof(string));
            Actif = (bool)info.GetValue("Actif", typeof(bool));
        }

        //Serialisation
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Id", Id);
            info.AddValue("Libelle", Libelle);
            info.AddValue("Actif", Actif);
        }
    }
}
