﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CleanAppFilesGenerator
{
    public class GenerateEntityClass
    {
        public static string GenerateEntity(Type type, string name_space)
        {
            string baseEntity = " : BaseEntity";
            // var entityName = type.Name;
            var Output = new StringBuilder();
            Output.Append(ProduceEntityHeader(name_space, type, baseEntity));
            Output.Append($"{GeneralClass.newlinepad(4)}{{");
            Output.Append(GeneralClass.newlinepad(8) + ProducePrivateContructor(type));
            Output.Append(ProduceEntityProperties(type));
            Output.Append(GeneralClass.newlinepad(8) + ProduceEntityCreateFunction(type));
            Output.Append(GeneralClass.newlinepad(4) + GeneralClass.ProduceClosingBrace());
            Output.Append(GeneralClass.newlinepad(0) + GeneralClass.ProduceClosingBrace());
            return Output.ToString();
        }

        public static string ProduceEntityHeader(string name_space, Type type, string baseEntity = " : BaseEntity")
        {
            return ($"using {name_space}.DomainBase;\nnamespace {name_space}.Domain.Entities\n{{{GeneralClass.newlinepad(4)}public partial class {type.Name} {baseEntity}");
        }
        public static string ProducePrivateContructor(Type type)
        {
            return ($"private {type.Name}(){{}}");

        }




        public static string ProduceEntityCreateFunction(Type type)
        {

            StringBuilder sb = new StringBuilder();
            StringBuilder sb2 = new StringBuilder();
            sb.Append(GeneralClass.newlinepad(8) + $"public static {type.Name} Create(");

            PropertyInfo[] properties = type.GetProperties();
            foreach (PropertyInfo prop in properties)
            {
                var x = Nullable.GetUnderlyingType(prop.PropertyType);
                var propertytype = x == null ? prop.PropertyType.Name : x.Name;

                if (propertytype.Contains("ICollection`1") || (propertytype.Contains("IList`1")))
                {
                    var _ = prop.PropertyType.GenericTypeArguments[0];
                }
                else

                if (!prop.PropertyType.BaseType.Name.Contains("BaseEntity"))
                {



                    sb.Append(GeneralClass.PrepareParameter(prop));
                    sb2.Append($"{GeneralClass.newlinepad(12)}{GeneralClass.PrepareAssignment(prop.Name)} ,");
                    sb.Append(", ");

                }
                else
                {          // These are member that are inherited from the base entity
                }

            }
            sb.Remove(sb.Length - 2, 2);
            sb.Append(")");
            sb.Append($"{GeneralClass.newlinepad(4)}{{");

            sb.Append($"{GeneralClass.newlinepad(4)}if (guidId == Guid.Empty)");
            sb.Append($"{GeneralClass.newlinepad(4)}{{");
            sb.Append($"{GeneralClass.newlinepad(8)}throw new ArgumentException($\"{type.Name} Guid value cannot be empty {{nameof(guidId)}}\");");
            sb.Append($"{GeneralClass.newlinepad(4)}}}");

            sb.Append($"{GeneralClass.newlinepad(8)}return  new(){GeneralClass.newlinepad(8)}{{");
            sb.Append(sb2.ToString());
            sb.Append($"{GeneralClass.newlinepad(8)}}};");
            sb.Append($"{GeneralClass.newlinepad(4)}}}");
            return sb.ToString();
        }
        public static string ProduceEntityProperties(Type type)
        {

            StringBuilder sb = new StringBuilder();
            PropertyInfo[] properties = type.GetProperties();
            foreach (PropertyInfo prop in properties)
            {

                var isnullAbleResult = Nullable.GetUnderlyingType(prop.PropertyType);

                var propertytype = isnullAbleResult == null ? prop.PropertyType.Name : isnullAbleResult.Name;

                if (propertytype.Contains("ICollection`1") || (propertytype.Contains("IList`1")))
                {
                    var xx = prop.PropertyType.GenericTypeArguments[0];
                    sb.Append(GeneralClass.PreparePropertyAsCollectionOrList(xx.Name, prop.Name, propertytype));

                }
                else
                {


                    // var name = prop.GetAttributeFrom<DisplayAttribute>(nameof(prop.PlayerDescription)).Name;


                    sb.Append(GeneralClass.PrepareProperty(prop));
                }
            }

            return sb.ToString();
        }

        public static string GenerateBaseEntity(Type type, string name_space)
        {
            string baseEntity = "";
            // var entityName = "BaseEntity"; // find the base entity name
            var Output = new StringBuilder();
            Output.Append(ProduceEntityHeader(name_space, type, baseEntity));
            Output.Append(GeneralClass.newlinepad(12) + "public Guid GuidId { get; set; } = default;");
            Output.Append(GeneralClass.newlinepad(8) + GeneralClass.ProduceClosingBrace());
            Output.Append(GeneralClass.newlinepad(0) + GeneralClass.ProduceClosingBrace());
            return Output.ToString();
        }


    }


}


