using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace DictationProcessor
{
    class Program
    {
        static void Main(string[] args)
        {
            // iterate through subfolders of /mnt/uploads
            foreach (var subfolder in Directory.GetDirectories("/Users/fannonp/Documents/dotnet-core-mac-linux-getting-started/m3/demos/uploads")) 
            {

                
                // get metadata file
                var metadataFilePath = Path.Combine(subfolder, "metadata.json");
                Console.WriteLine($"Reading {metadataFilePath}");
                // extract metadata, including audio file info, from metadata file
                var metadataCollection = GetMetadata(metadataFilePath);

                // for each audio file listed in metadata:
                // - get absolute file path
                // - verify file checksum
                // - generate a unique identifier
                // - compress it
                // - create a standalone metadata file 
            }
        }

        static List<Metadata> GetMetadata(string metadataFilePath)
        {
            var metadataFileStream = File.Open(metadataFilePath, FileMode.Open);
                var settings = new DataContractJsonSerializerSettings
                {
                    DateTimeFormat = new DateTimeFormat("yyyy-MM-dd'T'HH:mm:ssZ")
                };
                var serializer = new DataContractJsonSerializer(typeof(List<Metadata>), settings);
                return (List<Metadata>)serializer.ReadObject(metadataFileStream);
        }
    }
}
