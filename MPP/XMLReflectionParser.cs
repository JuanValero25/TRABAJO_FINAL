using BE;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MPP
{
    public class XMLReflectionParser<T>
    {
        protected string typeName { get; set; }
        protected string fileName { get; set; }
        protected string Root { get; set; }

        protected string Unit { get; set; }

        public XMLReflectionParser()
        {
            T instance = Activator.CreateInstance<T>();
            typeName = instance.GetType().Name;
            fileName = "./xmlDB/" + typeName + ".xml";
            Root = typeName + "s";
            Unit = typeName + "_unit";

            if (!Directory.Exists("./xmlDB/"))
            {

                Directory.CreateDirectory("./xmlDB/");
            }

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

                    var singleField = objectToXElement(field.Name, value);
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

        private XElement objectToXElement(string fieldName, object value)
        {

            if (value == null)
            {
                return new XElement(fieldName, "");
            }


            var reflectedProerty = value.GetType();

            switch (reflectedProerty.Name)
            {
                case "List`1":

                    var ListValue = (IEnumerable)value;
                    var listaDelElementos = new List<XElement>();

                    foreach (var val in ListValue)
                    {
                        listaDelElementos.Add(new XElement("ID", val));
                    }

                    return new XElement(fieldName, listaDelElementos.ToArray()); ;
                default:
                    return new XElement(fieldName, value);


            }
        }

        public void Delete(IEntidad ObjectToParse)
        {

            XDocument xmlDoc = XDocument.Load(fileName);
            var element = xmlDoc.Element(typeName + "s").Descendants(typeName + "_unit").Where(x => x.Element("ID").Value.Equals(ObjectToParse.ID));

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

            IEnumerable<XElement> consulta = null;
            try
            {
                consulta = from usuario in XElement.Load(fileName).Descendants(Unit)
                           where usuario.Element("ID").Value.Equals(ID)
                           select usuario;
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("no existe ningun objecto o no existe el archivo : " + fileName);
                return Activator.CreateInstance<T>();
            }



            var listValue = consulta.Elements();
            T instance = Activator.CreateInstance<T>();


            if (listValue.Count() == 0)
            {
                return instance;
            }

            foreach (PropertyInfo field in instance.GetType().GetProperties())
            {
                var xmlElement = listValue.Where(p => p.Name.LocalName.Equals(field.Name)).First();
                setValue(instance, field.Name, xmlElement);

            }

            return instance;


        }

        private void setValue(T instance, string fieldName, XElement value)
        {
            var reflectedProerty = instance.GetType().GetProperty(fieldName);

            switch (reflectedProerty.PropertyType.Name)
            {

                case "String":
                    reflectedProerty.SetValue(instance, value.Value);
                    break;
                case "Int32":
                    int result = Int32.Parse(value.Value);
                    reflectedProerty.SetValue(instance, result);
                    break;
                case "Decimal":
                    var innerDecimal = Convert.ToDecimal(value.Value);
                    reflectedProerty.SetValue(instance, innerDecimal);
                    break;
                case "DateTime":
                    var innerDate = Convert.ToDateTime(value.Value, CultureInfo.GetCultureInfo("es-ES"));
                    reflectedProerty.SetValue(instance, innerDate);
                    break;
                case "List`1":
                    var property = instance.GetType().GetProperty(fieldName);
                    var ListValue = (IList)Activator.CreateInstance(property.PropertyType);


                    foreach (var elements in value.Elements())
                    {
                        ListValue.Add(elements.Value);
                    }

                    property.SetValue(instance, ListValue);
                    break;

            }

        }


        public List<T> GetAll()
        {
            IEnumerable<XElement> consulta = null;
            try
            {
                consulta = from usuario in XElement.Load(fileName).Descendants(Unit)
                           select usuario;
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("no existe ningun objecto o no existe el archivo : " + fileName);
                return Activator.CreateInstance<List<T>>();
            }


            var listValue = consulta.Elements();

            var ListValue = Activator.CreateInstance<List<T>>();


            foreach (XElement OneElement in consulta.ToArray())
            {
                T instance = Activator.CreateInstance<T>();
                foreach (XElement oneProperty in OneElement.Elements())
                {
                    setValue(instance, oneProperty.Name.LocalName, oneProperty);
                }
                ListValue.Add(instance);
            }

            return ListValue;


        }

        public void SetListValue(T t, string propertyName, XElement listElement)
        {
            var property = t.GetType().GetProperty(propertyName);
            var ListValue = (IList)Activator.CreateInstance(property.PropertyType);


            foreach (var elements in listElement.Elements())
            {
                ListValue.Add(elements.Value);
            }

            property.SetValue(t, ListValue);


        }



    }
}
