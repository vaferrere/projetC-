using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Metier.Entities
{
    [Serializable()]
    public class Commande : ISerializable
    {
        public int Id { get; set; }
        public DateTime DateCommande { get; set; }
        public string Observation { get; set; }
        public int StatusId { get; set; }
        public Statut Status { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }

        public Commande() { }
        public Commande(DateTime dateCommande, string observation, Statut status, Client client)
        {
            DateCommande = dateCommande;
            Observation = observation;
            Status = status;
            Client = client;
        }

        //Désarialisation
        public Commande(SerializationInfo info, StreamingContext context)
        {
            Id = (int)info.GetValue("Id", typeof(int));
            DateCommande = (DateTime)info.GetValue("DateCommande", typeof(DateTime));
            Observation = (string)info.GetValue("Observation", typeof(string));
            StatusId = (int)info.GetValue("StatusId", typeof(int));
            Status = (Statut)info.GetValue("Status", typeof(Statut));
            ClientId = (int)info.GetValue("ClientId", typeof(int));
            Client = (Client)info.GetValue("Client", typeof(Client));

        }

        //Serialisation
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Id", Id);
            info.AddValue("DateCommande", DateCommande);
            info.AddValue("Observation", Observation);
            info.AddValue("StatusId", StatusId);
            info.AddValue("Status", Status);
            info.AddValue("ClientId", ClientId);
            info.AddValue("Client", Client);

        }
    }
}
