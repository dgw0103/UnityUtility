using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

//public class CodeWriter
//{
//    private StringBuilder buffer;
//    private int indentLevel;
//    private static readonly int tabIndentLevel = 4;



//    public CodeWriter()
//    {
//        buffer = new StringBuilder();
//        indentLevel = 0;
//    }



//    public void BeginBlock()
//    {
//        WriteIndent();
//        buffer.Append("{\n");
//        ++indentLevel;
//    }
//    public void EndBlock()
//    {
//        --indentLevel;
//        WriteIndent();
//        buffer.Append("}\n");
//    }
//    public void WriteLine()
//    {
//        buffer.Append('\n');
//    }
//    public void WriteLine(string text)
//    {
//        if (text.All(char.IsWhiteSpace) == false)
//        {
//            WriteIndent();
//            buffer.Append(text);
//        }
//        buffer.Append('\n');
//    }
//    public void Write(string text)
//    {
//        buffer.Append(text);
//    }
//    public void WriteIndent()
//    {
//        for (var i = 0; i < indentLevel; ++i)
//        {
//            for (var n = 0; n < tabIndentLevel; ++n)
//            {
//                buffer.Append(' ');
//            }
//        }
//    }
//}