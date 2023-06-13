using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystemGalaxy.Classes
{
    [FirestoreData]
    internal class AdminData
    {
        [FirestoreProperty]
        public int id { get; set; }
        [FirestoreProperty]
        public string username { get; set; }
        [FirestoreProperty]
        public string password { get; set; }
    }
}
