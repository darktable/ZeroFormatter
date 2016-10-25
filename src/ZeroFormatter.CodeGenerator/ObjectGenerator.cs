﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 14.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace ZeroFormatter.CodeGenerator
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Users\y.kawai\Documents\neuecc\ZeroFormatter\src\ZeroFormatter.CodeGenerator\ObjectGenerator.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public partial class ObjectGenerator : ObjectGeneratorBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("#pragma warning disable 618\r\n#pragma warning disable 612\r\n#pragma warning disable" +
                    " 414\r\n#pragma warning disable 168\r\nnamespace ");
            
            #line 10 "C:\Users\y.kawai\Documents\neuecc\ZeroFormatter\src\ZeroFormatter.CodeGenerator\ObjectGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n    using global::System;\r\n    using global::ZeroFormatter.Formatters;\r\n    " +
                    "using global::ZeroFormatter.Internal;\r\n    using global::ZeroFormatter.Segments;" +
                    "\r\n\r\n");
            
            #line 17 "C:\Users\y.kawai\Documents\neuecc\ZeroFormatter\src\ZeroFormatter.CodeGenerator\ObjectGenerator.tt"
 foreach(var t in Types) {  
            
            #line default
            #line hidden
            this.Write("    public class ");
            
            #line 18 "C:\Users\y.kawai\Documents\neuecc\ZeroFormatter\src\ZeroFormatter.CodeGenerator\ObjectGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(t.Name));
            
            #line default
            #line hidden
            this.Write("Formatter : Formatter<");
            
            #line 18 "C:\Users\y.kawai\Documents\neuecc\ZeroFormatter\src\ZeroFormatter.CodeGenerator\ObjectGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(t.FullName));
            
            #line default
            #line hidden
            this.Write(">\r\n    {\r\n        public override int? GetLength()\r\n        {\r\n            return" +
                    " null;\r\n        }\r\n\r\n        public override int Serialize(ref byte[] bytes, int" +
                    " offset, ");
            
            #line 25 "C:\Users\y.kawai\Documents\neuecc\ZeroFormatter\src\ZeroFormatter.CodeGenerator\ObjectGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(t.FullName));
            
            #line default
            #line hidden
            this.Write(@" value)
        {
            var segment = value as IZeroFormatterSegment;
            if (segment != null)
            {
                return segment.Serialize(ref bytes, offset);
            }
            else if (value == null)
            {
                BinaryUtil.WriteInt32(ref bytes, offset, -1);
                return 4;
            }
            else
            {
                var startOffset = offset;

                offset += (8 + 4 * (");
            
            #line 41 "C:\Users\y.kawai\Documents\neuecc\ZeroFormatter\src\ZeroFormatter.CodeGenerator\ObjectGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(t.LastIndex));
            
            #line default
            #line hidden
            this.Write(" + 1));\r\n");
            
            #line 42 "C:\Users\y.kawai\Documents\neuecc\ZeroFormatter\src\ZeroFormatter.CodeGenerator\ObjectGenerator.tt"
 foreach(var p in t.Properties) { 
            
            #line default
            #line hidden
            this.Write("                offset += ObjectSegmentHelper.SerialzieFromFormatter<");
            
            #line 43 "C:\Users\y.kawai\Documents\neuecc\ZeroFormatter\src\ZeroFormatter.CodeGenerator\ObjectGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(p.Type));
            
            #line default
            #line hidden
            this.Write(">(ref bytes, startOffset, offset, ");
            
            #line 43 "C:\Users\y.kawai\Documents\neuecc\ZeroFormatter\src\ZeroFormatter.CodeGenerator\ObjectGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(p.Index));
            
            #line default
            #line hidden
            this.Write(", value.");
            
            #line 43 "C:\Users\y.kawai\Documents\neuecc\ZeroFormatter\src\ZeroFormatter.CodeGenerator\ObjectGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(p.Name));
            
            #line default
            #line hidden
            this.Write(");\r\n");
            
            #line 44 "C:\Users\y.kawai\Documents\neuecc\ZeroFormatter\src\ZeroFormatter.CodeGenerator\ObjectGenerator.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\r\n                return ObjectSegmentHelper.WriteSize(ref bytes, startOffset, of" +
                    "fset, ");
            
            #line 46 "C:\Users\y.kawai\Documents\neuecc\ZeroFormatter\src\ZeroFormatter.CodeGenerator\ObjectGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(t.LastIndex));
            
            #line default
            #line hidden
            this.Write(");\r\n            }\r\n        }\r\n\r\n        public override ");
            
            #line 50 "C:\Users\y.kawai\Documents\neuecc\ZeroFormatter\src\ZeroFormatter.CodeGenerator\ObjectGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(t.FullName));
            
            #line default
            #line hidden
            this.Write(@" Deserialize(ref byte[] bytes, int offset, DirtyTracker tracker, out int byteSize)
        {
            byteSize = BinaryUtil.ReadInt32(ref bytes, offset);
            if (byteSize == -1)
            {
                byteSize = 4;
                return null;
            }
            return new ");
            
            #line 58 "C:\Users\y.kawai\Documents\neuecc\ZeroFormatter\src\ZeroFormatter.CodeGenerator\ObjectGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(t.Name));
            
            #line default
            #line hidden
            this.Write("ObjectSegment(tracker, new ArraySegment<byte>(bytes, offset, byteSize));\r\n       " +
                    " }\r\n    }\r\n\r\n    public class ");
            
            #line 62 "C:\Users\y.kawai\Documents\neuecc\ZeroFormatter\src\ZeroFormatter.CodeGenerator\ObjectGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(t.Name));
            
            #line default
            #line hidden
            this.Write("ObjectSegment : ");
            
            #line 62 "C:\Users\y.kawai\Documents\neuecc\ZeroFormatter\src\ZeroFormatter.CodeGenerator\ObjectGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(t.FullName));
            
            #line default
            #line hidden
            this.Write(", IZeroFormatterSegment\r\n    {\r\n        static readonly int[] __elementSizes = ne" +
                    "w int[]{ ");
            
            #line 64 "C:\Users\y.kawai\Documents\neuecc\ZeroFormatter\src\ZeroFormatter.CodeGenerator\ObjectGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(string.Join(", ", t.ElementFixedSizes)));
            
            #line default
            #line hidden
            this.Write(" };\r\n\r\n        readonly ArraySegment<byte> __originalBytes;\r\n        readonly Dir" +
                    "tyTracker __tracker;\r\n        readonly int __binaryLastIndex;\r\n        readonly " +
                    "byte[] __extraFixedBytes;\r\n\r\n");
            
            #line 71 "C:\Users\y.kawai\Documents\neuecc\ZeroFormatter\src\ZeroFormatter.CodeGenerator\ObjectGenerator.tt"
 foreach(var p in t.Properties) { 
            
            #line default
            #line hidden
            
            #line 72 "C:\Users\y.kawai\Documents\neuecc\ZeroFormatter\src\ZeroFormatter.CodeGenerator\ObjectGenerator.tt"
 if(p.IsFixedSize) { 
            
            #line default
            #line hidden
            
            #line 73 "C:\Users\y.kawai\Documents\neuecc\ZeroFormatter\src\ZeroFormatter.CodeGenerator\ObjectGenerator.tt"
 } else if(p.IsCacheSegment) { 
            
            #line default
            #line hidden
            this.Write("        readonly CacheSegment<");
            
            #line 74 "C:\Users\y.kawai\Documents\neuecc\ZeroFormatter\src\ZeroFormatter.CodeGenerator\ObjectGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(p.Type));
            
            #line default
            #line hidden
            this.Write("> _");
            
            #line 74 "C:\Users\y.kawai\Documents\neuecc\ZeroFormatter\src\ZeroFormatter.CodeGenerator\ObjectGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(p.Name));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 75 "C:\Users\y.kawai\Documents\neuecc\ZeroFormatter\src\ZeroFormatter.CodeGenerator\ObjectGenerator.tt"
 } else { 
            
            #line default
            #line hidden
            this.Write("        ");
            
            #line 76 "C:\Users\y.kawai\Documents\neuecc\ZeroFormatter\src\ZeroFormatter.CodeGenerator\ObjectGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(p.Type));
            
            #line default
            #line hidden
            this.Write(" _");
            
            #line 76 "C:\Users\y.kawai\Documents\neuecc\ZeroFormatter\src\ZeroFormatter.CodeGenerator\ObjectGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(p.Name));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 77 "C:\Users\y.kawai\Documents\neuecc\ZeroFormatter\src\ZeroFormatter.CodeGenerator\ObjectGenerator.tt"
 } } 
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 79 "C:\Users\y.kawai\Documents\neuecc\ZeroFormatter\src\ZeroFormatter.CodeGenerator\ObjectGenerator.tt"
 foreach(var p in t.Properties) { 
            
            #line default
            #line hidden
            this.Write("        // ");
            
            #line 80 "C:\Users\y.kawai\Documents\neuecc\ZeroFormatter\src\ZeroFormatter.CodeGenerator\ObjectGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(p.Index));
            
            #line default
            #line hidden
            this.Write("\r\n        public override ");
            
            #line 81 "C:\Users\y.kawai\Documents\neuecc\ZeroFormatter\src\ZeroFormatter.CodeGenerator\ObjectGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(p.Type));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 81 "C:\Users\y.kawai\Documents\neuecc\ZeroFormatter\src\ZeroFormatter.CodeGenerator\ObjectGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(p.Name));
            
            #line default
            #line hidden
            this.Write("\r\n        {\r\n");
            
            #line 83 "C:\Users\y.kawai\Documents\neuecc\ZeroFormatter\src\ZeroFormatter.CodeGenerator\ObjectGenerator.tt"
 if(p.IsFixedSize) { 
            
            #line default
            #line hidden
            this.Write("            ");
            
            #line 84 "C:\Users\y.kawai\Documents\neuecc\ZeroFormatter\src\ZeroFormatter.CodeGenerator\ObjectGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture((p.IsGetProtected ? "protected " : "") + "get"));
            
            #line default
            #line hidden
            this.Write("\r\n            {\r\n                return ObjectSegmentHelper.GetFixedProperty<");
            
            #line 86 "C:\Users\y.kawai\Documents\neuecc\ZeroFormatter\src\ZeroFormatter.CodeGenerator\ObjectGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(p.Type));
            
            #line default
            #line hidden
            this.Write(">(__originalBytes, ");
            
            #line 86 "C:\Users\y.kawai\Documents\neuecc\ZeroFormatter\src\ZeroFormatter.CodeGenerator\ObjectGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(p.Index));
            
            #line default
            #line hidden
            this.Write(", __binaryLastIndex, __extraFixedBytes, __tracker);\r\n            }\r\n            ");
            
            #line 88 "C:\Users\y.kawai\Documents\neuecc\ZeroFormatter\src\ZeroFormatter.CodeGenerator\ObjectGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture((p.IsSetProtected ? "protected " : "") + "set"));
            
            #line default
            #line hidden
            this.Write("\r\n            {\r\n                ObjectSegmentHelper.SetFixedProperty<");
            
            #line 90 "C:\Users\y.kawai\Documents\neuecc\ZeroFormatter\src\ZeroFormatter.CodeGenerator\ObjectGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(p.Type));
            
            #line default
            #line hidden
            this.Write(">(__originalBytes, ");
            
            #line 90 "C:\Users\y.kawai\Documents\neuecc\ZeroFormatter\src\ZeroFormatter.CodeGenerator\ObjectGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(p.Index));
            
            #line default
            #line hidden
            this.Write(", __binaryLastIndex, __extraFixedBytes, value);\r\n            }\r\n");
            
            #line 92 "C:\Users\y.kawai\Documents\neuecc\ZeroFormatter\src\ZeroFormatter.CodeGenerator\ObjectGenerator.tt"
 } else if(p.IsCacheSegment) { 
            
            #line default
            #line hidden
            this.Write("            ");
            
            #line 93 "C:\Users\y.kawai\Documents\neuecc\ZeroFormatter\src\ZeroFormatter.CodeGenerator\ObjectGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture((p.IsGetProtected ? "protected " : "") + "get"));
            
            #line default
            #line hidden
            this.Write("\r\n            {\r\n                return _");
            
            #line 95 "C:\Users\y.kawai\Documents\neuecc\ZeroFormatter\src\ZeroFormatter.CodeGenerator\ObjectGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(p.Name));
            
            #line default
            #line hidden
            this.Write(".Value;\r\n            }\r\n            ");
            
            #line 97 "C:\Users\y.kawai\Documents\neuecc\ZeroFormatter\src\ZeroFormatter.CodeGenerator\ObjectGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture((p.IsSetProtected ? "protected " : "") + "set"));
            
            #line default
            #line hidden
            this.Write("\r\n            {\r\n                _");
            
            #line 99 "C:\Users\y.kawai\Documents\neuecc\ZeroFormatter\src\ZeroFormatter.CodeGenerator\ObjectGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(p.Name));
            
            #line default
            #line hidden
            this.Write(".Value = value;\r\n            }\r\n");
            
            #line 101 "C:\Users\y.kawai\Documents\neuecc\ZeroFormatter\src\ZeroFormatter.CodeGenerator\ObjectGenerator.tt"
 } else { 
            
            #line default
            #line hidden
            this.Write("            ");
            
            #line 102 "C:\Users\y.kawai\Documents\neuecc\ZeroFormatter\src\ZeroFormatter.CodeGenerator\ObjectGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture((p.IsGetProtected ? "protected " : "") + "get"));
            
            #line default
            #line hidden
            this.Write("\r\n            {\r\n                return _");
            
            #line 104 "C:\Users\y.kawai\Documents\neuecc\ZeroFormatter\src\ZeroFormatter.CodeGenerator\ObjectGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(p.Name));
            
            #line default
            #line hidden
            this.Write(";\r\n            }\r\n            ");
            
            #line 106 "C:\Users\y.kawai\Documents\neuecc\ZeroFormatter\src\ZeroFormatter.CodeGenerator\ObjectGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture((p.IsSetProtected ? "protected " : "") + "set"));
            
            #line default
            #line hidden
            this.Write("\r\n            {\r\n                __tracker.Dirty();\r\n                _");
            
            #line 109 "C:\Users\y.kawai\Documents\neuecc\ZeroFormatter\src\ZeroFormatter.CodeGenerator\ObjectGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(p.Name));
            
            #line default
            #line hidden
            this.Write(" = value;\r\n            }\r\n");
            
            #line 111 "C:\Users\y.kawai\Documents\neuecc\ZeroFormatter\src\ZeroFormatter.CodeGenerator\ObjectGenerator.tt"
 } 
            
            #line default
            #line hidden
            this.Write("        }\r\n\r\n");
            
            #line 114 "C:\Users\y.kawai\Documents\neuecc\ZeroFormatter\src\ZeroFormatter.CodeGenerator\ObjectGenerator.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\r\n        public ");
            
            #line 116 "C:\Users\y.kawai\Documents\neuecc\ZeroFormatter\src\ZeroFormatter.CodeGenerator\ObjectGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(t.Name));
            
            #line default
            #line hidden
            this.Write(@"ObjectSegment(DirtyTracker dirtyTracker, ArraySegment<byte> originalBytes)
        {
            var __array = originalBytes.Array;
            int __out;

            this.__originalBytes = originalBytes;
            this.__tracker = dirtyTracker = dirtyTracker.CreateChild();
            this.__binaryLastIndex = BinaryUtil.ReadInt32(ref __array, originalBytes.Offset + 4);

            this.__extraFixedBytes = ObjectSegmentHelper.CreateExtraFixedBytes(this.__binaryLastIndex, ");
            
            #line 125 "C:\Users\y.kawai\Documents\neuecc\ZeroFormatter\src\ZeroFormatter.CodeGenerator\ObjectGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(t.LastIndex));
            
            #line default
            #line hidden
            this.Write(", __elementSizes);\r\n\r\n");
            
            #line 127 "C:\Users\y.kawai\Documents\neuecc\ZeroFormatter\src\ZeroFormatter.CodeGenerator\ObjectGenerator.tt"
 foreach(var p in t.Properties) { 
            
            #line default
            #line hidden
            
            #line 128 "C:\Users\y.kawai\Documents\neuecc\ZeroFormatter\src\ZeroFormatter.CodeGenerator\ObjectGenerator.tt"
 if (p.IsFixedSize) { 
            
            #line default
            #line hidden
            
            #line 129 "C:\Users\y.kawai\Documents\neuecc\ZeroFormatter\src\ZeroFormatter.CodeGenerator\ObjectGenerator.tt"
 } else if(p.IsCacheSegment) { 
            
            #line default
            #line hidden
            this.Write("            _");
            
            #line 130 "C:\Users\y.kawai\Documents\neuecc\ZeroFormatter\src\ZeroFormatter.CodeGenerator\ObjectGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(p.Name));
            
            #line default
            #line hidden
            this.Write(" = new CacheSegment<");
            
            #line 130 "C:\Users\y.kawai\Documents\neuecc\ZeroFormatter\src\ZeroFormatter.CodeGenerator\ObjectGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(p.Type));
            
            #line default
            #line hidden
            this.Write(">(__tracker, ObjectSegmentHelper.GetSegment(originalBytes, ");
            
            #line 130 "C:\Users\y.kawai\Documents\neuecc\ZeroFormatter\src\ZeroFormatter.CodeGenerator\ObjectGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(p.Index));
            
            #line default
            #line hidden
            this.Write(", __binaryLastIndex));\r\n");
            
            #line 131 "C:\Users\y.kawai\Documents\neuecc\ZeroFormatter\src\ZeroFormatter.CodeGenerator\ObjectGenerator.tt"
 } else { 
            
            #line default
            #line hidden
            this.Write("            _");
            
            #line 132 "C:\Users\y.kawai\Documents\neuecc\ZeroFormatter\src\ZeroFormatter.CodeGenerator\ObjectGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(p.Name));
            
            #line default
            #line hidden
            this.Write(" = Formatter<");
            
            #line 132 "C:\Users\y.kawai\Documents\neuecc\ZeroFormatter\src\ZeroFormatter.CodeGenerator\ObjectGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(p.Type));
            
            #line default
            #line hidden
            this.Write(">.Default.Deserialize(ref __array, ObjectSegmentHelper.GetOffset(originalBytes, ");
            
            #line 132 "C:\Users\y.kawai\Documents\neuecc\ZeroFormatter\src\ZeroFormatter.CodeGenerator\ObjectGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(p.Index));
            
            #line default
            #line hidden
            this.Write(", __binaryLastIndex), __tracker, out __out);\r\n");
            
            #line 133 "C:\Users\y.kawai\Documents\neuecc\ZeroFormatter\src\ZeroFormatter.CodeGenerator\ObjectGenerator.tt"
 } 
            
            #line default
            #line hidden
            
            #line 134 "C:\Users\y.kawai\Documents\neuecc\ZeroFormatter\src\ZeroFormatter.CodeGenerator\ObjectGenerator.tt"
 } 
            
            #line default
            #line hidden
            this.Write(@"        }

        public bool CanDirectCopy()
        {
            return !__tracker.IsDirty;
        }

        public ArraySegment<byte> GetBufferReference()
        {
            return __originalBytes;
        }

        public int Serialize(ref byte[] targetBytes, int offset)
        {
            if (__extraFixedBytes != null || __tracker.IsDirty)
            {
                var startOffset = offset;
                offset += (8 + 4 * (");
            
            #line 152 "C:\Users\y.kawai\Documents\neuecc\ZeroFormatter\src\ZeroFormatter.CodeGenerator\ObjectGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(t.LastIndex));
            
            #line default
            #line hidden
            this.Write(" + 1));\r\n\r\n");
            
            #line 154 "C:\Users\y.kawai\Documents\neuecc\ZeroFormatter\src\ZeroFormatter.CodeGenerator\ObjectGenerator.tt"
 foreach(var p in t.Properties) { 
            
            #line default
            #line hidden
            
            #line 155 "C:\Users\y.kawai\Documents\neuecc\ZeroFormatter\src\ZeroFormatter.CodeGenerator\ObjectGenerator.tt"
 if (p.IsFixedSize) { 
            
            #line default
            #line hidden
            this.Write("                offset += ObjectSegmentHelper.SerializeFixedLength<");
            
            #line 156 "C:\Users\y.kawai\Documents\neuecc\ZeroFormatter\src\ZeroFormatter.CodeGenerator\ObjectGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(p.Type));
            
            #line default
            #line hidden
            this.Write(">(ref targetBytes, startOffset, offset, ");
            
            #line 156 "C:\Users\y.kawai\Documents\neuecc\ZeroFormatter\src\ZeroFormatter.CodeGenerator\ObjectGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(p.Index));
            
            #line default
            #line hidden
            this.Write(", __binaryLastIndex, __originalBytes, __extraFixedBytes);\r\n");
            
            #line 157 "C:\Users\y.kawai\Documents\neuecc\ZeroFormatter\src\ZeroFormatter.CodeGenerator\ObjectGenerator.tt"
 } else if(p.IsCacheSegment) { 
            
            #line default
            #line hidden
            this.Write("                offset += ObjectSegmentHelper.SerializeCacheSegment<");
            
            #line 158 "C:\Users\y.kawai\Documents\neuecc\ZeroFormatter\src\ZeroFormatter.CodeGenerator\ObjectGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(p.Type));
            
            #line default
            #line hidden
            this.Write(">(ref targetBytes, startOffset, offset, ");
            
            #line 158 "C:\Users\y.kawai\Documents\neuecc\ZeroFormatter\src\ZeroFormatter.CodeGenerator\ObjectGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(p.Index));
            
            #line default
            #line hidden
            this.Write(", _");
            
            #line 158 "C:\Users\y.kawai\Documents\neuecc\ZeroFormatter\src\ZeroFormatter.CodeGenerator\ObjectGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(p.Name));
            
            #line default
            #line hidden
            this.Write(");\r\n");
            
            #line 159 "C:\Users\y.kawai\Documents\neuecc\ZeroFormatter\src\ZeroFormatter.CodeGenerator\ObjectGenerator.tt"
 } else { 
            
            #line default
            #line hidden
            this.Write("                offset += ObjectSegmentHelper.SerializeSegment<");
            
            #line 160 "C:\Users\y.kawai\Documents\neuecc\ZeroFormatter\src\ZeroFormatter.CodeGenerator\ObjectGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(p.Type));
            
            #line default
            #line hidden
            this.Write(">(ref targetBytes, startOffset, offset, ");
            
            #line 160 "C:\Users\y.kawai\Documents\neuecc\ZeroFormatter\src\ZeroFormatter.CodeGenerator\ObjectGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(p.Index));
            
            #line default
            #line hidden
            this.Write(", _");
            
            #line 160 "C:\Users\y.kawai\Documents\neuecc\ZeroFormatter\src\ZeroFormatter.CodeGenerator\ObjectGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(p.Name));
            
            #line default
            #line hidden
            this.Write(");\r\n");
            
            #line 161 "C:\Users\y.kawai\Documents\neuecc\ZeroFormatter\src\ZeroFormatter.CodeGenerator\ObjectGenerator.tt"
 } } 
            
            #line default
            #line hidden
            this.Write("\r\n                return ObjectSegmentHelper.WriteSize(ref targetBytes, startOffs" +
                    "et, offset, ");
            
            #line 163 "C:\Users\y.kawai\Documents\neuecc\ZeroFormatter\src\ZeroFormatter.CodeGenerator\ObjectGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(t.LastIndex));
            
            #line default
            #line hidden
            this.Write(");\r\n            }\r\n            else\r\n            {\r\n                return Object" +
                    "SegmentHelper.DirectCopyAll(__originalBytes, ref targetBytes, offset);\r\n        " +
                    "    }\r\n        }\r\n    }\r\n\r\n");
            
            #line 172 "C:\Users\y.kawai\Documents\neuecc\ZeroFormatter\src\ZeroFormatter.CodeGenerator\ObjectGenerator.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\r\n}\r\n\r\n#pragma warning restore 168\r\n#pragma warning restore 414\r\n#pragma warning " +
                    "restore 618\r\n#pragma warning restore 612");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public class ObjectGeneratorBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
