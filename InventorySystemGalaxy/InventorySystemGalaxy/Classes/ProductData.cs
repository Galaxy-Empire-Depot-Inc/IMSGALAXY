using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystemGalaxy.Classes
{
    [FirestoreData]
    internal class ProductData
    {
        [FirestoreProperty]
        public string Sort { get; set; }
        [FirestoreProperty]
        public string Item_code { get; set; }
        [FirestoreProperty]
        public string Ref_code { get; set; }
        [FirestoreProperty]
        public double Srp { get; set; }
        [FirestoreProperty]
        public string Colour { get; set; }
        [FirestoreProperty]
        public string Description { get; set; }
        [FirestoreProperty]
        public double Dp { get; set; }
        [FirestoreProperty]
        public double Av { get; set; }
        [FirestoreProperty]
        public double Watts { get; set; }
        [FirestoreProperty]
        public string ProductSize { get; set; }
        [FirestoreProperty]
        public string Warehouse { get; set; }
        [FirestoreProperty]
        public string Category { get; set; }
        [FirestoreProperty]
        public double Box { get; set; }
        [FirestoreProperty]
        public double Qty { get; set; }
        [FirestoreProperty]
        public double CtlH { get; set; }
        [FirestoreProperty]
        public double CtlW { get; set; }
        [FirestoreProperty]
        public double CtlL { get; set; }



    }
}
