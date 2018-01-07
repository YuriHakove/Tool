using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Net;
using System.IO;
using System.Xml.Linq;

namespace Scripts

{
    public class LinqToXml
    {
        public static String Path
        {
            get
            {
                String path = String.Format(System.Windows.Forms.Application.StartupPath+"\\test.xml", Environment.CurrentDirectory);
                return path;
            }
            set
            {

            }
        }

        public static void CreateElement()
        {
            XDocument xdoc = new XDocument(
            new XDeclaration("1.0", "utf-8", "yes"),
             new XComment("提示"),  //注释
            new XElement("root",
            new XElement("item", "1"),
            new XElement("item", "2")
            ));
            xdoc.Save(Path);
        }

        /// <summary>
        ///  根据对象创建Xml并保存
        /// </summary>
        /// <param name="RootName">根节点名</param>
        /// <param name="item1Name">节点名1</param>
        /// <param name="item1s">节点1内容</param>
        /// <param name="item2Name">节点名2</param>
        /// <param name="item2s">节点2内容</param>
        public static void CreateElementByObjects(string RootName,string item1Name,string[] item1s, string item2Name, string[] item2s)
        {
            XElement xele = new XElement(
                  RootName,
                  from item in item1s
                  select new XElement(item1Name, item)
                  ,
                  from item in item2s
                  select new XElement(item2Name, item)
                  );
            xele.Save(Path);
        }
        /// <summary>
        /// 创建属性并保存
        /// </summary>
        /// <param name="RootName">根节点名</param>
        /// <param name="itemName">节点名</param>
        /// <param name="itemContents">属性内容</param>
        public static void CreteAttribute(string RootName, string itemName,  XAttribute[] itemContents)
        {
       
            XElement xele = new XElement(
                RootName,
                new XElement(itemName,
                     from item in itemContents
                     select new XAttribute(item)
                    ));
            xele.Save(Path);
        }

