﻿using CSharpFunctionalExtensions;
using EdmxConv.Schema.Extensions;
using static EdmxConv.Core.FlowHelpers;

namespace EdmxConv.Schema
{
    public sealed class DatabaseEdmx : Edmx
    {
        /// <summary>
        /// Hexdecimal binary model
        /// </summary>
        /// <example>0x1F8B0800000000000400CD57DB6EDB38107D5F60FF81...</example>
        public Hex Value { get; }

        public DatabaseEdmx(string hexInString) : this(hexInString.ToHex()) { }

        public DatabaseEdmx(Hex value)
            : base(EdmxTypeEnum.Database)
        {
            Value = value;
        }

        public override string ToString() => Value.Value;

        public static Result<DatabaseEdmx> Create(string edmx) =>
            With(edmx)
                .OnSuccess(x => x.ToHex())
                .OnSuccess(x => x.ToDatabaseEdmx());

    }
}