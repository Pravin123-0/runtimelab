// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;

namespace System.Runtime.CompilerServices
{
    // This attribute should be placed on a static field by the code author to indicate that it is expected to
    // be completely pre-initialized by the tool chain.  The tool chain will produce an error if the field
    // cannot be completely pre-initialized.
    [AttributeUsage(AttributeTargets.Field)]
    public sealed class PreInitializedAttribute : Attribute
    {
    }

    // Generated by the toolchain.  Associates a given static field with a corresponding RVA static field
    // containing the pre-initialization data blob.
    [AttributeUsage(AttributeTargets.Field)]
    public sealed class InitDataBlobAttribute : Attribute
    {
        public InitDataBlobAttribute(Type containerType, string rvaFieldName) { }
    }

    // Generated by the toolchain.  Placed on the toolchain-generated RVA/proxy static field.  Represents a fixup
    // to a method address.  Obviously, overloaded methods are ambiguous with this set of parameters.
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = true)]
    public sealed class MethodAddrFixupAttribute : Attribute
    {
        public MethodAddrFixupAttribute(int offset, Type containerType, string methodName) { }
    }

    // Generated by the toolchain.  Placed on the toolchain-generated RVA/proxy static field.  Represents a fixup
    // to the address of a static field.
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = true)]
    public sealed class FieldAddrFixupAttribute : Attribute
    {
        public FieldAddrFixupAttribute(int offset, Type containerType, string fieldName) { }
    }

    // Generated by the toolchain.  Placed on the toolchain-generated RVA/proxy static field.  Represents a fixup
    // to a type handle (e.g. typeof(foo).TypeHandle).
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = true)]
    public sealed class TypeHandleFixupAttribute : Attribute
    {
        public TypeHandleFixupAttribute(int offset, Type type) { }
        public TypeHandleFixupAttribute(int offset, string typeName) { }
    }

    // Generated by the toolchain.  Placed on the toolchain-generated proxy static field.  Represents the initialization
    // of a non-array-typed static field.
    [AttributeUsage(AttributeTargets.Field)]
    public sealed class NonArrayAttribute : Attribute
    {
        public NonArrayAttribute() { }
    }

    // Generated by the toolchain.  Placed on the toolchain-generated proxy static field.  Represents the element
    // type of the static array-typed field being initialized.
    [AttributeUsage(AttributeTargets.Field)]
    public sealed class ElemTypeAttribute : Attribute
    {
        public ElemTypeAttribute(Type elemType) { }
    }
}
