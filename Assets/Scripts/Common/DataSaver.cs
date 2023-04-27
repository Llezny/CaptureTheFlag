using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using File = UnityEngine.Windows.File;

namespace Common {
    public class DataSaver {
        public static void SaveData<T>( T data, string fileName ) where T : class {
            var path = $"{Application.persistentDataPath}/{fileName}";
            var formatter = new BinaryFormatter( );
            var stream = new FileStream( path, FileMode.Create );
            formatter.Serialize( stream, data );
            stream.Close(  );
        }
        
        public static T LoadData<T>( string fileName ) where T : class, new() {
            var path = $"{Application.persistentDataPath}/{fileName}";
            var formatter = new BinaryFormatter( );
            var stream = new FileStream( path, FileMode.OpenOrCreate );
            if ( stream.Length == 0 ) {
                return new T( );
            }
            var data = formatter.Deserialize( stream ) as T;
            stream.Close( );
            return data;
        }
    }
}