using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace ConsoleApplication1
{
  class Program
  {
    static void Main(string[] args)
    {
      var test = new XmlParseTest();
      //test.Test();
      
      test.Test("MapperConfig.xml");
      //test.Test("AuthorMapper.xml");
      Console.Read();
    }

    public class XmlParseTest
    {

      string pointOsmId = "";
      string pointLat = "";
      string pointLon = "";
      string pointVersion = "";
      string pointTimestamp = "";
      string pointChangeset = "";
      string pointUserid = "";
      string pointUsername = "";

      string wayOsmId = "";
      string wayVersion = "";
      string wayTimestamp = "";
      string wayChangeset = "";
      string wayUserid = "";
      string wayUsername = "";

      string reationOsmId = "";
      string reationVersion = "";
      string reationTimestamp = "";
      string reationChangeset = "";
      string reationUserid = "";
      string reationUsername = "";


      public void Test(string uri = "XMLFile1.xml")
      {
        if (!File.Exists(uri)) return;
        XmlReaderSettings settings = new XmlReaderSettings();
        settings.IgnoreComments = true;
        settings.IgnoreWhitespace = true;
        settings.IgnoreProcessingInstructions = true;

        settings.DtdProcessing = DtdProcessing.Ignore;
        settings.CloseInput = true;


        //var uri = "XMLFile1.xml";

        Console.WriteLine("\n\nfile:=" + uri);
        using (XmlReader rd = XmlReader.Create(uri, settings))
        {
          var xs = new XConfiguration(rd);
          Console.WriteLine("settings count=" + xs.Settings.Count);
          //XmlParse(rd);
        }
      }

      public void XmlParse(XmlReader source)
      {
        //source.MoveToContent();
        while (source.Read())
        {
          Console.WriteLine(string.Format("NN={0}, NT={1} NV={2}", source.Name, source.NodeType, source.Value));

          if (source.NodeType == XmlNodeType.Element && source.Name == "node")
          {
            pointOsmId = source.GetAttribute("id");
            pointLat = source.GetAttribute("lat");
            pointLon = source.GetAttribute("lon");
            pointVersion = source.GetAttribute("version");
            pointTimestamp = source.GetAttribute("timestamp");
            pointChangeset = source.GetAttribute("changeset");
            pointUserid = source.GetAttribute("uid");
            pointUsername = source.GetAttribute("user");

            string content = source.ReadInnerXml();
            string tagFormated = string.Format("<tag>{0}</tag>", content);
            XElement element = XElement.Parse(tagFormated);
            int tagCount = element.Elements().Count();
            string tags = "";
            int count = tagCount;
            while (tagCount > 0)
            {
              tags += "key=" + element.Elements().ElementAt(count - tagCount).Attribute("k").Value + ",value=" + element.Elements().ElementAt(count - tagCount).Attribute("v").Value + ";";
              tagCount--;
            }
            Console.WriteLine("Node osmId:" + pointOsmId);
            Console.WriteLine("Node pointLat:" + pointLat);
            Console.WriteLine("Node pointLon:" + pointLon);
            Console.WriteLine("Node pointVersion:" + pointVersion);
            Console.WriteLine("Node pointTimestamp:" + pointTimestamp);
            Console.WriteLine("Node pointChangeset:" + pointChangeset);
            Console.WriteLine("Node pointUserid:" + pointUserid);
            Console.WriteLine("Node pointUsername:" + pointUsername);
            Console.WriteLine("Node tags:" + tags);

          }
          if (source.NodeType == XmlNodeType.Element && source.Name == "way")
          {
            wayOsmId = source.GetAttribute("id");
            wayVersion = source.GetAttribute("version");
            wayTimestamp = source.GetAttribute("timestamp");
            wayChangeset = source.GetAttribute("changeset");
            wayUserid = source.GetAttribute("uid");
            wayUsername = source.GetAttribute("user");

            string content = source.ReadInnerXml();
            string Formated = string.Format("<way>{0}</way>", content);
            XElement element = XElement.Parse(Formated);
            string pointsId = "";
            string tags = "";

            XmlReader r = element.CreateReader();
            while (r.Read())
            {
              if (r.NodeType == XmlNodeType.Element && r.Name == "nd")
              {

                pointsId += r.GetAttribute("ref").ToString() + ",";
              }
              else if (r.NodeType == XmlNodeType.Element && r.Name == "tag")
              {
                tags += "key=" + r.GetAttribute("k").ToString() + ",value=" + r.GetAttribute("v").ToString() + ";";
              }
            }
            Console.WriteLine("Way osmId:" + wayOsmId);
            Console.WriteLine("Way pointVersion:" + wayVersion);
            Console.WriteLine("Way pointTimestamp:" + wayTimestamp);
            Console.WriteLine("Way pointChangeset:" + wayChangeset);
            Console.WriteLine("Way pointUserid:" + wayUserid);
            Console.WriteLine("Way pointUsername:" + wayUsername);
            Console.WriteLine("Way pointsId:" + pointsId);
            Console.WriteLine("Way tags:" + tags);

          }
          if (source.NodeType == XmlNodeType.Element && source.Name == "relation")
          {
            reationOsmId = source.GetAttribute("id");
            reationVersion = source.GetAttribute("version");
            reationTimestamp = source.GetAttribute("timestamp");
            reationChangeset = source.GetAttribute("changeset");
            reationUserid = source.GetAttribute("uid");
            reationUsername = source.GetAttribute("user");

            string content = source.ReadInnerXml();
            string Formated = string.Format("<relation>{0}</relation>", content);
            XElement element = XElement.Parse(Formated);
            string member = "";
            string tags = "";

            XmlReader r = element.CreateReader();
            while (r.Read())
            {
              if (r.NodeType == XmlNodeType.Element && r.Name == "member")
              {
                member = r.GetAttribute("type").ToString() + "," + r.GetAttribute("ref").ToString() + "," + r.GetAttribute("role").ToString() + ";";
              }
              else if (r.NodeType == XmlNodeType.Element && r.Name == "tag")
              {
                tags += "key=" + r.GetAttribute("k").ToString() + ",value=" + r.GetAttribute("v").ToString() + ";";
              }
            }
            Console.WriteLine("relation osmId:" + reationOsmId);
            Console.WriteLine("relation pointVersion:" + reationVersion);
            Console.WriteLine("relation pointTimestamp:" + reationTimestamp);
            Console.WriteLine("relation pointChangeset:" + reationChangeset);
            Console.WriteLine("relation pointUserid:" + reationUserid);
            Console.WriteLine("relation pointUsername:" + reationUsername);
            Console.WriteLine("relation member:" + member);
            Console.WriteLine("relation tags:" + tags);

          }
        }
      }
    }
  }
}
