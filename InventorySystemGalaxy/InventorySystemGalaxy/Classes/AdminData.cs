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
        public string id { get; set; }
        [FirestoreProperty]
        public string user { get; set; }
        [FirestoreProperty]
        public string pass { get; set; }
    }
}
