using Abstraction;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml.Linq;

namespace MPP
{
    public class XMLReflectionParser<T>
    {
        private string typeName { get; set; }
        private string fileName { get; set; }
        private string Root { get; set; }

        private string Unit { get; set; }

        public XMLReflectionParser()
        {
            T instance = Activator.CreateInstance<T>();
            typeName = instance.GetType().Name;
            fileName = typeName + ".xml";
            Root = typeName + "s";
            Unit = typeName + "_unit";
        }

        public void Save(IEntidad ObjectToParse)
        {
            try
            {
                if (!File.Exists(fileName))
                {

                    var xdoc = new XDocument();
                    var rootElement = new XElement(typeName + "s");
                    xdoc.Add(rootElement);
                    xdoc.Save(fileName);

                }

                var FieldSValue = new List<XElement>();

                var tyyype = ObjectToParse.GetType().GetProperties();

                foreach (PropertyInfo field in ObjectToParse.GetType().GetProperties())
                {
                    var value = ObjectToParse.GetType().GetProperty(field.Name).GetValue(ObjectToParse, null);

                    var singleField = new XElement(field.Name, value);
                    FieldSValue.Add(singleField);

                }
                XDocument xmlDoc = XDocument.Load(fileName);

                var element = xmlDoc.Element(Root);

                element.Add(new XElement(Unit, FieldSValue.ToArray()));


                xmlDoc.Save(fileName);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void Delete(IEntidad ObjectToParse)
        {



            XDocument xmlDoc = XDocument.Load(fileName);
            var element = xmlDoc.Element(typeName + "s").Descendants(typeName + "_unit").Where(x => x.Element("Codigo").Value.Equals(ObjectToParse.ID));

            element.Remove();
            xmlDoc.Save(fileName);
            return;
        }

        public void GenericModify(IEntidad ObjectToParse)
        {
            Delete(ObjectToParse);
            Save(ObjectToParse);
        }


        public T Get(string ID)
        {


            var consulta = from usuario in XElement.Load(fileName).Descendants(Unit)
                           where usuario.Element("ID").Value.Equals(ID)
                           select usuario;

            var listValue = consulta.Elements();
            T instance = Activator.CreateInstance<T>();
            var nombre = listValue.Where(p => p.Name.LocalName.Equals("Nombre"));

            foreach (PropertyInfo field in instance.GetType().GetProperties())
            {
                var xmlElement = listValue.Where(p => p.Name.LocalName.Equals(field.Name)).First();
                setValue(instance, field.Name, xmlElement.Value);

            }

            return instance;


        }

        private void setValue(T instance, string fieldName, string value)
        {
            var reflectedProerty = instance.GetType().GetProperty(fieldName);

            switch (reflectedProerty.PropertyType.Name)
            {

                case "String":
                    reflectedProerty.SetValue(instance, value);
                    break;
                case "Decimal":
                    var innerDecimal = Convert.ToDecimal(value);
                    reflectedProerty.SetValue(instance, innerDecimal);
                    break;
                case "DateTime":
                    var innerDate = Convert.ToDateTime(value, CultureInfo.GetCultureInfo("es-ES"));
                    reflectedProerty.SetValue(instance, innerDate);
                    break;

            }

        }


        public List<T> GetAll()
        {
            var consulta = from usuario in XElement.Load(fileName).Descendants(Unit)
                           select usuario;

            var listValue = consulta.Elements();

            var ListValue = Activator.CreateInstance<List<T>>();


            foreach (XElement OneElement in consulta.ToArray())
            {
                T instance = Activator.CreateInstance<T>();
                foreach (XElement oneProperty in OneElement.Elements())
                {
                    setValue(instance, oneProperty.Name.LocalName, oneProperty.Value);
                }
                ListValue.Add(instance);
            }

            return ListValue;


        }



    }
}
