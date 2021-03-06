﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MINT;

namespace MINT
{
    public class Opcodes
    {
        public Dictionary<byte, string> KSA_OpcodeNames = new Dictionary<byte, string>()
        {
            {0x01, "setFalse" },
            {0x02, "setTrue" },
            {0x03, "load" },
            {0x04, "loadString" },
            {0x05, "moveRegister" },
            {0x06, "loadPair" },
            {0x07, "NOP" },
            {0x08, "loadField" },
            {0x09, "loadPointer32" },
            {0x0A, "loadArrayIndex32" },
            {0x0B, "loadPointer64" },
            {0x0C, "loadArrayIndex64" },
            {0x0D, "loadArrayIndex64[1]" },
            {0x0E, "loadXref" },
            {0x0F, "loadXref" },
            {0x10, "deref" },
            {0x11, "setPointer32" },
            {0x12, "setArrayIndex32" },
            {0x13, "setPointer64" },
            {0x14, "setArrayIndex64" },
            {0x15, "setField" },
            {0x16, "addi" },
            {0x17, "subi" },
            {0x18, "multis" },
            {0x19, "divis" },
            {0x1A, "modis" },
            {0x1B, "multi" },
            {0x1C, "divi" },
            {0x1D, "modi" },
            {0x1E, "inci" },
            {0x1F, "deci" },
            {0x20, "negi" },
            {0x21, "addf" },
            {0x22, "subf" },
            {0x23, "multf" },
            {0x24, "divf" },
            {0x25, "incf" },
            {0x26, "decf" },
            {0x27, "negf" },
            {0x28, "lessThan" },
            {0x29, "lessOrEqual" },
            {0x2A, "greaterOrEqual" },
            {0x2B, "greaterThan" },
            {0x2C, "equal" },
            {0x2D, "notEqual" },
            {0x2E, "floatLess" },
            {0x2F, "floatLessOrEqual" },
            {0x30, "floatEqual" },
            {0x31, "floatNotEqual" },
            {0x32, "lessThanZero" },
            {0x33, "lessOrEqualZero" },
            {0x34, "boolEqual" },
            {0x35, "boolNotEqual" },
            {0x36, "equal64" },
            {0x37, "notEqual64" },
            {0x38, "stringEqual" },
            {0x39, "stringNotEqual" },
            {0x3A, "stringEqualU16" },
            {0x3B, "stringNotEqualU16" },
            {0x3C, "returnIfGreater" },
            {0x3D, "bitAnd" },
            {0x3E, "bitOr" },
            {0x3F, "bitXor" },
            {0x40, "bitNot" },
            {0x41, "flipLowest" },
            {0x42, "shiftLeft" },
            {0x43, "shiftRight" },
            {0x44, "jump" },
            {0x45, "jumpIfTrue" },
            {0x46, "jumpIfFalse" },
            {0x47, "declare" },
            {0x48, "return" },
            {0x49, "call" },
            {0x4A, "callExternal" },
            {0x4B, "callExternal2" },
            {0x4C, "callExternal3" },
            {0x4D, "unk_4D" },

            {0x4F, "yield" },
            {0x50, "unk_50" },
            {0x51, "unk_51" },

            {0x53, "unk_53" },
            {0x54, "unk_54" },
            {0x55, "unk_55" },
            {0x56, "unk_56" },
            {0x57, "unk_57" },
            {0x58, "unk_58" },
            {0x59, "unk_59" },
            {0x5A, "unk_5A" },
            {0x5B, "unk_5B" },
            {0x5C, "unk_5C" },
            {0x5D, "unk_5D" },
            {0x5E, "unk_5E" },
            {0x5F, "floatToInt" },
            {0x60, "unk_60" },
            {0x61, "unk_61" },
            {0x62, "unk_62" },
            {0x63, "intToFloat" },
            {0x64, "unk_64" },

            {0x66, "unk_66" },
            {0x67, "unk_67" },
            {0x68, "unk_68" },
            {0x69, "unk_69" },
            {0x6A, "unk_6A" },
            {0x6B, "unk_6B" }
        };
        public Dictionary<byte, Format> KSA_OpcodeFormats = new Dictionary<byte, Format>()
        {
            {0x01, Format.Z },
            {0x02, Format.Z },
            {0x03, Format.sZV },
            {0x04, Format.strZV },
            {0x05, Format.ZX },
            {0x06, Format.LDP },
            {0x07, Format.None },
            {0x08, Format.xZV },
            {0x09, Format.ZX },
            {0x0A, Format.ZXxY },
            {0x0B, Format.ZX },
            {0x0C, Format.ZXxY },
            {0x0D, Format.xZV },
            {0x0E, Format.xZV },
            {0x0F, Format.xZV },
            {0x10, Format.ZX },
            {0x11, Format.ZX },
            {0x12, Format.XZxY },
            {0x13, Format.ZX },
            {0x14, Format.XZxY },
            {0x15, Format.xZV },
            {0x16, Format.LDP },
            {0x17, Format.LDP },
            {0x18, Format.LDP },
            {0x19, Format.LDP },
            {0x1A, Format.LDP },
            {0x1B, Format.LDP },
            {0x1C, Format.LDP },
            {0x1D, Format.LDP },
            {0x1E, Format.Z },
            {0x1F, Format.Z },
            {0x20, Format.Z },
            {0x21, Format.LDP },
            {0x22, Format.LDP },
            {0x23, Format.LDP },
            {0x24, Format.LDP },
            {0x25, Format.Z },
            {0x26, Format.Z },
            {0x27, Format.Z },
            {0x28, Format.LDP },
            {0x29, Format.LDP },
            {0x2A, Format.LDP },
            {0x2B, Format.LDP },
            {0x2C, Format.LDP },
            {0x2D, Format.LDP },
            {0x2E, Format.LDP },
            {0x2F, Format.LDP },
            {0x30, Format.LDP },
            {0x31, Format.LDP },
            {0x32, Format.ZX },
            {0x33, Format.ZX },
            {0x34, Format.LDP },
            {0x35, Format.LDP },
            {0x36, Format.ZXY },
            {0x37, Format.ZXY },
            {0x38, Format.LDPstr },
            {0x39, Format.LDPstr },
            {0x3A, Format.LDPstr },
            {0x3B, Format.LDPstr },
            {0x3C, Format.ZX },
            {0x3D, Format.LDP },
            {0x3E, Format.LDP },
            {0x3F, Format.LDP },
            {0x40, Format.ZX },
            {0x41, Format.ZX },
            {0x42, Format.LDP },
            {0x43, Format.LDP },
            {0x44, Format.shV },
            {0x45, Format.shZV },
            {0x46, Format.shZV },
            {0x47, Format.nZXY },
            {0x48, Format.Ret },
            {0x49, Format.xZV },
            {0x4A, Format.xZV },
            {0x4B, Format.xZV },
            {0x4C, Format.xZV },
            {0x4D, Format.ZXY },

            {0x4F, Format.Z },
            {0x50, Format.ZXY },
            {0x51, Format.ZXxY },

            {0x53, Format.xZV },
            {0x54, Format.xZV },
            {0x55, Format.xZV },
            {0x56, Format.xZV },
            {0x57, Format.ZXxY },
            {0x58, Format.Z },
            {0x59, Format.ZX },
            {0x5A, Format.ZX },
            {0x5B, Format.ZXY },
            {0x5C, Format.xZV },
            {0x5D, Format.ZXY },
            {0x5E, Format.xZV },
            {0x5F, Format.ZX },
            {0x60, Format.ZX },
            {0x61, Format.ZX },
            {0x62, Format.ZX },
            {0x63, Format.ZX },
            {0x64, Format.ZX },
            
            {0x66, Format.xZV },
            {0x67, Format.xZV },
            {0x68, Format.sZV },
            {0x69, Format.xZV },
            {0x6A, Format.ZX },
            {0x6B, Format.xZV },
        };
        public Dictionary<byte, string> KPR_OpcodeNames = new Dictionary<byte, string>()
        {
            {0x42, "declare" },
            {0x43, "return" },
            {0x44, "returnVal" },
        };
        public Dictionary<byte, Format> KPR_OpcodeFormats = new Dictionary<byte, Format>()
        {
            {0x42, Format.nZXY },
            {0x43, Format.None },
            {0x44, Format.Y },
        };
        public Dictionary<byte, string> TDX_OpcodeNames = new Dictionary<byte, string>()
        {
            { 0x01, "setTrue" },
            { 0x02, "setFalse" },
            { 0x03, "load" },
            { 0x04, "loadString"},
            { 0x05, "moveRegister" },
            { 0x06, "moveResult" },
            { 0x07, "setArg" },
            { 0x08, "setArg2" },
            { 0x09, "setArg3" },
            { 0x0A, "setArg?" },

            { 0x0C, "getStatic" },
            { 0x0D, "getDeref" },
            { 0x0E, "getField" },
            { 0x0F, "sizeOf" },

            { 0x12, "putDeref" },
            { 0x13, "putField" },
            { 0x14, "putStatic" },

            { 0x15, "addi" },
            { 0x16, "subi" },
            { 0x17, "multi" },
            { 0x18, "divi" },
            { 0x19, "modi" },

            { 0x1D, "inci" },
            { 0x1F, "negi" },

            { 0x46, "declare" },
            { 0x47, "return" },
            { 0x48, "returnVal" },
            { 0x49, "callLocal" },
            { 0x4A, "call?" },
            { 0x4B, "callExternal" }
        };
        public Dictionary<byte, Format> TDX_OpcodeFormats = new Dictionary<byte, Format>()
        {
            { 0x01, Format.Z },
            { 0x02, Format.Z },
            { 0x03, Format.sZV },
            { 0x04, Format.strZV },
            { 0x05, Format.ZX },
            { 0x06, Format.Z },
            { 0x07, Format.aZX },
            { 0x08, Format.aZXY },
            { 0x09, Format.ZXY },
            { 0x0A, Format.aaZX },

            { 0x0C, Format.strZV },
            { 0x0D, Format.ZX },
            { 0x0E, Format.ZXxY },
            { 0x0F, Format.xZV },

            { 0x12, Format.ZX },
            { 0x13, Format.ZXxY },
            { 0x14, Format.xZV },

            { 0x15, Format.ZXY },
            { 0x16, Format.ZXY },
            { 0x17, Format.ZXY },
            { 0x18, Format.ZXY },
            { 0x19, Format.ZXY },

            { 0x1D, Format.Z },
            { 0x1F, Format.ZX },

            { 0x46, Format.nZXY },
            { 0x47, Format.None },
            { 0x48, Format.Y },
            { 0x49, Format.xV },
            { 0x4A, Format.xV },
            { 0x4B, Format.xV }
        };
        public Dictionary<byte, string> RDL_OpcodeNames = new Dictionary<byte, string>()
        {
            {0x00, "NOP" },
            {0x01, "setTrue" },
            {0x02, "setFalse" },
            {0x03, "load" },
            {0x04, "loadString" },
            {0x05, "moveRegister" },
            {0x06, "moveResult" },
            {0x07, "setArg" },

            {0x09, "loadField" },
            {0x0A, "loadXref" },
            {0x0B, "sizeOf" },
            {0x0C, "deref" },
            {0x0D, "setField" },
            {0x0E, "addi" },
            {0x0F, "subi" },
            {0x10, "multi" },
            {0x11, "divi" },
            {0x12, "modi" },
            {0x13, "inci" },
            {0x14, "deci" },
            {0x15, "negi" },
            {0x16, "addf" },
            {0x17, "subf" },
            {0x18, "multf" },
            {0x19, "divf" },
            {0x1A, "incf" },
            {0x1B, "decf" },
            {0x1C, "negf" },
            {0x1D, "lessThan" },
            {0x1E, "lessOrEqual" },
            {0x1F, "equal" },
            {0x20, "notEqual" },
            {0x21, "floatLess" },
            {0x22, "floatLessOrEqual" },
            {0x23, "floatEqual" },
            {0x24, "floatNotEqual" },
            {0x25, "lessThanZero" },
            {0x26, "lessOrEqualZero" },
            {0x27, "boolEqual" },
            {0x28, "boolNotEqual" },
            {0x29, "bitAnd" },
            {0x2A, "bitOr" },
            {0x2B, "bitXor" },
            {0x2C, "flipLowest" },
            {0x2D, "bitNot" },
            {0x2E, "shiftLeft" },
            {0x2F, "shiftRight" },
            {0x30, "jump" },
            {0x31, "jumpIfTrue" },
            {0x32, "jumpIfFalse" },
            {0x33, "declare" },
            {0x34, "return" },
            {0x35, "returnVal" },
            {0x36, "call" },
            {0x37, "yield" },
            {0x38, "copy" },
            {0x39, "zero" },
            {0x3A, "new" },
            {0x3B, "clear" },
            {0x3C, "del" },
            {0x3D, "getField" },
            {0x3E, "makeArray" },
            {0x3F, "arrayIndex" },
            {0x40, "arrayLength" },
            {0x41, "deleteArray" }
        };
        public Dictionary<byte, Format> RDL_OpcodeFormats = new Dictionary<byte, Format>()
        {
            {0x00, Format.None },
            {0x01, Format.Z },
            {0x02, Format.Z },
            {0x03, Format.sZV },
            {0x04, Format.strZV },
            {0x05, Format.ZX },
            {0x06, Format.Z },
            {0x07, Format.aZX },

            {0x09, Format.xZV },
            {0x0A, Format.ZX },
            {0x0B, Format.xZV },
            {0x0C, Format.ZX },
            {0x0D, Format.xZV },
            {0x0E, Format.ZXY },
            {0x0F, Format.ZXY },
            {0x10, Format.ZXY },
            {0x11, Format.ZXY },
            {0x12, Format.ZXY },
            {0x13, Format.Z },
            {0x14, Format.Z },
            {0x15, Format.ZX },
            {0x16, Format.ZXY },
            {0x17, Format.ZXY },
            {0x18, Format.ZXY },
            {0x19, Format.ZXY },
            {0x1A, Format.Z },
            {0x1B, Format.Z },
            {0x1C, Format.ZX },
            {0x1D, Format.ZXY },
            {0x1E, Format.ZXY },
            {0x1F, Format.ZXY },
            {0x20, Format.ZXY },
            {0x21, Format.ZXY },
            {0x22, Format.ZXY },
            {0x23, Format.ZXY },
            {0x24, Format.ZXY },
            {0x25, Format.ZX },
            {0x26, Format.ZX },
            {0x27, Format.ZXY },
            {0x28, Format.ZXY },
            {0x29, Format.ZXY },
            {0x2A, Format.ZXY },
            {0x2B, Format.ZXY },
            {0x2C, Format.ZX },
            {0x2D, Format.ZX },
            {0x2E, Format.ZXY },
            {0x2F, Format.ZXY },
            {0x30, Format.shV },
            {0x31, Format.shZV },
            {0x32, Format.shZV },
            {0x33, Format.nZXY },
            {0x34, Format.Ret },
            {0x35, Format.RetX },
            {0x36, Format.xV },
            {0x37, Format.Z },
            {0x38, Format.ZXY },
            {0x39, Format.ZXY },
            {0x3A, Format.xZV },
            {0x3B, Format.xZV },
            {0x3C, Format.xZV },
            {0x3D, Format.xZV },
            {0x3E, Format.Z },
            {0x3F, Format.ZX },
            {0x40, Format.ZX },
            {0x41, Format.Z }
        };
    }
}
