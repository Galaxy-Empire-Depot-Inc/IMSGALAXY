using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystemGalaxy.Classes
{
    internal static class FireStoreHelper
    {
        static string fireConfig = @"
            {
              ""type"": ""service_account"",
              ""project_id"": ""imsgalaxy-f7419"",
              ""private_key_id"": ""02750ac5ad5d7366a7c23656ea4a24e7e93e0d8c"",
              ""private_key"": ""-----BEGIN PRIVATE KEY-----\nMIIEvAIBADANBgkqhkiG9w0BAQEFAASCBKYwggSiAgEAAoIBAQDCNp2jXjJA6F4l\n/4UkfbwpMsktsaauf2ORcZkGCvfae/h4wAgN+0541UlLFXtlVYqp1/eesaYwI+tB\nc8KvFPe2hxQo2a9megn38YGnJiMYtBa0KpjK9IVVOkJW2EMYA2i8cGVj2vQAJW3a\nJ5LsQLjz/nUwPMOWm5ZfhbsO+GMm5B0YxZ0WLXT+3034/x1tcWngSljjS01mn56T\nUVpLpglie1WTRUj9XP4tm+/kY61r7x3axOuzP3WWdQc7e1DhQFJwnXDVjgUM00x6\nhZQV/04/oIdlmcHVC0nBktdBBm9+Jirapr6hTBvBcHizpDdNDcfYi4PlNlpF1m8U\nXX/6rlsPAgMBAAECggEAJISmgYh9xIys31I7k8/8qHZ/M5Na9ybG7xtAHc3EKxXy\nc6oQGajuaXQZcv/YEwbRqvwL+JAI4rZuTwFYUxmLNowRs1izTX6XD0MfEPHv2X5L\nYpc74bW2uH7a6H+DpilF8WDk/7C0/q4LCOE2FCxbWq23FVnnoRMiZFW+BaOY6T/Z\ncmOLDyYLQ1xVGOb8xDDL/aSi2p5nltF+mH9xgzuFJjql8tKoDEivysekDddqWNUS\n9dqEkbfWm6MfDcqM0Xr470KW2LSlHsCDwFk7PvaQaRScatKQZ7gZrR0DiaSisrky\ndzOnLUdmGHOJCsNoPN6gvJ6bWqzF77ks7zb6JZNVaQKBgQDpsRpefZY4+8lpPozD\nQIAFyR4Td6z+yuE/WrPGvi9XJpBswJ0G3jvsL8EoY3eQvo9suJjAdTxcPMcJ8oG2\ns+7CcLegX/cqcIrCsKDeQ0Ed1Jdbe6SyAQnNk+gazK+ceczllI5nfIL+xzKBhC16\n/JQTZYi3oXBDdA9865B2yEgKCwKBgQDUwL+tTtcgj5xAURQQsZMCm+gkck1jK4+5\nsVqpnxmpXmLbFNTHrg+Y/kLXLZZfhfosQ3Fb3qEkXxt5xAIAzP4/3mtudiPUvnGT\n2J9lMdSIzHyqYMPdJ3Hyu2pdQOtk3WuMRYgeSUYagizRDwFXPgfe4r99e7dJBTDc\nFs/1I2lZjQKBgEbtZNZ3AYgsC3Zw8KI2SmT3JLS95viyNOlYqyXQBWhLIRyQ3Vf/\nTWqjF9odTmXVIIzb/iizrG1GWRbQzsPYGshTE7iOR+NOox7yIvEysmnOY131ygfo\nvsPxd0njBA3W/fRUQWBxbwTLCq46ot8oF/1HHNa3He6rJCRDDuauZQb/AoGAU5N4\neMt85RSlS/rNyBUJ7D90vUSNtAR7zHWoaPPQL+GdMfUH9X0iMXbIqSEGbnYCJftE\nf9OAN/qIn5fpNYlR46MrTtRoFP3PPkYdr7IYjLjPzFqA9tK1B6aqDQIgtpno0szJ\nwSQFvwoeMu4TF8ONcfhfQxsjkDLS09K+VM1ZaE0CgYB6K7zMBhRVHM+2BEhqgeK+\nlQ4b3oMBJl/wL4jHyyr/ToNybwQ2b1Pvlou9wTQkbXaAp3//wpksNTstU6blCciM\n4IZw3B1uuaV6NbXqvQpVtZe72vf1hxmSqfYqtEjEkEI3RKQbh8Rp19hq9mYAhc2A\nEWaZTFlFJvFiRfYUslE/2A==\n-----END PRIVATE KEY-----\n"",
              ""client_email"": ""firebase-adminsdk-eusnr@imsgalaxy-f7419.iam.gserviceaccount.com"",
              ""client_id"": ""102621900944377969697"",
              ""auth_uri"": ""https://accounts.google.com/o/oauth2/auth"",
              ""token_uri"": ""https://oauth2.googleapis.com/token"",
              ""auth_provider_x509_cert_url"": ""https://www.googleapis.com/oauth2/v1/certs"",
              ""client_x509_cert_url"": ""https://www.googleapis.com/robot/v1/metadata/x509/firebase-adminsdk-eusnr%40imsgalaxy-f7419.iam.gserviceaccount.com"",
              ""universe_domain"": ""googleapis.com""
            }";

        static string filepath = "";
        public static FirestoreDb? firestoreDb { get; private set; }

        public static void SetEnvironmentVariable()
        {
            filepath = Path.Combine(Path.GetTempPath(), Path.GetFileNameWithoutExtension(Path.GetRandomFileName()) + ".json");
            File.WriteAllText(filepath, fireConfig);
            File.SetAttributes(filepath, FileAttributes.Hidden);
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", filepath);
            firestoreDb = FirestoreDb.Create("imsgalaxy-f741");
            File.Delete(filepath);
        }
    }
}
