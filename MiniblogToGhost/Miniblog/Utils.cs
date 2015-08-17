using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MiniblogToGhost.Miniblog
{
    public static class Utils
    {
        public static post ExtractPostFromFile(string filename)
        {
            var serialiser = new XmlSerializer(typeof(post));
            post post;

            StreamReader reader = new StreamReader(filename);
            post = (post)serialiser.Deserialize(reader);
            reader.Close();

            return post;
        }
    }
}
