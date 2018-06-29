using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Metier.Entities
{
    [Serializable()]
    public class Client : ISerializable
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public bool Actif { get; set; }

        public Client() { }
        public Client(string nom, string prenom, bool actif)
        {
            Nom = nom;
            Prenom = prenom;
            Actif = actif;
        }

        //Désarialisation
        public Client(SerializationInfo info, StreamingContext context)
        {
            Id = (int)info.GetValue("Id", typeof(int));
            Nom = (string)info.GetValue("Nom", typeof(string));
            Prenom = (string)info.GetValue("Prenom", typeof(string));
            Actif = (bool)info.GetValue("Actif", typeof(bool));
        }

        //Serialisation
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Id", Id);
            info.AddValue("Nom", Nom);
            info.AddValue("Prenom", Prenom);
            info.AddValue("Actif", Actif);
        }
    }
}