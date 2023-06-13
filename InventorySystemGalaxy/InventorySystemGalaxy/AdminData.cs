using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystemGalaxy
{
    [FirestoreData]
    internal class AdminData
    {
        [FirestoreProperty]
        public int Id { get; set; }
        [FirestoreProperty]
        public string Username { get; set; }
        [FirestoreProperty]
        public string Password { get; set; }
    }
}
