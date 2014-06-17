using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinique.Model;
using System.Data;

namespace Clinique.Store
{
    public static class ClientStore
    {
        #region attributes
        static private List<Client> _clients = null;
        #endregion
        #region properties
        static public List<Client> Clients
        {
            get
            {
                _loadClients();
                return _clients;
            }
            set { _clients = value; }
        }
        #endregion
        #region methods
        private static void _loadClients()
        {
            _clients = new List<Client>();
            string sql = "select * from Clients";
            IDbConnection cn = Database.Instance.getConnection();
            IDbCommand cmd = cn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            try
            {
                cn.Open();
                IDataReader reader = cmd.ExecuteReader();
                object adr1, adr2, cp, ville, ass, email, rem, tel;
                while (reader.Read())
                {
                    adr1 = Database.read(reader, "Adresse1");
                    adr2 = Database.read(reader, "Adresse2");
                    cp = Database.read(reader, "CodePostal");
                    ville = Database.read(reader, "Ville");
                    tel = Database.read(reader, "NumTel");
                    ass = Database.read(reader, "Assurance");
                    email = Database.read(reader, "Email");
                    rem = Database.read(reader, "Remarque");
                    _clients.Add(new Client(
                        Database.read<Guid>(reader, "CodeClient"),
                        Database.read<string>(reader, "NomClient"),
                        Database.read<string>(reader, "PrenomClient"),
                        adr1 == null ? null : (String)adr1,
                        adr2 == null ? null : (String)adr2,
                        cp == null ? null : (String)cp,
                        ville == null ? null : (String)ville,
                        tel == null ? null : (String)tel,
                        ass == null ? null : (String)ass,
                        email == null ? null : (String)email,
                        rem == null ? null : (String)rem,
                        Database.read<bool>(reader, "Archive")
                    ));
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                Database.close(cn);
            }
        }
        /// <summary>
        /// Ajouter un client dans le store et persiste dans la base
        /// </summary>
        /// <param name="nomClient"></param>
        /// <param name="prenomClient"></param>
        /// <param name="adresse1"></param>
        /// <param name="adresse2"></param>
        /// <param name="codePostal"></param>
        /// <param name="ville"></param>
        /// <param name="numTel"></param>
        /// <param name="assurance"></param>
        /// <param name="email"></param>
        /// <param name="remarque"></param>
        /// <param name="archive"></param>
        /// <returns>Null si l'insertion n'a pas ete effectuee</returns>
        /// <exception cref="Exception:  erreur sur insertion en DB"></exception>
        public static Client Ajouter ( string nomClient, string prenomClient, string adresse1, string adresse2, string codePostal,
            string ville, string numTel, string assurance, string email, string remarque, Boolean archive)
        {
            Client client = new Client(Guid.NewGuid(), nomClient, prenomClient, adresse1, adresse2, codePostal,
             ville, numTel, assurance, email, remarque, archive);
            try
            {
                if (Database.Instance.insert(client))
                {
                    _clients.Add(client);
                    return client;
                }
            }
            catch (Exception e)
            {
                throw new Exception("Erreur sur modification et persistance du client en base de données", e);
            }
            return null;
        }
        /// <summary>
        /// Modifie un client dans le store et persiste dans la base
        /// </summary>
        /// <param name="client"></param>
        /// <param name="nomClient"></param>
        /// <param name="prenomClient"></param>
        /// <param name="adresse1"></param>
        /// <param name="adresse2"></param>
        /// <param name="codePostal"></param>
        /// <param name="ville"></param>
        /// <param name="numTel"></param>
        /// <param name="assurance"></param>
        /// <param name="email"></param>
        /// <param name="remarque"></param>
        /// <param name="archive"></param>
        /// <exception cref="Exception:  erreur sur insertion en DB"></exception>
        public static void Modifier(Client client, string nomClient, string prenomClient, string adresse1, string adresse2, string codePostal,
            string ville, string numTel, string assurance, string email, string remarque, Boolean archive)
        {
            client.NomClient = nomClient;
            client.PrenomClient = prenomClient;
            client.Adresse1 = adresse1;
            client.Adresse2 = adresse2;
            client.Archive = archive;
            client.Assurance = assurance;
            client.CodePostal = codePostal;
            client.Email = email;
            client.NumTel = numTel;
            client.Remarque = remarque;
            client.Ville = ville;
            try
            {
                Database.Instance.update(client);
            }
            catch (Exception e)
            {
                throw new Exception("Erreur sur modification et persistance du client en base de données",e);
            }
            
        }
        /// <summary>
        /// archive le client
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        public static bool Supprimer(Client client)
        {
            //@todo get facture.
            //@todo archiver animaux du client
            client.Archive = true;
            Database.Instance.update(client);
            return true;
        }

        public static Client RecupererClient(Guid codeClient)
        {
            if (null == _clients) _loadClients();
            return _clients.Find((Client c) =>
            {
                return c.CodeClient == codeClient;
            });
        }
             

        #endregion
    }
}
