using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;

namespace CodingChallenges
{
    class ReadFromFile
    {
        private static void Main(string[] args)
        {
            FileOperation();
            XMLParser();
        }

        private static void FileOperation()
        {
            string path = @"C:\TauTesting\1428.txt";
            string outputPath = @"C:\TauTesting\";
            if (File.Exists(path))
            {
                StreamReader sr = new StreamReader(path);
                StringBuilder sb = new StringBuilder();
                StreamWriter sw = new StreamWriter(outputPath + "Copy1428.txt");
                string str = sr.ReadLine();

                while (!string.IsNullOrEmpty(str))
                {
                    sb.AppendLine(str);
                    sw.WriteLine(str);
                    str = sr.ReadLine();
                }

                using (StreamWriter streamWriter = new StreamWriter(outputPath + "SecondCopy.txt"))
                {
                    streamWriter.Write(sb);
                }

                sr.Close();
                sw.Close();
            }
        }

        private static void XMLParser()
        {
            String xmlString =
                @"<bookstore>
        <book genre='autobiography' publicationdate='1981-03-22' ISBN='1-861003-11-0'>
            <title>The Autobiography of Benjamin Franklin</title>
            <author>
                <first-name>Benjamin</first-name>
                <last-name>Franklin</last-name>
            </author>
            <price>8.99</price>
        </book>
    </bookstore>";
            string outputPath = @"C:\TauTesting\"; 

            using (XmlReader xmlReader = XmlReader.Create(new StringReader(xmlString)))
            {
                XmlWriterSettings ws = new XmlWriterSettings();
                ws.Indent = true;

                using (XmlWriter xmlWriter = XmlWriter.Create(outputPath + "SecondCopy.xml"))
                {
                    while (xmlReader.Read())
                    {
                        switch (xmlReader.NodeType)
                        {
                            case XmlNodeType.Element:
                                xmlWriter.WriteStartElement(xmlReader.Name);
                                break;
                            case XmlNodeType.Text:
                                xmlWriter.WriteString(xmlReader.Value);
                                break;
                            case XmlNodeType.XmlDeclaration:
                            case XmlNodeType.ProcessingInstruction:
                                xmlWriter.WriteProcessingInstruction(xmlReader.Name, xmlReader.Value);
                                break;
                            case XmlNodeType.Comment:
                                xmlWriter.WriteComment(xmlReader.Value);
                                break;
                            case XmlNodeType.EndElement:
                                xmlWriter.WriteFullEndElement();
                                break;
                            case XmlNodeType.Whitespace:
                                xmlWriter.WriteWhitespace(xmlReader.Value);
                                break;
                            default: xmlWriter.WriteEndElement();
                                break;
                        }   
                    }
                }
            }
        }
    }
}
