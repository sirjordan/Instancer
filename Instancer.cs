using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Extentions;

namespace Instancer
{
    public class Instancer<T> where T : class, new()
    {
        private T _object;

        public T Object { get { return this._object; } }

        public Instancer()
        {
            this._object = new T();

            var props = _object.GetType().GetProperties();
            foreach (var prop in props)
            {
                if (prop.PropertyType.GetInterfaces().OfType<IConvertible>().Count() > 0)
                {
                    SetPrimitive(prop);
                }
            }
        }

        private void SetPrimitive(PropertyInfo prop)
        {
            switch (prop.PropertyType.Name)
            {
                case "Boolean":
                    {
                        Boolean value = default(Boolean).Random();
                        prop.SetValue(_object, value, null);
                        break;
                    }
                case "Char":
                    {
                        Char value = default(Char).Random();
                        prop.SetValue(_object, value, null);
                        break;
                    }
                case "SByte":
                    {
                        SByte value = default(SByte).Random();
                        prop.SetValue(_object, value, null);
                        break;
                    }
                case "Byte":
                    {
                        Byte value = default(Byte).Random();
                        prop.SetValue(_object, value, null);
                        break;
                    }
                case "Int16":
                    {
                        Int16 value = default(Int16).Random();
                        prop.SetValue(_object, value, null);
                        break;
                    }
                case "UInt16":
                    {
                        UInt16 value = default(UInt16).Random();
                        prop.SetValue(_object, value, null);
                        break;
                    }
                case "Int32":
                    {
                        Int32 value = default(Int32).Random();
                        prop.SetValue(_object, value, null);
                        break;
                    }
                case "UInt32":
                    {
                        UInt32 value = default(UInt32).Random();
                        prop.SetValue(_object, value, null);
                        break;
                    }
                case "Int64":
                    {
                        Int64 value = default(Int64).Random();
                        prop.SetValue(_object, value, null);
                        break;
                    }
                case "UInt64":
                    {
                        UInt64 value = default(UInt64).Random();
                        prop.SetValue(_object, value, null);
                        break;
                    }
                case "Single":
                    {
                        Single value = default(Single).Random();
                        prop.SetValue(_object, value, null);
                        break;
                    }
                case "Double":
                    {
                        Double value = default(Double).Random();
                        prop.SetValue(_object, value, null);
                        break;
                    }
                case "Decimal":
                    {
                        Decimal value = default(Decimal).Random();
                        prop.SetValue(_object, value, null);
                        break;
                    }
                case "DateTime":
                    {
                        DateTime value = default(DateTime).Random();
                        prop.SetValue(_object, value, null);
                        break;
                    }
                case "String":
                    {
                        String value = string.Empty.Random();
                        prop.SetValue(_object, value, null);
                        break;
                    }
                default:
                    break;
            }
        }
    }
}
