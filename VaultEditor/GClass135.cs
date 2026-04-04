using System;
using System.IO;
using System.Reflection;

namespace VaultEditor;

public static class GClass135
{
    public static void smethod_0<T>(this T gparam_0, BinaryReader binaryReader_0) where T : class
    {
        PropertyInfo[] properties = gparam_0.GetType().GetProperties(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public);
        int num = 0;
        while (true)
        {
            if (num >= properties.Length)
            {
                return;
            }
            PropertyInfo propertyInfo = properties[num];
            object obj;
            if (propertyInfo.PropertyType == typeof(string))
            {
                int length = propertyInfo.GetCustomAttribute<GAttribute3>().Length;
                obj = binaryReader_0.smethod_5(length);
            }
            else if (propertyInfo.PropertyType == typeof(byte[]))
            {
                int length2 = propertyInfo.GetCustomAttribute<GAttribute3>().Length;
                obj = binaryReader_0.ReadBytes(length2);
            }
            else if (propertyInfo.PropertyType == typeof(double))
            {
                obj = binaryReader_0.ReadDouble();
            }
            else if (propertyInfo.PropertyType == typeof(decimal))
            {
                obj = binaryReader_0.ReadDecimal();
            }
            else if (propertyInfo.PropertyType == typeof(bool))
            {
                obj = binaryReader_0.ReadBoolean();
            }
            else if (propertyInfo.PropertyType == typeof(char))
            {
                obj = binaryReader_0.ReadChar();
            }
            else if (propertyInfo.PropertyType == typeof(byte))
            {
                GAttribute4 customAttribute = propertyInfo.GetCustomAttribute<GAttribute4>();
                if (customAttribute != null)
                {
                    binaryReader_0.smethod_8(customAttribute.Padding);
                    goto IL_02ea;
                }
                obj = binaryReader_0.ReadByte();
            }
            else if (propertyInfo.PropertyType == typeof(sbyte))
            {
                obj = binaryReader_0.ReadSByte();
            }
            else if (propertyInfo.PropertyType == typeof(float))
            {
                obj = binaryReader_0.ReadSingle();
            }
            else if (propertyInfo.PropertyType == typeof(short))
            {
                obj = binaryReader_0.ReadInt16();
            }
            else if (propertyInfo.PropertyType == typeof(ushort))
            {
                obj = binaryReader_0.ReadUInt16();
            }
            else if (propertyInfo.PropertyType == typeof(int))
            {
                obj = binaryReader_0.ReadInt32();
            }
            else if (propertyInfo.PropertyType == typeof(uint))
            {
                obj = binaryReader_0.ReadUInt32();
            }
            else if (propertyInfo.PropertyType == typeof(ulong))
            {
                obj = binaryReader_0.ReadUInt64();
            }
            else if (propertyInfo.PropertyType == typeof(long))
            {
                obj = binaryReader_0.ReadInt64();
            }
            else if (propertyInfo.PropertyType.IsEnum)
            {
                obj = binaryReader_0.ReadInt32();
            }
            else
            {
                if (!propertyInfo.PropertyType.IsClass)
                {
                    break;
                }
                obj = Activator.CreateInstance(propertyInfo.PropertyType);
                obj.smethod_0(binaryReader_0);
            }
            propertyInfo.SetValue(gparam_0, obj);
            goto IL_02ea;
        IL_02ea:
            num++;
        }
        throw new Exception();
    }

    public static void smethod_1(this object object_0, BinaryWriter binaryWriter_0)
    {
        PropertyInfo[] properties = object_0.GetType().GetProperties(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public);
        int num = 0;
        while (true)
        {
            if (num >= properties.Length)
            {
                return;
            }
            PropertyInfo propertyInfo = properties[num];
            object value = propertyInfo.GetValue(object_0);
            if (propertyInfo.PropertyType == typeof(string))
            {
                int length = propertyInfo.GetCustomAttribute<GAttribute3>().Length;
                binaryWriter_0.smethod_17((string)value, length);
            }
            else if (propertyInfo.PropertyType == typeof(byte[]))
            {
                _ = propertyInfo.GetCustomAttribute<GAttribute3>().Length;
                binaryWriter_0.Write((byte[])value);
            }
            else if (propertyInfo.PropertyType == typeof(double))
            {
                binaryWriter_0.Write((double)value);
            }
            else if (propertyInfo.PropertyType == typeof(decimal))
            {
                binaryWriter_0.Write((decimal)value);
            }
            else if (propertyInfo.PropertyType == typeof(bool))
            {
                binaryWriter_0.Write((bool)value);
            }
            else if (propertyInfo.PropertyType == typeof(char))
            {
                binaryWriter_0.Write((char)value);
            }
            else if (propertyInfo.PropertyType == typeof(byte))
            {
                GAttribute4 customAttribute = propertyInfo.GetCustomAttribute<GAttribute4>();
                if (customAttribute != null)
                {
                    binaryWriter_0.smethod_16(customAttribute.Padding);
                }
                else
                {
                    binaryWriter_0.Write((byte)value);
                }
            }
            else if (propertyInfo.PropertyType == typeof(sbyte))
            {
                binaryWriter_0.Write((sbyte)value);
            }
            else if (propertyInfo.PropertyType == typeof(float))
            {
                binaryWriter_0.Write((float)value);
            }
            else if (propertyInfo.PropertyType == typeof(short))
            {
                binaryWriter_0.Write((short)value);
            }
            else if (propertyInfo.PropertyType == typeof(ushort))
            {
                binaryWriter_0.Write((ushort)value);
            }
            else if (propertyInfo.PropertyType == typeof(int))
            {
                binaryWriter_0.Write((int)value);
            }
            else if (propertyInfo.PropertyType == typeof(uint))
            {
                binaryWriter_0.Write((uint)value);
            }
            else if (propertyInfo.PropertyType == typeof(ulong))
            {
                binaryWriter_0.Write((ulong)value);
            }
            else if (propertyInfo.PropertyType == typeof(long))
            {
                binaryWriter_0.Write((long)value);
            }
            else if (propertyInfo.PropertyType.IsEnum)
            {
                binaryWriter_0.Write((int)value);
            }
            else
            {
                if (!propertyInfo.PropertyType.IsClass)
                {
                    break;
                }
                value.smethod_1(binaryWriter_0);
            }
            num++;
        }
        throw new Exception();
    }
}
