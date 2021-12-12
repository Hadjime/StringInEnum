using System;
using System.Reflection;
using System.Runtime.Serialization;
using UnityEngine;

namespace Attribute
{
    public enum StringEnum
    {
        [StringValueAttribute("1")]
        Qwerty,
        [StringValueAttribute("2")]
        Asdf,
        [StringValueAttribute("3")]
        Zxcv,
        [StringValueAttribute("3")]
        z,
        [StringValueAttribute("3")]
        x,
        [StringValueAttribute("3")]
        c,
        [StringValueAttribute("3")]
        v,
        [StringValueAttribute("3")]
        b,
        [StringValueAttribute("3")]
        n,
        [StringValueAttribute("3")]
        m,
        [StringValueAttribute("3")]
        a,
        [StringValueAttribute("3")]
        s
    }
    public class StringValueAttribute : System.Attribute
    {
        public string StringValue { get; protected set;}


        public StringValueAttribute(string value)
        {
            this.StringValue = value;
        }

        public static string GetStringValue(Enum value)
        {
            Type type = value.GetType();
            FieldInfo fieldInfo = type.GetField(value.ToString());
            StringValueAttribute[] attribs = fieldInfo.GetCustomAttributes(
                typeof(StringValueAttribute), false) as StringValueAttribute[];
            
            return attribs.Length > 0 ? attribs[0].StringValue : null;
        }
        
    }

    public class DictionaryKey
    {
        public const string Player1 = "player_1111111";
        public const string Player2 = "player_22222222";
        public const string Player3 = "player_33333333";
    }

    
}
