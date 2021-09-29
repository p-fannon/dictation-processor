using System;
using System.IO;

namespace DictationProcessor
{
    class Program
    {
        static void Main(string[] args)
        {
            // iterate through subfolders of /mnt/uploads
            foreach (var subfolder in Directory.GetDirectories("/mnt/uploads")) 
            {

                
                // get metadata file
                var metadataFilePath = Path.Combine(subfolder, "metadata.json");
                Console.WriteLine($"Reading {metadataFilePath}");
                // extract metadata, including audio file info, from metadata file
                var metadataFileStream = File.Open(metadataFilePath, FileMode.Open);

                // for each audio file listed in metadata:
                // - get absolute file path
                // - verify file checksum
                // - generate a unique identifier
                // - compress it
                // - create a standalone metadata file 
            }
        }
    }
}