        /// <summary>
     /// 在指定节点前、后添加新节点
     /// </summary>
     /// <param name="nodeName">指定节点名</param>
     /// <param name="nodeContent">指定节点值</param>
     /// <param name="newNode">新节点</param>
     /// <param name="isAfter">前或者后</param>
        public static void AddToElementAfterAndBefore(string nodeName,string nodeContent,XElement newNode,bool isAfter)
        {
            XElement xele = XElement.Load(Path);
            var item = (from ele in xele.Elements(nodeName)
                        where ele.Value.Equals(nodeContent)
                        select ele).SingleOrDefault();
            if (item != null)
            {
                if (isAfter)
                {
                    item.AddAfterSelf(newNode);
                }
                else
                {
                    item.AddBeforeSelf(newNode);
                }
                xele.Save(Path);
            }
        }
        /// <summary>
        /// 添加属性到节点中
        /// </summary>
        public static void AddAttributeToEle()
        {
            XElement xele = XElement.Parse(@"<?xml version='1.0' encoding='utf-8'?><Root><!--前面的注释-->
<Item v1='1' v2='2'>Item1</Item><!--后面的注释--><Item v1='1' v2='2' v3='3'>Item2</Item></Root>");
            var item = (from ele in xele.Elements("Item")
                        where ele.Value.Equals("Item2")
                        select ele).SingleOrDefault();
            item.SetAttributeValue("v3", "3");
            xele.Save(Path);
        }
        /// <summary>
        /// 添加注释到节点前后
        /// </summary>
        public static void AddCommentToAfterAndBefore()
        {
            TextReader tr = new StringReader(@"<?xml version='1.0' encoding='utf-8'?><Root><!--前面的注释-->
<Item v1='1' v2='2'>Item1</Item><!--后面的注释--><Item v1='1' v2='2' v3='3'>Item2</Item></Root>");
            XElement xele = XElement.Load(tr);
            var item = (from ele in xele.Elements("Item")
                        where ele.Value.Equals("Item1")
                        select ele).FirstOrDefault();
            if (item != null)
            {
                XComment xcom = new XComment("后面的注释");
                XComment xcoma = new XComment("前面的注释");
                item.AddAfterSelf(xcom);
                item.AddBeforeSelf(xcoma);
            }
            tr.Close();
            xele.Save(Path);
        }

        /// <summary>
        /// 替换指定节点
        /// </summary>
        /// <param name="nodeName"></param>
        /// <param name="nodeContent"></param>
        /// <param name="newItem"></param>
        public static void ReplaceElement(string nodeName, string nodeContent, XElement newItem)
        {
            XElement xele = XElement.Load(Path);
            var item = (from ele in xele.Elements(nodeName)
                        where ele.Value.Equals(nodeContent)
                        select ele).FirstOrDefault();
            if (item != null)
            {
                item.ReplaceWith(newItem);
            }
            xele.Save(Path);
        }


        /// <summary>
        /// 删除指定属性
        /// </summary>
        public static void RemoveAttribute()
        {
            XElement xele = XElement.Load(Path);
            var item = (from ele in xele.Elements("Item")
                        where ele.Value.Equals("Item1")
                        select ele).FirstOrDefault().Attribute("v1");
            if (item != null)
            {
                item.Remove();
            }
            xele.Save(Path);
        }

        /// <summary>
        /// 删除指定节点
        /// </summary>
        /// <param name="nodeName"></param>
        /// <param name="nodeContent"></param>
        public static void RemoveElement(string nodeName, string nodeContent)
        {
            XElement xele = XElement.Load(Path);
            var item = (from ele in xele.Elements(nodeName)
                        where ele.Value.Equals(nodeContent)
                        select ele).FirstOrDefault();
            if (item != null)
            {
                item.Remove();
            }
            xele.Save(Path);
        }

        /// <summary>
        /// 显示指定节点的所有父节点
        /// </summary>
        public static void ShowAllParentEle()
        {
            XElement xele = XElement.Load(Path);
            var item = (from ele in xele.Descendants("Child")
                        select ele).FirstOrDefault();
            if (item != null)
            {
                foreach (var sub in item.Ancestors()) //获取所有的父级节点
                {
                    Console.WriteLine(sub.Name);
                }
                Console.WriteLine("----------------");
                foreach (var sub in item.AncestorsAndSelf())
                {
                    Console.WriteLine(sub.Name);
                }
                Console.ReadKey();
            }
        }

        /// <summary>
        /// 显示指定节点的所有子节点
        /// </summary>
        public static void ShowAllChildEle()
        {
            XElement xele = XElement.Load(Path);
            foreach (var sub in xele.Descendants())
            {
                Console.WriteLine(sub.Name);               //获取最底的节点
            }
           
            foreach (var sub in xele.DescendantsAndSelf()) //包含本身节点
            {
                Console.WriteLine(sub.Name);
            }
            Console.ReadKey();
        }

        /// <summary>
        /// 显示同级节点之前的节点
        /// </summary>
        public static void ShowPrevEle()
        {
            XElement xele = XElement.Load(Path);
            var item = (from ele in xele.Descendants("SubItem")
                        select ele).FirstOrDefault();
            if (item != null)
            {
                foreach (var sub in item.ElementsBeforeSelf())
                {
                    Console.WriteLine(sub.Name);
                }
            }
            Console.ReadKey();
        }

        /// <summary>
        /// 显示同级节点后面的节点
        /// </summary>
        public static void ShowNextEle()
        {
            XElement xele = XElement.Load(Path);
            var item = (from ele in xele.Descendants("SubItem")
                        select ele).FirstOrDefault();
            if (item != null)
            {
                foreach (var sub in item.ElementsAfterSelf())
                {
                    Console.WriteLine(sub.Name);
                }
            }
            Console.ReadKey();
        }
        /// <summary>
        /// xml监听
        /// </summary>
        public static class EventXml
        {
            public static void BindChangeing()
            {
                XElement xele = new XElement("Root");
                xele.Changing += xele_Changing;
                xele.Changed += xele_Changed;
                xele.Add(new XElement("Item", "123"));
                var item = xele.Element("Item");
                item.ReplaceWith(new XElement("Item", "2"));
                item = xele.Element("Item");
                item.Remove();
                Console.ReadKey();
            }

            static void xele_Changed(object sender, XObjectChangeEventArgs e)
            {
                XElement ele = sender as XElement;
                Console.WriteLine(String.Format("已完成 {0}-{1}", ele.Name, e.ObjectChange));
            }

            static void xele_Changing(object sender, XObjectChangeEventArgs e)
            {
                XElement ele = sender as XElement;
                Console.WriteLine(String.Format("正在进行中 {0}-{1}", ele.Name, e.ObjectChange));
            }
        }

        public static class ReadXmlStream
        {
            public static String Path
            {
                get
                {
                    String path = String.Format("{0}\\test3.xml", Environment.CurrentDirectory);
                    return path;
                }
            }

            /// <summary>
            /// 流式处理XML
            /// </summary>
            //public static void ReadXml()
            //{
            //    XmlReader reader = XmlReader.Create(Path);
            //    while (reader.Read())
            //    {
            //        if (reader.NodeType == XmlNodeType.Element && reader.Name.Equals("Item"))
            //        {
            //            XElement ele = XElement.ReadFrom(reader) as XElement;
            //            Console.WriteLine(ele.Value.Trim());
            //        }
            //    }
            //    Console.ReadKey();
            //}
        }
    }
}