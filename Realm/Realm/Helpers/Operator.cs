////////////////////////////////////////////////////////////////////////////
//
// Copyright 2020 Realm Inc.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using MongoDB.Bson;

namespace Realms.Helpers
{
    /// <summary>
    /// A class that exposes a set of methods that we know are defined on a generic argument
    /// but there's no way to express them via the C# generic constraint system. It is generated
    /// by T4 transforming Operator.tt.
    /// </summary>
    [Preserve]
    internal static class Operator
    {
        private static IDictionary<(Type, Type), IConverter> _valueConverters = new Dictionary<(Type, Type), IConverter>
        {
            [(typeof(char), typeof(RealmValue))] = new CharRealmValueConverter(),
            [(typeof(byte), typeof(RealmValue))] = new ByteRealmValueConverter(),
            [(typeof(short), typeof(RealmValue))] = new ShortRealmValueConverter(),
            [(typeof(int), typeof(RealmValue))] = new IntRealmValueConverter(),
            [(typeof(long), typeof(RealmValue))] = new LongRealmValueConverter(),
            [(typeof(float), typeof(RealmValue))] = new FloatRealmValueConverter(),
            [(typeof(double), typeof(RealmValue))] = new DoubleRealmValueConverter(),
            [(typeof(bool), typeof(RealmValue))] = new BoolRealmValueConverter(),
            [(typeof(DateTimeOffset), typeof(RealmValue))] = new DateTimeOffsetRealmValueConverter(),
            [(typeof(decimal), typeof(RealmValue))] = new DecimalRealmValueConverter(),
            [(typeof(Decimal128), typeof(RealmValue))] = new Decimal128RealmValueConverter(),
            [(typeof(ObjectId), typeof(RealmValue))] = new ObjectIdRealmValueConverter(),
            [(typeof(Guid), typeof(RealmValue))] = new GuidRealmValueConverter(),
            [(typeof(char?), typeof(RealmValue))] = new NullableCharRealmValueConverter(),
            [(typeof(byte?), typeof(RealmValue))] = new NullableByteRealmValueConverter(),
            [(typeof(short?), typeof(RealmValue))] = new NullableShortRealmValueConverter(),
            [(typeof(int?), typeof(RealmValue))] = new NullableIntRealmValueConverter(),
            [(typeof(long?), typeof(RealmValue))] = new NullableLongRealmValueConverter(),
            [(typeof(float?), typeof(RealmValue))] = new NullableFloatRealmValueConverter(),
            [(typeof(double?), typeof(RealmValue))] = new NullableDoubleRealmValueConverter(),
            [(typeof(bool?), typeof(RealmValue))] = new NullableBoolRealmValueConverter(),
            [(typeof(DateTimeOffset?), typeof(RealmValue))] = new NullableDateTimeOffsetRealmValueConverter(),
            [(typeof(decimal?), typeof(RealmValue))] = new NullableDecimalRealmValueConverter(),
            [(typeof(Decimal128?), typeof(RealmValue))] = new NullableDecimal128RealmValueConverter(),
            [(typeof(ObjectId?), typeof(RealmValue))] = new NullableObjectIdRealmValueConverter(),
            [(typeof(Guid?), typeof(RealmValue))] = new NullableGuidRealmValueConverter(),
            [(typeof(RealmInteger<byte>), typeof(RealmValue))] = new RealmIntegerByteRealmValueConverter(),
            [(typeof(RealmInteger<short>), typeof(RealmValue))] = new RealmIntegerShortRealmValueConverter(),
            [(typeof(RealmInteger<int>), typeof(RealmValue))] = new RealmIntegerIntRealmValueConverter(),
            [(typeof(RealmInteger<long>), typeof(RealmValue))] = new RealmIntegerLongRealmValueConverter(),
            [(typeof(RealmInteger<byte>?), typeof(RealmValue))] = new NullableRealmIntegerByteRealmValueConverter(),
            [(typeof(RealmInteger<short>?), typeof(RealmValue))] = new NullableRealmIntegerShortRealmValueConverter(),
            [(typeof(RealmInteger<int>?), typeof(RealmValue))] = new NullableRealmIntegerIntRealmValueConverter(),
            [(typeof(RealmInteger<long>?), typeof(RealmValue))] = new NullableRealmIntegerLongRealmValueConverter(),
            [(typeof(byte[]), typeof(RealmValue))] = new ByteArrayRealmValueConverter(),
            [(typeof(string), typeof(RealmValue))] = new StringRealmValueConverter(),
            [(typeof(RealmObjectBase), typeof(RealmValue))] = new RealmObjectBaseRealmValueConverter(),
            [(typeof(RealmValue), typeof(char))] = new RealmValueCharConverter(),
            [(typeof(RealmValue), typeof(byte))] = new RealmValueByteConverter(),
            [(typeof(RealmValue), typeof(short))] = new RealmValueShortConverter(),
            [(typeof(RealmValue), typeof(int))] = new RealmValueIntConverter(),
            [(typeof(RealmValue), typeof(long))] = new RealmValueLongConverter(),
            [(typeof(RealmValue), typeof(float))] = new RealmValueFloatConverter(),
            [(typeof(RealmValue), typeof(double))] = new RealmValueDoubleConverter(),
            [(typeof(RealmValue), typeof(bool))] = new RealmValueBoolConverter(),
            [(typeof(RealmValue), typeof(DateTimeOffset))] = new RealmValueDateTimeOffsetConverter(),
            [(typeof(RealmValue), typeof(decimal))] = new RealmValueDecimalConverter(),
            [(typeof(RealmValue), typeof(Decimal128))] = new RealmValueDecimal128Converter(),
            [(typeof(RealmValue), typeof(ObjectId))] = new RealmValueObjectIdConverter(),
            [(typeof(RealmValue), typeof(Guid))] = new RealmValueGuidConverter(),
            [(typeof(RealmValue), typeof(char?))] = new RealmValueNullableCharConverter(),
            [(typeof(RealmValue), typeof(byte?))] = new RealmValueNullableByteConverter(),
            [(typeof(RealmValue), typeof(short?))] = new RealmValueNullableShortConverter(),
            [(typeof(RealmValue), typeof(int?))] = new RealmValueNullableIntConverter(),
            [(typeof(RealmValue), typeof(long?))] = new RealmValueNullableLongConverter(),
            [(typeof(RealmValue), typeof(float?))] = new RealmValueNullableFloatConverter(),
            [(typeof(RealmValue), typeof(double?))] = new RealmValueNullableDoubleConverter(),
            [(typeof(RealmValue), typeof(bool?))] = new RealmValueNullableBoolConverter(),
            [(typeof(RealmValue), typeof(DateTimeOffset?))] = new RealmValueNullableDateTimeOffsetConverter(),
            [(typeof(RealmValue), typeof(decimal?))] = new RealmValueNullableDecimalConverter(),
            [(typeof(RealmValue), typeof(Decimal128?))] = new RealmValueNullableDecimal128Converter(),
            [(typeof(RealmValue), typeof(ObjectId?))] = new RealmValueNullableObjectIdConverter(),
            [(typeof(RealmValue), typeof(Guid?))] = new RealmValueNullableGuidConverter(),
            [(typeof(RealmValue), typeof(RealmInteger<byte>))] = new RealmValueRealmIntegerByteConverter(),
            [(typeof(RealmValue), typeof(RealmInteger<short>))] = new RealmValueRealmIntegerShortConverter(),
            [(typeof(RealmValue), typeof(RealmInteger<int>))] = new RealmValueRealmIntegerIntConverter(),
            [(typeof(RealmValue), typeof(RealmInteger<long>))] = new RealmValueRealmIntegerLongConverter(),
            [(typeof(RealmValue), typeof(RealmInteger<byte>?))] = new RealmValueNullableRealmIntegerByteConverter(),
            [(typeof(RealmValue), typeof(RealmInteger<short>?))] = new RealmValueNullableRealmIntegerShortConverter(),
            [(typeof(RealmValue), typeof(RealmInteger<int>?))] = new RealmValueNullableRealmIntegerIntConverter(),
            [(typeof(RealmValue), typeof(RealmInteger<long>?))] = new RealmValueNullableRealmIntegerLongConverter(),
            [(typeof(RealmValue), typeof(byte[]))] = new RealmValueByteArrayConverter(),
            [(typeof(RealmValue), typeof(string))] = new RealmValueStringConverter(),
            [(typeof(RealmValue), typeof(RealmObjectBase))] = new RealmValueRealmObjectBaseConverter(),
            [(typeof(char), typeof(char?))] = new CharNullableCharConverter(),
            [(typeof(char), typeof(byte?))] = new CharNullableByteConverter(),
            [(typeof(char), typeof(short?))] = new CharNullableShortConverter(),
            [(typeof(char), typeof(int?))] = new CharNullableIntConverter(),
            [(typeof(char), typeof(long?))] = new CharNullableLongConverter(),
            [(typeof(char), typeof(RealmInteger<byte>?))] = new CharNullableRealmIntegerByteConverter(),
            [(typeof(char), typeof(RealmInteger<short>?))] = new CharNullableRealmIntegerShortConverter(),
            [(typeof(char), typeof(RealmInteger<int>?))] = new CharNullableRealmIntegerIntConverter(),
            [(typeof(char), typeof(RealmInteger<long>?))] = new CharNullableRealmIntegerLongConverter(),
            [(typeof(char), typeof(float?))] = new CharNullableFloatConverter(),
            [(typeof(char), typeof(double?))] = new CharNullableDoubleConverter(),
            [(typeof(char), typeof(decimal?))] = new CharNullableDecimalConverter(),
            [(typeof(char), typeof(Decimal128?))] = new CharNullableDecimal128Converter(),
            [(typeof(byte), typeof(char?))] = new ByteNullableCharConverter(),
            [(typeof(byte), typeof(byte?))] = new ByteNullableByteConverter(),
            [(typeof(byte), typeof(short?))] = new ByteNullableShortConverter(),
            [(typeof(byte), typeof(int?))] = new ByteNullableIntConverter(),
            [(typeof(byte), typeof(long?))] = new ByteNullableLongConverter(),
            [(typeof(byte), typeof(RealmInteger<byte>?))] = new ByteNullableRealmIntegerByteConverter(),
            [(typeof(byte), typeof(RealmInteger<short>?))] = new ByteNullableRealmIntegerShortConverter(),
            [(typeof(byte), typeof(RealmInteger<int>?))] = new ByteNullableRealmIntegerIntConverter(),
            [(typeof(byte), typeof(RealmInteger<long>?))] = new ByteNullableRealmIntegerLongConverter(),
            [(typeof(byte), typeof(float?))] = new ByteNullableFloatConverter(),
            [(typeof(byte), typeof(double?))] = new ByteNullableDoubleConverter(),
            [(typeof(byte), typeof(decimal?))] = new ByteNullableDecimalConverter(),
            [(typeof(byte), typeof(Decimal128?))] = new ByteNullableDecimal128Converter(),
            [(typeof(short), typeof(char?))] = new ShortNullableCharConverter(),
            [(typeof(short), typeof(byte?))] = new ShortNullableByteConverter(),
            [(typeof(short), typeof(short?))] = new ShortNullableShortConverter(),
            [(typeof(short), typeof(int?))] = new ShortNullableIntConverter(),
            [(typeof(short), typeof(long?))] = new ShortNullableLongConverter(),
            [(typeof(short), typeof(RealmInteger<byte>?))] = new ShortNullableRealmIntegerByteConverter(),
            [(typeof(short), typeof(RealmInteger<short>?))] = new ShortNullableRealmIntegerShortConverter(),
            [(typeof(short), typeof(RealmInteger<int>?))] = new ShortNullableRealmIntegerIntConverter(),
            [(typeof(short), typeof(RealmInteger<long>?))] = new ShortNullableRealmIntegerLongConverter(),
            [(typeof(short), typeof(float?))] = new ShortNullableFloatConverter(),
            [(typeof(short), typeof(double?))] = new ShortNullableDoubleConverter(),
            [(typeof(short), typeof(decimal?))] = new ShortNullableDecimalConverter(),
            [(typeof(short), typeof(Decimal128?))] = new ShortNullableDecimal128Converter(),
            [(typeof(int), typeof(char?))] = new IntNullableCharConverter(),
            [(typeof(int), typeof(byte?))] = new IntNullableByteConverter(),
            [(typeof(int), typeof(short?))] = new IntNullableShortConverter(),
            [(typeof(int), typeof(int?))] = new IntNullableIntConverter(),
            [(typeof(int), typeof(long?))] = new IntNullableLongConverter(),
            [(typeof(int), typeof(RealmInteger<byte>?))] = new IntNullableRealmIntegerByteConverter(),
            [(typeof(int), typeof(RealmInteger<short>?))] = new IntNullableRealmIntegerShortConverter(),
            [(typeof(int), typeof(RealmInteger<int>?))] = new IntNullableRealmIntegerIntConverter(),
            [(typeof(int), typeof(RealmInteger<long>?))] = new IntNullableRealmIntegerLongConverter(),
            [(typeof(int), typeof(float?))] = new IntNullableFloatConverter(),
            [(typeof(int), typeof(double?))] = new IntNullableDoubleConverter(),
            [(typeof(int), typeof(decimal?))] = new IntNullableDecimalConverter(),
            [(typeof(int), typeof(Decimal128?))] = new IntNullableDecimal128Converter(),
            [(typeof(long), typeof(char?))] = new LongNullableCharConverter(),
            [(typeof(long), typeof(byte?))] = new LongNullableByteConverter(),
            [(typeof(long), typeof(short?))] = new LongNullableShortConverter(),
            [(typeof(long), typeof(int?))] = new LongNullableIntConverter(),
            [(typeof(long), typeof(long?))] = new LongNullableLongConverter(),
            [(typeof(long), typeof(RealmInteger<byte>?))] = new LongNullableRealmIntegerByteConverter(),
            [(typeof(long), typeof(RealmInteger<short>?))] = new LongNullableRealmIntegerShortConverter(),
            [(typeof(long), typeof(RealmInteger<int>?))] = new LongNullableRealmIntegerIntConverter(),
            [(typeof(long), typeof(RealmInteger<long>?))] = new LongNullableRealmIntegerLongConverter(),
            [(typeof(long), typeof(float?))] = new LongNullableFloatConverter(),
            [(typeof(long), typeof(double?))] = new LongNullableDoubleConverter(),
            [(typeof(long), typeof(decimal?))] = new LongNullableDecimalConverter(),
            [(typeof(long), typeof(Decimal128?))] = new LongNullableDecimal128Converter(),
            [(typeof(RealmInteger<byte>), typeof(char?))] = new RealmIntegerByteNullableCharConverter(),
            [(typeof(RealmInteger<byte>), typeof(byte?))] = new RealmIntegerByteNullableByteConverter(),
            [(typeof(RealmInteger<byte>), typeof(short?))] = new RealmIntegerByteNullableShortConverter(),
            [(typeof(RealmInteger<byte>), typeof(int?))] = new RealmIntegerByteNullableIntConverter(),
            [(typeof(RealmInteger<byte>), typeof(long?))] = new RealmIntegerByteNullableLongConverter(),
            [(typeof(RealmInteger<byte>), typeof(RealmInteger<byte>?))] = new RealmIntegerByteNullableRealmIntegerByteConverter(),
            [(typeof(RealmInteger<byte>), typeof(RealmInteger<short>?))] = new RealmIntegerByteNullableRealmIntegerShortConverter(),
            [(typeof(RealmInteger<byte>), typeof(RealmInteger<int>?))] = new RealmIntegerByteNullableRealmIntegerIntConverter(),
            [(typeof(RealmInteger<byte>), typeof(RealmInteger<long>?))] = new RealmIntegerByteNullableRealmIntegerLongConverter(),
            [(typeof(RealmInteger<byte>), typeof(float?))] = new RealmIntegerByteNullableFloatConverter(),
            [(typeof(RealmInteger<byte>), typeof(double?))] = new RealmIntegerByteNullableDoubleConverter(),
            [(typeof(RealmInteger<byte>), typeof(decimal?))] = new RealmIntegerByteNullableDecimalConverter(),
            [(typeof(RealmInteger<byte>), typeof(Decimal128?))] = new RealmIntegerByteNullableDecimal128Converter(),
            [(typeof(RealmInteger<short>), typeof(char?))] = new RealmIntegerShortNullableCharConverter(),
            [(typeof(RealmInteger<short>), typeof(byte?))] = new RealmIntegerShortNullableByteConverter(),
            [(typeof(RealmInteger<short>), typeof(short?))] = new RealmIntegerShortNullableShortConverter(),
            [(typeof(RealmInteger<short>), typeof(int?))] = new RealmIntegerShortNullableIntConverter(),
            [(typeof(RealmInteger<short>), typeof(long?))] = new RealmIntegerShortNullableLongConverter(),
            [(typeof(RealmInteger<short>), typeof(RealmInteger<byte>?))] = new RealmIntegerShortNullableRealmIntegerByteConverter(),
            [(typeof(RealmInteger<short>), typeof(RealmInteger<short>?))] = new RealmIntegerShortNullableRealmIntegerShortConverter(),
            [(typeof(RealmInteger<short>), typeof(RealmInteger<int>?))] = new RealmIntegerShortNullableRealmIntegerIntConverter(),
            [(typeof(RealmInteger<short>), typeof(RealmInteger<long>?))] = new RealmIntegerShortNullableRealmIntegerLongConverter(),
            [(typeof(RealmInteger<short>), typeof(float?))] = new RealmIntegerShortNullableFloatConverter(),
            [(typeof(RealmInteger<short>), typeof(double?))] = new RealmIntegerShortNullableDoubleConverter(),
            [(typeof(RealmInteger<short>), typeof(decimal?))] = new RealmIntegerShortNullableDecimalConverter(),
            [(typeof(RealmInteger<short>), typeof(Decimal128?))] = new RealmIntegerShortNullableDecimal128Converter(),
            [(typeof(RealmInteger<int>), typeof(char?))] = new RealmIntegerIntNullableCharConverter(),
            [(typeof(RealmInteger<int>), typeof(byte?))] = new RealmIntegerIntNullableByteConverter(),
            [(typeof(RealmInteger<int>), typeof(short?))] = new RealmIntegerIntNullableShortConverter(),
            [(typeof(RealmInteger<int>), typeof(int?))] = new RealmIntegerIntNullableIntConverter(),
            [(typeof(RealmInteger<int>), typeof(long?))] = new RealmIntegerIntNullableLongConverter(),
            [(typeof(RealmInteger<int>), typeof(RealmInteger<byte>?))] = new RealmIntegerIntNullableRealmIntegerByteConverter(),
            [(typeof(RealmInteger<int>), typeof(RealmInteger<short>?))] = new RealmIntegerIntNullableRealmIntegerShortConverter(),
            [(typeof(RealmInteger<int>), typeof(RealmInteger<int>?))] = new RealmIntegerIntNullableRealmIntegerIntConverter(),
            [(typeof(RealmInteger<int>), typeof(RealmInteger<long>?))] = new RealmIntegerIntNullableRealmIntegerLongConverter(),
            [(typeof(RealmInteger<int>), typeof(float?))] = new RealmIntegerIntNullableFloatConverter(),
            [(typeof(RealmInteger<int>), typeof(double?))] = new RealmIntegerIntNullableDoubleConverter(),
            [(typeof(RealmInteger<int>), typeof(decimal?))] = new RealmIntegerIntNullableDecimalConverter(),
            [(typeof(RealmInteger<int>), typeof(Decimal128?))] = new RealmIntegerIntNullableDecimal128Converter(),
            [(typeof(RealmInteger<long>), typeof(char?))] = new RealmIntegerLongNullableCharConverter(),
            [(typeof(RealmInteger<long>), typeof(byte?))] = new RealmIntegerLongNullableByteConverter(),
            [(typeof(RealmInteger<long>), typeof(short?))] = new RealmIntegerLongNullableShortConverter(),
            [(typeof(RealmInteger<long>), typeof(int?))] = new RealmIntegerLongNullableIntConverter(),
            [(typeof(RealmInteger<long>), typeof(long?))] = new RealmIntegerLongNullableLongConverter(),
            [(typeof(RealmInteger<long>), typeof(RealmInteger<byte>?))] = new RealmIntegerLongNullableRealmIntegerByteConverter(),
            [(typeof(RealmInteger<long>), typeof(RealmInteger<short>?))] = new RealmIntegerLongNullableRealmIntegerShortConverter(),
            [(typeof(RealmInteger<long>), typeof(RealmInteger<int>?))] = new RealmIntegerLongNullableRealmIntegerIntConverter(),
            [(typeof(RealmInteger<long>), typeof(RealmInteger<long>?))] = new RealmIntegerLongNullableRealmIntegerLongConverter(),
            [(typeof(RealmInteger<long>), typeof(float?))] = new RealmIntegerLongNullableFloatConverter(),
            [(typeof(RealmInteger<long>), typeof(double?))] = new RealmIntegerLongNullableDoubleConverter(),
            [(typeof(RealmInteger<long>), typeof(decimal?))] = new RealmIntegerLongNullableDecimalConverter(),
            [(typeof(RealmInteger<long>), typeof(Decimal128?))] = new RealmIntegerLongNullableDecimal128Converter(),
            [(typeof(char), typeof(byte))] = new CharByteConverter(),
            [(typeof(char), typeof(short))] = new CharShortConverter(),
            [(typeof(char), typeof(int))] = new CharIntConverter(),
            [(typeof(char), typeof(long))] = new CharLongConverter(),
            [(typeof(char), typeof(RealmInteger<byte>))] = new CharRealmIntegerByteConverter(),
            [(typeof(char), typeof(RealmInteger<short>))] = new CharRealmIntegerShortConverter(),
            [(typeof(char), typeof(RealmInteger<int>))] = new CharRealmIntegerIntConverter(),
            [(typeof(char), typeof(RealmInteger<long>))] = new CharRealmIntegerLongConverter(),
            [(typeof(char), typeof(float))] = new CharFloatConverter(),
            [(typeof(char), typeof(double))] = new CharDoubleConverter(),
            [(typeof(char), typeof(decimal))] = new CharDecimalConverter(),
            [(typeof(char), typeof(Decimal128))] = new CharDecimal128Converter(),
            [(typeof(byte), typeof(char))] = new ByteCharConverter(),
            [(typeof(byte), typeof(short))] = new ByteShortConverter(),
            [(typeof(byte), typeof(int))] = new ByteIntConverter(),
            [(typeof(byte), typeof(long))] = new ByteLongConverter(),
            [(typeof(byte), typeof(RealmInteger<byte>))] = new ByteRealmIntegerByteConverter(),
            [(typeof(byte), typeof(RealmInteger<short>))] = new ByteRealmIntegerShortConverter(),
            [(typeof(byte), typeof(RealmInteger<int>))] = new ByteRealmIntegerIntConverter(),
            [(typeof(byte), typeof(RealmInteger<long>))] = new ByteRealmIntegerLongConverter(),
            [(typeof(byte), typeof(float))] = new ByteFloatConverter(),
            [(typeof(byte), typeof(double))] = new ByteDoubleConverter(),
            [(typeof(byte), typeof(decimal))] = new ByteDecimalConverter(),
            [(typeof(byte), typeof(Decimal128))] = new ByteDecimal128Converter(),
            [(typeof(short), typeof(char))] = new ShortCharConverter(),
            [(typeof(short), typeof(byte))] = new ShortByteConverter(),
            [(typeof(short), typeof(int))] = new ShortIntConverter(),
            [(typeof(short), typeof(long))] = new ShortLongConverter(),
            [(typeof(short), typeof(RealmInteger<byte>))] = new ShortRealmIntegerByteConverter(),
            [(typeof(short), typeof(RealmInteger<short>))] = new ShortRealmIntegerShortConverter(),
            [(typeof(short), typeof(RealmInteger<int>))] = new ShortRealmIntegerIntConverter(),
            [(typeof(short), typeof(RealmInteger<long>))] = new ShortRealmIntegerLongConverter(),
            [(typeof(short), typeof(float))] = new ShortFloatConverter(),
            [(typeof(short), typeof(double))] = new ShortDoubleConverter(),
            [(typeof(short), typeof(decimal))] = new ShortDecimalConverter(),
            [(typeof(short), typeof(Decimal128))] = new ShortDecimal128Converter(),
            [(typeof(int), typeof(char))] = new IntCharConverter(),
            [(typeof(int), typeof(byte))] = new IntByteConverter(),
            [(typeof(int), typeof(short))] = new IntShortConverter(),
            [(typeof(int), typeof(long))] = new IntLongConverter(),
            [(typeof(int), typeof(RealmInteger<byte>))] = new IntRealmIntegerByteConverter(),
            [(typeof(int), typeof(RealmInteger<short>))] = new IntRealmIntegerShortConverter(),
            [(typeof(int), typeof(RealmInteger<int>))] = new IntRealmIntegerIntConverter(),
            [(typeof(int), typeof(RealmInteger<long>))] = new IntRealmIntegerLongConverter(),
            [(typeof(int), typeof(float))] = new IntFloatConverter(),
            [(typeof(int), typeof(double))] = new IntDoubleConverter(),
            [(typeof(int), typeof(decimal))] = new IntDecimalConverter(),
            [(typeof(int), typeof(Decimal128))] = new IntDecimal128Converter(),
            [(typeof(long), typeof(char))] = new LongCharConverter(),
            [(typeof(long), typeof(byte))] = new LongByteConverter(),
            [(typeof(long), typeof(short))] = new LongShortConverter(),
            [(typeof(long), typeof(int))] = new LongIntConverter(),
            [(typeof(long), typeof(RealmInteger<byte>))] = new LongRealmIntegerByteConverter(),
            [(typeof(long), typeof(RealmInteger<short>))] = new LongRealmIntegerShortConverter(),
            [(typeof(long), typeof(RealmInteger<int>))] = new LongRealmIntegerIntConverter(),
            [(typeof(long), typeof(RealmInteger<long>))] = new LongRealmIntegerLongConverter(),
            [(typeof(long), typeof(float))] = new LongFloatConverter(),
            [(typeof(long), typeof(double))] = new LongDoubleConverter(),
            [(typeof(long), typeof(decimal))] = new LongDecimalConverter(),
            [(typeof(long), typeof(Decimal128))] = new LongDecimal128Converter(),
            [(typeof(RealmInteger<byte>), typeof(char))] = new RealmIntegerByteCharConverter(),
            [(typeof(RealmInteger<byte>), typeof(byte))] = new RealmIntegerByteByteConverter(),
            [(typeof(RealmInteger<byte>), typeof(short))] = new RealmIntegerByteShortConverter(),
            [(typeof(RealmInteger<byte>), typeof(int))] = new RealmIntegerByteIntConverter(),
            [(typeof(RealmInteger<byte>), typeof(long))] = new RealmIntegerByteLongConverter(),
            [(typeof(RealmInteger<byte>), typeof(RealmInteger<short>))] = new RealmIntegerByteRealmIntegerShortConverter(),
            [(typeof(RealmInteger<byte>), typeof(RealmInteger<int>))] = new RealmIntegerByteRealmIntegerIntConverter(),
            [(typeof(RealmInteger<byte>), typeof(RealmInteger<long>))] = new RealmIntegerByteRealmIntegerLongConverter(),
            [(typeof(RealmInteger<byte>), typeof(float))] = new RealmIntegerByteFloatConverter(),
            [(typeof(RealmInteger<byte>), typeof(double))] = new RealmIntegerByteDoubleConverter(),
            [(typeof(RealmInteger<byte>), typeof(decimal))] = new RealmIntegerByteDecimalConverter(),
            [(typeof(RealmInteger<byte>), typeof(Decimal128))] = new RealmIntegerByteDecimal128Converter(),
            [(typeof(RealmInteger<short>), typeof(char))] = new RealmIntegerShortCharConverter(),
            [(typeof(RealmInteger<short>), typeof(byte))] = new RealmIntegerShortByteConverter(),
            [(typeof(RealmInteger<short>), typeof(short))] = new RealmIntegerShortShortConverter(),
            [(typeof(RealmInteger<short>), typeof(int))] = new RealmIntegerShortIntConverter(),
            [(typeof(RealmInteger<short>), typeof(long))] = new RealmIntegerShortLongConverter(),
            [(typeof(RealmInteger<short>), typeof(RealmInteger<byte>))] = new RealmIntegerShortRealmIntegerByteConverter(),
            [(typeof(RealmInteger<short>), typeof(RealmInteger<int>))] = new RealmIntegerShortRealmIntegerIntConverter(),
            [(typeof(RealmInteger<short>), typeof(RealmInteger<long>))] = new RealmIntegerShortRealmIntegerLongConverter(),
            [(typeof(RealmInteger<short>), typeof(float))] = new RealmIntegerShortFloatConverter(),
            [(typeof(RealmInteger<short>), typeof(double))] = new RealmIntegerShortDoubleConverter(),
            [(typeof(RealmInteger<short>), typeof(decimal))] = new RealmIntegerShortDecimalConverter(),
            [(typeof(RealmInteger<short>), typeof(Decimal128))] = new RealmIntegerShortDecimal128Converter(),
            [(typeof(RealmInteger<int>), typeof(char))] = new RealmIntegerIntCharConverter(),
            [(typeof(RealmInteger<int>), typeof(byte))] = new RealmIntegerIntByteConverter(),
            [(typeof(RealmInteger<int>), typeof(short))] = new RealmIntegerIntShortConverter(),
            [(typeof(RealmInteger<int>), typeof(int))] = new RealmIntegerIntIntConverter(),
            [(typeof(RealmInteger<int>), typeof(long))] = new RealmIntegerIntLongConverter(),
            [(typeof(RealmInteger<int>), typeof(RealmInteger<byte>))] = new RealmIntegerIntRealmIntegerByteConverter(),
            [(typeof(RealmInteger<int>), typeof(RealmInteger<short>))] = new RealmIntegerIntRealmIntegerShortConverter(),
            [(typeof(RealmInteger<int>), typeof(RealmInteger<long>))] = new RealmIntegerIntRealmIntegerLongConverter(),
            [(typeof(RealmInteger<int>), typeof(float))] = new RealmIntegerIntFloatConverter(),
            [(typeof(RealmInteger<int>), typeof(double))] = new RealmIntegerIntDoubleConverter(),
            [(typeof(RealmInteger<int>), typeof(decimal))] = new RealmIntegerIntDecimalConverter(),
            [(typeof(RealmInteger<int>), typeof(Decimal128))] = new RealmIntegerIntDecimal128Converter(),
            [(typeof(RealmInteger<long>), typeof(char))] = new RealmIntegerLongCharConverter(),
            [(typeof(RealmInteger<long>), typeof(byte))] = new RealmIntegerLongByteConverter(),
            [(typeof(RealmInteger<long>), typeof(short))] = new RealmIntegerLongShortConverter(),
            [(typeof(RealmInteger<long>), typeof(int))] = new RealmIntegerLongIntConverter(),
            [(typeof(RealmInteger<long>), typeof(long))] = new RealmIntegerLongLongConverter(),
            [(typeof(RealmInteger<long>), typeof(RealmInteger<byte>))] = new RealmIntegerLongRealmIntegerByteConverter(),
            [(typeof(RealmInteger<long>), typeof(RealmInteger<short>))] = new RealmIntegerLongRealmIntegerShortConverter(),
            [(typeof(RealmInteger<long>), typeof(RealmInteger<int>))] = new RealmIntegerLongRealmIntegerIntConverter(),
            [(typeof(RealmInteger<long>), typeof(float))] = new RealmIntegerLongFloatConverter(),
            [(typeof(RealmInteger<long>), typeof(double))] = new RealmIntegerLongDoubleConverter(),
            [(typeof(RealmInteger<long>), typeof(decimal))] = new RealmIntegerLongDecimalConverter(),
            [(typeof(RealmInteger<long>), typeof(Decimal128))] = new RealmIntegerLongDecimal128Converter(),
            [(typeof(float), typeof(float?))] = new FloatNullableFloatConverter(),
            [(typeof(float), typeof(double?))] = new FloatNullableDoubleConverter(),
            [(typeof(float), typeof(decimal?))] = new FloatNullableDecimalConverter(),
            [(typeof(float), typeof(Decimal128?))] = new FloatNullableDecimal128Converter(),
            [(typeof(double), typeof(float?))] = new DoubleNullableFloatConverter(),
            [(typeof(double), typeof(double?))] = new DoubleNullableDoubleConverter(),
            [(typeof(double), typeof(decimal?))] = new DoubleNullableDecimalConverter(),
            [(typeof(double), typeof(Decimal128?))] = new DoubleNullableDecimal128Converter(),
            [(typeof(decimal), typeof(float?))] = new DecimalNullableFloatConverter(),
            [(typeof(decimal), typeof(double?))] = new DecimalNullableDoubleConverter(),
            [(typeof(decimal), typeof(decimal?))] = new DecimalNullableDecimalConverter(),
            [(typeof(decimal), typeof(Decimal128?))] = new DecimalNullableDecimal128Converter(),
            [(typeof(Decimal128), typeof(float?))] = new Decimal128NullableFloatConverter(),
            [(typeof(Decimal128), typeof(double?))] = new Decimal128NullableDoubleConverter(),
            [(typeof(Decimal128), typeof(decimal?))] = new Decimal128NullableDecimalConverter(),
            [(typeof(Decimal128), typeof(Decimal128?))] = new Decimal128NullableDecimal128Converter(),
            [(typeof(float), typeof(double))] = new FloatDoubleConverter(),
            [(typeof(float), typeof(decimal))] = new FloatDecimalConverter(),
            [(typeof(float), typeof(Decimal128))] = new FloatDecimal128Converter(),
            [(typeof(double), typeof(float))] = new DoubleFloatConverter(),
            [(typeof(double), typeof(decimal))] = new DoubleDecimalConverter(),
            [(typeof(double), typeof(Decimal128))] = new DoubleDecimal128Converter(),
            [(typeof(decimal), typeof(float))] = new DecimalFloatConverter(),
            [(typeof(decimal), typeof(double))] = new DecimalDoubleConverter(),
            [(typeof(decimal), typeof(Decimal128))] = new DecimalDecimal128Converter(),
            [(typeof(Decimal128), typeof(float))] = new Decimal128FloatConverter(),
            [(typeof(Decimal128), typeof(double))] = new Decimal128DoubleConverter(),
            [(typeof(Decimal128), typeof(decimal))] = new Decimal128DecimalConverter(),
            [(typeof(bool), typeof(bool?))] = new BoolNullableBoolConverter(),
            [(typeof(DateTimeOffset), typeof(DateTimeOffset?))] = new DateTimeOffsetNullableDateTimeOffsetConverter(),
            [(typeof(ObjectId), typeof(ObjectId?))] = new ObjectIdNullableObjectIdConverter(),
            [(typeof(Guid), typeof(Guid?))] = new GuidNullableGuidConverter(),
        };

        /// <summary>
        /// Efficiently convert a <typeparamref name="TFrom"/> value to <typeparamref name="TResult"/>.
        /// It is intended to be used when we want to convert to or from a generic where we don't
        /// know the exact type, but we know that a conversion exists.
        /// </summary>
        /// <remarks>
        /// In synthetic benchmarks it performs about
        /// two orders of magnitude faster than Convert.ChangeType. It is about 4 times slower than a direct cast
        /// when the types are known, but about an order of magnitude faster than a cast that involves boxing to
        /// object.
        /// <br/>
        /// It makes use of implicit and explicit conversion operators defined on types to convert between
        /// numeric types, which means that we can use it both for downcasting and upcasting numeric types.
        /// </remarks>
        /// <typeparam name="TFrom">The type from which to convert.</typeparam>
        /// <typeparam name="TResult">The type to which <paramref name="value"/> will be converted.</typeparam>
        /// <param name="value">The value to convert to <typeparamref name="TResult"/>.</param>
        /// <returns>The value of <paramref name="value"/> represented as <typeparamref name="TResult"/>.</returns>
        public static TResult Convert<TFrom, TResult>(TFrom value)
        {
            if (typeof(TResult) == typeof(RealmValue))
            {
                /* This is special cased due to a bug in the Xamarin.iOS interpreter. When value
                 * is null, we end up with a NRE with the following stacktrace:
                 *
                 * <System.NullReferenceException: Object reference not set to an instance of an object
                 * at System.Linq.Expressions.Interpreter.LightLambda.Run1[T0,TRet] (T0 arg0) [0x00038] in <ee28ffe65f2e47a98ea97b07327fb8f4>:0
                 * at (wrapper delegate-invoke) System.Func`2[System.String,Realms.RealmValue].invoke_TResult_T(string)
                 * at Realms.Helpers.Operator.Convert[TFrom,TResult] (TFrom value) [0x00005] in <675c1cc840764fcb9ab78b319ccfeee3>:0
                 * at Realms.RealmList`1[T].<.ctor>b__5_1 (T item) [0x00000] in <675c1cc840764fcb9ab78b319ccfeee3>:0
                 * at Realms.RealmList`1[T].Add (T item) [0x00000] in <675c1cc840764fcb9ab78b319ccfeee3>:0
                 *
                 * May or may not be related to https://github.com/mono/mono/issues/15852.
                 */
                if (value is null)
                {
                    return Convert<RealmValue, TResult>(RealmValue.Null());
                }

                /* This is another special case where `value` is inheritable from RealmObjectBase. There's
                 * no direct conversion from T to RealmValue, but there's conversion if we go through RealmObjectBase.
                 */
                if (value is RealmObjectBase robj)
                {
                    return Convert<RealmValue, TResult>(robj);
                }
            }

            return GenericOperator<TFrom, TResult>.Convert(value);
        }

        public static object Convert(object value, Type fromType, Type toType)
        {
            if (toType == typeof(RealmValue))
            {
                // This is special cased due to a bug in the Xamarin.iOS interpreter.
                if (value is null)
                {
                    return RealmValue.Null();
                }

                /* This is another special case where `value` is inheritable from RealmObjectBase. There's
                 * no direct conversion from T to RealmValue, but there's conversion if we go through RealmObjectBase.
                 */
                if (value is RealmObjectBase robj)
                {
                    return new RealmValue(robj);
                }
            }

            if (value is null || fromType == toType)
            {
                return value;
            }

            if (_valueConverters.TryGetValue((fromType, toType), out var converter))
            {
                return converter.Convert(value);
            }

            if (toType.IsAssignableFrom(fromType) || fromType == typeof(object))
            {
                return System.Convert.ChangeType(value, toType);
            }

            if (fromType.IsGenericType && fromType.GetGenericTypeDefinition() == typeof(Nullable<>))
            {
                return Convert(value, fromType.GetGenericArguments()[0], toType);
            }

            throw new NotSupportedException($"No conversion exists from {fromType.FullName} to {toType.FullName}");
        }

        /// <summary>
        /// An operator that exposes a method to convert from <typeparamref name="TSource"/>
        /// to <typeparamref name="TTarget"/>. Upon constructing the closed generic type, the static
        /// constructor will instantiate a <see cref="ISpecializedConverter{TSource, TTarget}"/> and
        /// assign it to a static field for the duration of the application domain.
        /// </summary>
        /// <typeparam name="TSource">The type from which to convert.</typeparam>
        /// <typeparam name="TTarget">The type to which <typeparamref name="TSource"/> will be converted.</typeparam>
        private static class GenericOperator<TSource, TTarget>
        {
            private static readonly ISpecializedConverter<TSource, TTarget> _converter;

            public static TTarget Convert(TSource value) => _converter.Convert(value);

            static GenericOperator()
            {
                var sourceType = typeof(TSource);
                var targetType = typeof(TTarget);

                if (sourceType == targetType)
                {
                    _converter = (ISpecializedConverter<TSource, TTarget>)new UnaryConverter<TSource>();
                }
                else if (_valueConverters.TryGetValue((sourceType, targetType), out var converter))
                {
                    _converter = (ISpecializedConverter<TSource, TTarget>)converter;
                }
                else if (targetType.IsAssignableFrom(sourceType) || sourceType == typeof(object))
                {
                    _converter = new InheritanceConverter<TSource, TTarget>();
                }
                else
                {
                    _converter = new ThrowingConverter<TSource, TTarget>();
                }
            }
        }

        /// <summary>
        /// An interface representing a converter - used primarily to guarantee type safety of the
        /// generated <see cref="_valueConverters"/> dictionary.
        /// </summary>
        private interface IConverter
        {
            object Convert(object value);
        }

        /// <summary>
        /// Interface representing a concrete converter from <typeparamref name="TSource"/>
        /// to <typeparamref name="TTarget"/>. For most types there will be exactly one concrete
        /// implementation, but there may be cases, such as <see cref="InheritanceConverter{TSource, TTarget}"/>
        /// where a single converter type can handle multiple source/target types.
        /// </summary>
        /// <typeparam name="TSource">The type from which to convert.</typeparam>
        /// <typeparam name="TTarget">The type to which <typeparamref name="TSource"/> will be converted.</typeparam>
        private interface ISpecializedConverter<TSource, TTarget> : IConverter
        {
            TTarget Convert(TSource source);
        }

        public abstract class SpecializedConverterBase<TSource, TTarget> : ISpecializedConverter<TSource, TTarget>
        {
            public abstract TTarget Convert(TSource source);

            public object Convert(object value) => Convert((TSource)value);
        }

        /// <summary>
        /// A converter that will throw whenever <see cref="ISpecializedConverter{TSource, TTarget}.Convert(TSource)"/>
        /// is called. This is used to handle cases where there is no conversion from <typeparamref name="TSource"/> to
        /// <typeparamref name="TTarget"/>.
        /// </summary>
        /// <typeparam name="TSource">The type from which to convert.</typeparam>
        /// <typeparam name="TTarget">The type to which <typeparamref name="TSource"/> will be converted.</typeparam>
        private class ThrowingConverter<TSource, TTarget> : SpecializedConverterBase<TSource, TTarget>
        {
            public override TTarget Convert(TSource source) => throw new NotSupportedException($"No conversion exists from {typeof(TSource).FullName} to {typeof(TTarget).FullName}");
        }

        /// <summary>
        /// A converter that converts from the type to itself. There are cases where we don't know what the source or
        /// the target type is, so we need to convert, just in case.
        /// </summary>
        /// <typeparam name="T">The type of both the source and the target.</typeparam>
        private class UnaryConverter<T> : SpecializedConverterBase<T, T>
        {
            public override T Convert(T source) => source;
        }

        /// <summary>
        /// A converter that converts from a type to its base type. This is typically needed
        /// when we want to cast from a RealmObject inheritor to RealmObjectBase or when we
        /// get passed <see cref="object"/>.
        /// </summary>
        /// <typeparam name="TSource">The type from which to convert.</typeparam>
        /// <typeparam name="TTarget">The type to which <typeparamref name="TSource"/> will be converted.</typeparam>
        private class InheritanceConverter<TSource, TTarget> : SpecializedConverterBase<TSource, TTarget>
        {
            public override TTarget Convert(TSource source) => source is TTarget obj ? obj : throw new NotSupportedException($"No conversion exists from {typeof(TSource).FullName} to {typeof(TTarget).FullName}");
        }

        #region ToRealmValue Converters

        public class CharRealmValueConverter : SpecializedConverterBase<char, RealmValue>
        {
            public override RealmValue Convert(char value) => value;
        }

        public class ByteRealmValueConverter : SpecializedConverterBase<byte, RealmValue>
        {
            public override RealmValue Convert(byte value) => value;
        }

        public class ShortRealmValueConverter : SpecializedConverterBase<short, RealmValue>
        {
            public override RealmValue Convert(short value) => value;
        }

        public class IntRealmValueConverter : SpecializedConverterBase<int, RealmValue>
        {
            public override RealmValue Convert(int value) => value;
        }

        public class LongRealmValueConverter : SpecializedConverterBase<long, RealmValue>
        {
            public override RealmValue Convert(long value) => value;
        }

        public class FloatRealmValueConverter : SpecializedConverterBase<float, RealmValue>
        {
            public override RealmValue Convert(float value) => value;
        }

        public class DoubleRealmValueConverter : SpecializedConverterBase<double, RealmValue>
        {
            public override RealmValue Convert(double value) => value;
        }

        public class BoolRealmValueConverter : SpecializedConverterBase<bool, RealmValue>
        {
            public override RealmValue Convert(bool value) => value;
        }

        public class DateTimeOffsetRealmValueConverter : SpecializedConverterBase<DateTimeOffset, RealmValue>
        {
            public override RealmValue Convert(DateTimeOffset value) => value;
        }

        public class DecimalRealmValueConverter : SpecializedConverterBase<decimal, RealmValue>
        {
            public override RealmValue Convert(decimal value) => value;
        }

        public class Decimal128RealmValueConverter : SpecializedConverterBase<Decimal128, RealmValue>
        {
            public override RealmValue Convert(Decimal128 value) => value;
        }

        public class ObjectIdRealmValueConverter : SpecializedConverterBase<ObjectId, RealmValue>
        {
            public override RealmValue Convert(ObjectId value) => value;
        }

        public class GuidRealmValueConverter : SpecializedConverterBase<Guid, RealmValue>
        {
            public override RealmValue Convert(Guid value) => value;
        }

        public class NullableCharRealmValueConverter : SpecializedConverterBase<char?, RealmValue>
        {
            public override RealmValue Convert(char? value) => value;
        }

        public class NullableByteRealmValueConverter : SpecializedConverterBase<byte?, RealmValue>
        {
            public override RealmValue Convert(byte? value) => value;
        }

        public class NullableShortRealmValueConverter : SpecializedConverterBase<short?, RealmValue>
        {
            public override RealmValue Convert(short? value) => value;
        }

        public class NullableIntRealmValueConverter : SpecializedConverterBase<int?, RealmValue>
        {
            public override RealmValue Convert(int? value) => value;
        }

        public class NullableLongRealmValueConverter : SpecializedConverterBase<long?, RealmValue>
        {
            public override RealmValue Convert(long? value) => value;
        }

        public class NullableFloatRealmValueConverter : SpecializedConverterBase<float?, RealmValue>
        {
            public override RealmValue Convert(float? value) => value;
        }

        public class NullableDoubleRealmValueConverter : SpecializedConverterBase<double?, RealmValue>
        {
            public override RealmValue Convert(double? value) => value;
        }

        public class NullableBoolRealmValueConverter : SpecializedConverterBase<bool?, RealmValue>
        {
            public override RealmValue Convert(bool? value) => value;
        }

        public class NullableDateTimeOffsetRealmValueConverter : SpecializedConverterBase<DateTimeOffset?, RealmValue>
        {
            public override RealmValue Convert(DateTimeOffset? value) => value;
        }

        public class NullableDecimalRealmValueConverter : SpecializedConverterBase<decimal?, RealmValue>
        {
            public override RealmValue Convert(decimal? value) => value;
        }

        public class NullableDecimal128RealmValueConverter : SpecializedConverterBase<Decimal128?, RealmValue>
        {
            public override RealmValue Convert(Decimal128? value) => value;
        }

        public class NullableObjectIdRealmValueConverter : SpecializedConverterBase<ObjectId?, RealmValue>
        {
            public override RealmValue Convert(ObjectId? value) => value;
        }

        public class NullableGuidRealmValueConverter : SpecializedConverterBase<Guid?, RealmValue>
        {
            public override RealmValue Convert(Guid? value) => value;
        }

        public class RealmIntegerByteRealmValueConverter : SpecializedConverterBase<RealmInteger<byte>, RealmValue>
        {
            public override RealmValue Convert(RealmInteger<byte> value) => value;
        }

        public class RealmIntegerShortRealmValueConverter : SpecializedConverterBase<RealmInteger<short>, RealmValue>
        {
            public override RealmValue Convert(RealmInteger<short> value) => value;
        }

        public class RealmIntegerIntRealmValueConverter : SpecializedConverterBase<RealmInteger<int>, RealmValue>
        {
            public override RealmValue Convert(RealmInteger<int> value) => value;
        }

        public class RealmIntegerLongRealmValueConverter : SpecializedConverterBase<RealmInteger<long>, RealmValue>
        {
            public override RealmValue Convert(RealmInteger<long> value) => value;
        }

        public class NullableRealmIntegerByteRealmValueConverter : SpecializedConverterBase<RealmInteger<byte>?, RealmValue>
        {
            public override RealmValue Convert(RealmInteger<byte>? value) => value;
        }

        public class NullableRealmIntegerShortRealmValueConverter : SpecializedConverterBase<RealmInteger<short>?, RealmValue>
        {
            public override RealmValue Convert(RealmInteger<short>? value) => value;
        }

        public class NullableRealmIntegerIntRealmValueConverter : SpecializedConverterBase<RealmInteger<int>?, RealmValue>
        {
            public override RealmValue Convert(RealmInteger<int>? value) => value;
        }

        public class NullableRealmIntegerLongRealmValueConverter : SpecializedConverterBase<RealmInteger<long>?, RealmValue>
        {
            public override RealmValue Convert(RealmInteger<long>? value) => value;
        }

        public class ByteArrayRealmValueConverter : SpecializedConverterBase<byte[], RealmValue>
        {
            public override RealmValue Convert(byte[] value) => value;
        }

        public class StringRealmValueConverter : SpecializedConverterBase<string, RealmValue>
        {
            public override RealmValue Convert(string value) => value;
        }

        public class RealmObjectBaseRealmValueConverter : SpecializedConverterBase<RealmObjectBase, RealmValue>
        {
            public override RealmValue Convert(RealmObjectBase value) => value;
        }
        #endregion ToRealmValue Converters

        #region FromRealmValue Converters

        public class RealmValueCharConverter : SpecializedConverterBase<RealmValue, char>
        {
            public override char Convert(RealmValue value) => (char)value;
        }

        public class RealmValueByteConverter : SpecializedConverterBase<RealmValue, byte>
        {
            public override byte Convert(RealmValue value) => (byte)value;
        }

        public class RealmValueShortConverter : SpecializedConverterBase<RealmValue, short>
        {
            public override short Convert(RealmValue value) => (short)value;
        }

        public class RealmValueIntConverter : SpecializedConverterBase<RealmValue, int>
        {
            public override int Convert(RealmValue value) => (int)value;
        }

        public class RealmValueLongConverter : SpecializedConverterBase<RealmValue, long>
        {
            public override long Convert(RealmValue value) => (long)value;
        }

        public class RealmValueFloatConverter : SpecializedConverterBase<RealmValue, float>
        {
            public override float Convert(RealmValue value) => (float)value;
        }

        public class RealmValueDoubleConverter : SpecializedConverterBase<RealmValue, double>
        {
            public override double Convert(RealmValue value) => (double)value;
        }

        public class RealmValueBoolConverter : SpecializedConverterBase<RealmValue, bool>
        {
            public override bool Convert(RealmValue value) => (bool)value;
        }

        public class RealmValueDateTimeOffsetConverter : SpecializedConverterBase<RealmValue, DateTimeOffset>
        {
            public override DateTimeOffset Convert(RealmValue value) => (DateTimeOffset)value;
        }

        public class RealmValueDecimalConverter : SpecializedConverterBase<RealmValue, decimal>
        {
            public override decimal Convert(RealmValue value) => (decimal)value;
        }

        public class RealmValueDecimal128Converter : SpecializedConverterBase<RealmValue, Decimal128>
        {
            public override Decimal128 Convert(RealmValue value) => (Decimal128)value;
        }

        public class RealmValueObjectIdConverter : SpecializedConverterBase<RealmValue, ObjectId>
        {
            public override ObjectId Convert(RealmValue value) => (ObjectId)value;
        }

        public class RealmValueGuidConverter : SpecializedConverterBase<RealmValue, Guid>
        {
            public override Guid Convert(RealmValue value) => (Guid)value;
        }

        public class RealmValueNullableCharConverter : SpecializedConverterBase<RealmValue, char?>
        {
            public override char? Convert(RealmValue value) => (char?)value;
        }

        public class RealmValueNullableByteConverter : SpecializedConverterBase<RealmValue, byte?>
        {
            public override byte? Convert(RealmValue value) => (byte?)value;
        }

        public class RealmValueNullableShortConverter : SpecializedConverterBase<RealmValue, short?>
        {
            public override short? Convert(RealmValue value) => (short?)value;
        }

        public class RealmValueNullableIntConverter : SpecializedConverterBase<RealmValue, int?>
        {
            public override int? Convert(RealmValue value) => (int?)value;
        }

        public class RealmValueNullableLongConverter : SpecializedConverterBase<RealmValue, long?>
        {
            public override long? Convert(RealmValue value) => (long?)value;
        }

        public class RealmValueNullableFloatConverter : SpecializedConverterBase<RealmValue, float?>
        {
            public override float? Convert(RealmValue value) => (float?)value;
        }

        public class RealmValueNullableDoubleConverter : SpecializedConverterBase<RealmValue, double?>
        {
            public override double? Convert(RealmValue value) => (double?)value;
        }

        public class RealmValueNullableBoolConverter : SpecializedConverterBase<RealmValue, bool?>
        {
            public override bool? Convert(RealmValue value) => (bool?)value;
        }

        public class RealmValueNullableDateTimeOffsetConverter : SpecializedConverterBase<RealmValue, DateTimeOffset?>
        {
            public override DateTimeOffset? Convert(RealmValue value) => (DateTimeOffset?)value;
        }

        public class RealmValueNullableDecimalConverter : SpecializedConverterBase<RealmValue, decimal?>
        {
            public override decimal? Convert(RealmValue value) => (decimal?)value;
        }

        public class RealmValueNullableDecimal128Converter : SpecializedConverterBase<RealmValue, Decimal128?>
        {
            public override Decimal128? Convert(RealmValue value) => (Decimal128?)value;
        }

        public class RealmValueNullableObjectIdConverter : SpecializedConverterBase<RealmValue, ObjectId?>
        {
            public override ObjectId? Convert(RealmValue value) => (ObjectId?)value;
        }

        public class RealmValueNullableGuidConverter : SpecializedConverterBase<RealmValue, Guid?>
        {
            public override Guid? Convert(RealmValue value) => (Guid?)value;
        }

        public class RealmValueRealmIntegerByteConverter : SpecializedConverterBase<RealmValue, RealmInteger<byte>>
        {
            public override RealmInteger<byte> Convert(RealmValue value) => (RealmInteger<byte>)value;
        }

        public class RealmValueRealmIntegerShortConverter : SpecializedConverterBase<RealmValue, RealmInteger<short>>
        {
            public override RealmInteger<short> Convert(RealmValue value) => (RealmInteger<short>)value;
        }

        public class RealmValueRealmIntegerIntConverter : SpecializedConverterBase<RealmValue, RealmInteger<int>>
        {
            public override RealmInteger<int> Convert(RealmValue value) => (RealmInteger<int>)value;
        }

        public class RealmValueRealmIntegerLongConverter : SpecializedConverterBase<RealmValue, RealmInteger<long>>
        {
            public override RealmInteger<long> Convert(RealmValue value) => (RealmInteger<long>)value;
        }

        public class RealmValueNullableRealmIntegerByteConverter : SpecializedConverterBase<RealmValue, RealmInteger<byte>?>
        {
            public override RealmInteger<byte>? Convert(RealmValue value) => (RealmInteger<byte>?)value;
        }

        public class RealmValueNullableRealmIntegerShortConverter : SpecializedConverterBase<RealmValue, RealmInteger<short>?>
        {
            public override RealmInteger<short>? Convert(RealmValue value) => (RealmInteger<short>?)value;
        }

        public class RealmValueNullableRealmIntegerIntConverter : SpecializedConverterBase<RealmValue, RealmInteger<int>?>
        {
            public override RealmInteger<int>? Convert(RealmValue value) => (RealmInteger<int>?)value;
        }

        public class RealmValueNullableRealmIntegerLongConverter : SpecializedConverterBase<RealmValue, RealmInteger<long>?>
        {
            public override RealmInteger<long>? Convert(RealmValue value) => (RealmInteger<long>?)value;
        }

        public class RealmValueByteArrayConverter : SpecializedConverterBase<RealmValue, byte[]>
        {
            public override byte[] Convert(RealmValue value) => (byte[])value;
        }

        public class RealmValueStringConverter : SpecializedConverterBase<RealmValue, string>
        {
            public override string Convert(RealmValue value) => (string)value;
        }

        public class RealmValueRealmObjectBaseConverter : SpecializedConverterBase<RealmValue, RealmObjectBase>
        {
            public override RealmObjectBase Convert(RealmValue value) => (RealmObjectBase)value;
        }
        #endregion FromRealmValue Converters

        #region Integral Converters

        public class CharNullableCharConverter : SpecializedConverterBase<char, char?>
        {
            public override char? Convert(char value) => value;
        }

        public class CharNullableByteConverter : SpecializedConverterBase<char, byte?>
        {
            public override byte? Convert(char value) => (byte)value;
        }

        public class CharNullableShortConverter : SpecializedConverterBase<char, short?>
        {
            public override short? Convert(char value) => (short)value;
        }

        public class CharNullableIntConverter : SpecializedConverterBase<char, int?>
        {
            public override int? Convert(char value) => value;
        }

        public class CharNullableLongConverter : SpecializedConverterBase<char, long?>
        {
            public override long? Convert(char value) => value;
        }

        public class CharNullableRealmIntegerByteConverter : SpecializedConverterBase<char, RealmInteger<byte>?>
        {
            public override RealmInteger<byte>? Convert(char value) => (byte)value;
        }

        public class CharNullableRealmIntegerShortConverter : SpecializedConverterBase<char, RealmInteger<short>?>
        {
            public override RealmInteger<short>? Convert(char value) => (short)value;
        }

        public class CharNullableRealmIntegerIntConverter : SpecializedConverterBase<char, RealmInteger<int>?>
        {
            public override RealmInteger<int>? Convert(char value) => value;
        }

        public class CharNullableRealmIntegerLongConverter : SpecializedConverterBase<char, RealmInteger<long>?>
        {
            public override RealmInteger<long>? Convert(char value) => value;
        }

        public class CharNullableFloatConverter : SpecializedConverterBase<char, float?>
        {
            public override float? Convert(char value) => value;
        }

        public class CharNullableDoubleConverter : SpecializedConverterBase<char, double?>
        {
            public override double? Convert(char value) => value;
        }

        public class CharNullableDecimalConverter : SpecializedConverterBase<char, decimal?>
        {
            public override decimal? Convert(char value) => value;
        }

        public class CharNullableDecimal128Converter : SpecializedConverterBase<char, Decimal128?>
        {
            public override Decimal128? Convert(char value) => value;
        }

        public class ByteNullableCharConverter : SpecializedConverterBase<byte, char?>
        {
            public override char? Convert(byte value) => (char)value;
        }

        public class ByteNullableByteConverter : SpecializedConverterBase<byte, byte?>
        {
            public override byte? Convert(byte value) => value;
        }

        public class ByteNullableShortConverter : SpecializedConverterBase<byte, short?>
        {
            public override short? Convert(byte value) => value;
        }

        public class ByteNullableIntConverter : SpecializedConverterBase<byte, int?>
        {
            public override int? Convert(byte value) => value;
        }

        public class ByteNullableLongConverter : SpecializedConverterBase<byte, long?>
        {
            public override long? Convert(byte value) => value;
        }

        public class ByteNullableRealmIntegerByteConverter : SpecializedConverterBase<byte, RealmInteger<byte>?>
        {
            public override RealmInteger<byte>? Convert(byte value) => value;
        }

        public class ByteNullableRealmIntegerShortConverter : SpecializedConverterBase<byte, RealmInteger<short>?>
        {
            public override RealmInteger<short>? Convert(byte value) => value;
        }

        public class ByteNullableRealmIntegerIntConverter : SpecializedConverterBase<byte, RealmInteger<int>?>
        {
            public override RealmInteger<int>? Convert(byte value) => value;
        }

        public class ByteNullableRealmIntegerLongConverter : SpecializedConverterBase<byte, RealmInteger<long>?>
        {
            public override RealmInteger<long>? Convert(byte value) => value;
        }

        public class ByteNullableFloatConverter : SpecializedConverterBase<byte, float?>
        {
            public override float? Convert(byte value) => value;
        }

        public class ByteNullableDoubleConverter : SpecializedConverterBase<byte, double?>
        {
            public override double? Convert(byte value) => value;
        }

        public class ByteNullableDecimalConverter : SpecializedConverterBase<byte, decimal?>
        {
            public override decimal? Convert(byte value) => value;
        }

        public class ByteNullableDecimal128Converter : SpecializedConverterBase<byte, Decimal128?>
        {
            public override Decimal128? Convert(byte value) => value;
        }

        public class ShortNullableCharConverter : SpecializedConverterBase<short, char?>
        {
            public override char? Convert(short value) => (char)value;
        }

        public class ShortNullableByteConverter : SpecializedConverterBase<short, byte?>
        {
            public override byte? Convert(short value) => (byte)value;
        }

        public class ShortNullableShortConverter : SpecializedConverterBase<short, short?>
        {
            public override short? Convert(short value) => value;
        }

        public class ShortNullableIntConverter : SpecializedConverterBase<short, int?>
        {
            public override int? Convert(short value) => value;
        }

        public class ShortNullableLongConverter : SpecializedConverterBase<short, long?>
        {
            public override long? Convert(short value) => value;
        }

        public class ShortNullableRealmIntegerByteConverter : SpecializedConverterBase<short, RealmInteger<byte>?>
        {
            public override RealmInteger<byte>? Convert(short value) => (byte)value;
        }

        public class ShortNullableRealmIntegerShortConverter : SpecializedConverterBase<short, RealmInteger<short>?>
        {
            public override RealmInteger<short>? Convert(short value) => value;
        }

        public class ShortNullableRealmIntegerIntConverter : SpecializedConverterBase<short, RealmInteger<int>?>
        {
            public override RealmInteger<int>? Convert(short value) => value;
        }

        public class ShortNullableRealmIntegerLongConverter : SpecializedConverterBase<short, RealmInteger<long>?>
        {
            public override RealmInteger<long>? Convert(short value) => value;
        }

        public class ShortNullableFloatConverter : SpecializedConverterBase<short, float?>
        {
            public override float? Convert(short value) => value;
        }

        public class ShortNullableDoubleConverter : SpecializedConverterBase<short, double?>
        {
            public override double? Convert(short value) => value;
        }

        public class ShortNullableDecimalConverter : SpecializedConverterBase<short, decimal?>
        {
            public override decimal? Convert(short value) => value;
        }

        public class ShortNullableDecimal128Converter : SpecializedConverterBase<short, Decimal128?>
        {
            public override Decimal128? Convert(short value) => value;
        }

        public class IntNullableCharConverter : SpecializedConverterBase<int, char?>
        {
            public override char? Convert(int value) => (char)value;
        }

        public class IntNullableByteConverter : SpecializedConverterBase<int, byte?>
        {
            public override byte? Convert(int value) => (byte)value;
        }

        public class IntNullableShortConverter : SpecializedConverterBase<int, short?>
        {
            public override short? Convert(int value) => (short)value;
        }

        public class IntNullableIntConverter : SpecializedConverterBase<int, int?>
        {
            public override int? Convert(int value) => value;
        }

        public class IntNullableLongConverter : SpecializedConverterBase<int, long?>
        {
            public override long? Convert(int value) => value;
        }

        public class IntNullableRealmIntegerByteConverter : SpecializedConverterBase<int, RealmInteger<byte>?>
        {
            public override RealmInteger<byte>? Convert(int value) => (byte)value;
        }

        public class IntNullableRealmIntegerShortConverter : SpecializedConverterBase<int, RealmInteger<short>?>
        {
            public override RealmInteger<short>? Convert(int value) => (short)value;
        }

        public class IntNullableRealmIntegerIntConverter : SpecializedConverterBase<int, RealmInteger<int>?>
        {
            public override RealmInteger<int>? Convert(int value) => value;
        }

        public class IntNullableRealmIntegerLongConverter : SpecializedConverterBase<int, RealmInteger<long>?>
        {
            public override RealmInteger<long>? Convert(int value) => value;
        }

        public class IntNullableFloatConverter : SpecializedConverterBase<int, float?>
        {
            public override float? Convert(int value) => value;
        }

        public class IntNullableDoubleConverter : SpecializedConverterBase<int, double?>
        {
            public override double? Convert(int value) => value;
        }

        public class IntNullableDecimalConverter : SpecializedConverterBase<int, decimal?>
        {
            public override decimal? Convert(int value) => value;
        }

        public class IntNullableDecimal128Converter : SpecializedConverterBase<int, Decimal128?>
        {
            public override Decimal128? Convert(int value) => value;
        }

        public class LongNullableCharConverter : SpecializedConverterBase<long, char?>
        {
            public override char? Convert(long value) => (char)value;
        }

        public class LongNullableByteConverter : SpecializedConverterBase<long, byte?>
        {
            public override byte? Convert(long value) => (byte)value;
        }

        public class LongNullableShortConverter : SpecializedConverterBase<long, short?>
        {
            public override short? Convert(long value) => (short)value;
        }

        public class LongNullableIntConverter : SpecializedConverterBase<long, int?>
        {
            public override int? Convert(long value) => (int)value;
        }

        public class LongNullableLongConverter : SpecializedConverterBase<long, long?>
        {
            public override long? Convert(long value) => value;
        }

        public class LongNullableRealmIntegerByteConverter : SpecializedConverterBase<long, RealmInteger<byte>?>
        {
            public override RealmInteger<byte>? Convert(long value) => (byte)value;
        }

        public class LongNullableRealmIntegerShortConverter : SpecializedConverterBase<long, RealmInteger<short>?>
        {
            public override RealmInteger<short>? Convert(long value) => (short)value;
        }

        public class LongNullableRealmIntegerIntConverter : SpecializedConverterBase<long, RealmInteger<int>?>
        {
            public override RealmInteger<int>? Convert(long value) => (int)value;
        }

        public class LongNullableRealmIntegerLongConverter : SpecializedConverterBase<long, RealmInteger<long>?>
        {
            public override RealmInteger<long>? Convert(long value) => value;
        }

        public class LongNullableFloatConverter : SpecializedConverterBase<long, float?>
        {
            public override float? Convert(long value) => value;
        }

        public class LongNullableDoubleConverter : SpecializedConverterBase<long, double?>
        {
            public override double? Convert(long value) => value;
        }

        public class LongNullableDecimalConverter : SpecializedConverterBase<long, decimal?>
        {
            public override decimal? Convert(long value) => value;
        }

        public class LongNullableDecimal128Converter : SpecializedConverterBase<long, Decimal128?>
        {
            public override Decimal128? Convert(long value) => value;
        }

        public class RealmIntegerByteNullableCharConverter : SpecializedConverterBase<RealmInteger<byte>, char?>
        {
            public override char? Convert(RealmInteger<byte> value) => (char)(byte)value;
        }

        public class RealmIntegerByteNullableByteConverter : SpecializedConverterBase<RealmInteger<byte>, byte?>
        {
            public override byte? Convert(RealmInteger<byte> value) => value;
        }

        public class RealmIntegerByteNullableShortConverter : SpecializedConverterBase<RealmInteger<byte>, short?>
        {
            public override short? Convert(RealmInteger<byte> value) => value;
        }

        public class RealmIntegerByteNullableIntConverter : SpecializedConverterBase<RealmInteger<byte>, int?>
        {
            public override int? Convert(RealmInteger<byte> value) => value;
        }

        public class RealmIntegerByteNullableLongConverter : SpecializedConverterBase<RealmInteger<byte>, long?>
        {
            public override long? Convert(RealmInteger<byte> value) => value;
        }

        public class RealmIntegerByteNullableRealmIntegerByteConverter : SpecializedConverterBase<RealmInteger<byte>, RealmInteger<byte>?>
        {
            public override RealmInteger<byte>? Convert(RealmInteger<byte> value) => value;
        }

        public class RealmIntegerByteNullableRealmIntegerShortConverter : SpecializedConverterBase<RealmInteger<byte>, RealmInteger<short>?>
        {
            public override RealmInteger<short>? Convert(RealmInteger<byte> value) => (short)value;
        }

        public class RealmIntegerByteNullableRealmIntegerIntConverter : SpecializedConverterBase<RealmInteger<byte>, RealmInteger<int>?>
        {
            public override RealmInteger<int>? Convert(RealmInteger<byte> value) => (int)value;
        }

        public class RealmIntegerByteNullableRealmIntegerLongConverter : SpecializedConverterBase<RealmInteger<byte>, RealmInteger<long>?>
        {
            public override RealmInteger<long>? Convert(RealmInteger<byte> value) => (long)value;
        }

        public class RealmIntegerByteNullableFloatConverter : SpecializedConverterBase<RealmInteger<byte>, float?>
        {
            public override float? Convert(RealmInteger<byte> value) => value;
        }

        public class RealmIntegerByteNullableDoubleConverter : SpecializedConverterBase<RealmInteger<byte>, double?>
        {
            public override double? Convert(RealmInteger<byte> value) => value;
        }

        public class RealmIntegerByteNullableDecimalConverter : SpecializedConverterBase<RealmInteger<byte>, decimal?>
        {
            public override decimal? Convert(RealmInteger<byte> value) => value;
        }

        public class RealmIntegerByteNullableDecimal128Converter : SpecializedConverterBase<RealmInteger<byte>, Decimal128?>
        {
            public override Decimal128? Convert(RealmInteger<byte> value) => (byte)value;
        }

        public class RealmIntegerShortNullableCharConverter : SpecializedConverterBase<RealmInteger<short>, char?>
        {
            public override char? Convert(RealmInteger<short> value) => (char)(short)value;
        }

        public class RealmIntegerShortNullableByteConverter : SpecializedConverterBase<RealmInteger<short>, byte?>
        {
            public override byte? Convert(RealmInteger<short> value) => (byte)value;
        }

        public class RealmIntegerShortNullableShortConverter : SpecializedConverterBase<RealmInteger<short>, short?>
        {
            public override short? Convert(RealmInteger<short> value) => value;
        }

        public class RealmIntegerShortNullableIntConverter : SpecializedConverterBase<RealmInteger<short>, int?>
        {
            public override int? Convert(RealmInteger<short> value) => value;
        }

        public class RealmIntegerShortNullableLongConverter : SpecializedConverterBase<RealmInteger<short>, long?>
        {
            public override long? Convert(RealmInteger<short> value) => value;
        }

        public class RealmIntegerShortNullableRealmIntegerByteConverter : SpecializedConverterBase<RealmInteger<short>, RealmInteger<byte>?>
        {
            public override RealmInteger<byte>? Convert(RealmInteger<short> value) => (byte)value;
        }

        public class RealmIntegerShortNullableRealmIntegerShortConverter : SpecializedConverterBase<RealmInteger<short>, RealmInteger<short>?>
        {
            public override RealmInteger<short>? Convert(RealmInteger<short> value) => value;
        }

        public class RealmIntegerShortNullableRealmIntegerIntConverter : SpecializedConverterBase<RealmInteger<short>, RealmInteger<int>?>
        {
            public override RealmInteger<int>? Convert(RealmInteger<short> value) => (int)value;
        }

        public class RealmIntegerShortNullableRealmIntegerLongConverter : SpecializedConverterBase<RealmInteger<short>, RealmInteger<long>?>
        {
            public override RealmInteger<long>? Convert(RealmInteger<short> value) => (long)value;
        }

        public class RealmIntegerShortNullableFloatConverter : SpecializedConverterBase<RealmInteger<short>, float?>
        {
            public override float? Convert(RealmInteger<short> value) => value;
        }

        public class RealmIntegerShortNullableDoubleConverter : SpecializedConverterBase<RealmInteger<short>, double?>
        {
            public override double? Convert(RealmInteger<short> value) => value;
        }

        public class RealmIntegerShortNullableDecimalConverter : SpecializedConverterBase<RealmInteger<short>, decimal?>
        {
            public override decimal? Convert(RealmInteger<short> value) => value;
        }

        public class RealmIntegerShortNullableDecimal128Converter : SpecializedConverterBase<RealmInteger<short>, Decimal128?>
        {
            public override Decimal128? Convert(RealmInteger<short> value) => (short)value;
        }

        public class RealmIntegerIntNullableCharConverter : SpecializedConverterBase<RealmInteger<int>, char?>
        {
            public override char? Convert(RealmInteger<int> value) => (char)value;
        }

        public class RealmIntegerIntNullableByteConverter : SpecializedConverterBase<RealmInteger<int>, byte?>
        {
            public override byte? Convert(RealmInteger<int> value) => (byte)value;
        }

        public class RealmIntegerIntNullableShortConverter : SpecializedConverterBase<RealmInteger<int>, short?>
        {
            public override short? Convert(RealmInteger<int> value) => (short)value;
        }

        public class RealmIntegerIntNullableIntConverter : SpecializedConverterBase<RealmInteger<int>, int?>
        {
            public override int? Convert(RealmInteger<int> value) => value;
        }

        public class RealmIntegerIntNullableLongConverter : SpecializedConverterBase<RealmInteger<int>, long?>
        {
            public override long? Convert(RealmInteger<int> value) => value;
        }

        public class RealmIntegerIntNullableRealmIntegerByteConverter : SpecializedConverterBase<RealmInteger<int>, RealmInteger<byte>?>
        {
            public override RealmInteger<byte>? Convert(RealmInteger<int> value) => (byte)value;
        }

        public class RealmIntegerIntNullableRealmIntegerShortConverter : SpecializedConverterBase<RealmInteger<int>, RealmInteger<short>?>
        {
            public override RealmInteger<short>? Convert(RealmInteger<int> value) => (short)value;
        }

        public class RealmIntegerIntNullableRealmIntegerIntConverter : SpecializedConverterBase<RealmInteger<int>, RealmInteger<int>?>
        {
            public override RealmInteger<int>? Convert(RealmInteger<int> value) => value;
        }

        public class RealmIntegerIntNullableRealmIntegerLongConverter : SpecializedConverterBase<RealmInteger<int>, RealmInteger<long>?>
        {
            public override RealmInteger<long>? Convert(RealmInteger<int> value) => (long)value;
        }

        public class RealmIntegerIntNullableFloatConverter : SpecializedConverterBase<RealmInteger<int>, float?>
        {
            public override float? Convert(RealmInteger<int> value) => value;
        }

        public class RealmIntegerIntNullableDoubleConverter : SpecializedConverterBase<RealmInteger<int>, double?>
        {
            public override double? Convert(RealmInteger<int> value) => value;
        }

        public class RealmIntegerIntNullableDecimalConverter : SpecializedConverterBase<RealmInteger<int>, decimal?>
        {
            public override decimal? Convert(RealmInteger<int> value) => value;
        }

        public class RealmIntegerIntNullableDecimal128Converter : SpecializedConverterBase<RealmInteger<int>, Decimal128?>
        {
            public override Decimal128? Convert(RealmInteger<int> value) => (int)value;
        }

        public class RealmIntegerLongNullableCharConverter : SpecializedConverterBase<RealmInteger<long>, char?>
        {
            public override char? Convert(RealmInteger<long> value) => (char)value;
        }

        public class RealmIntegerLongNullableByteConverter : SpecializedConverterBase<RealmInteger<long>, byte?>
        {
            public override byte? Convert(RealmInteger<long> value) => (byte)value;
        }

        public class RealmIntegerLongNullableShortConverter : SpecializedConverterBase<RealmInteger<long>, short?>
        {
            public override short? Convert(RealmInteger<long> value) => (short)value;
        }

        public class RealmIntegerLongNullableIntConverter : SpecializedConverterBase<RealmInteger<long>, int?>
        {
            public override int? Convert(RealmInteger<long> value) => (int)value;
        }

        public class RealmIntegerLongNullableLongConverter : SpecializedConverterBase<RealmInteger<long>, long?>
        {
            public override long? Convert(RealmInteger<long> value) => value;
        }

        public class RealmIntegerLongNullableRealmIntegerByteConverter : SpecializedConverterBase<RealmInteger<long>, RealmInteger<byte>?>
        {
            public override RealmInteger<byte>? Convert(RealmInteger<long> value) => (byte)value;
        }

        public class RealmIntegerLongNullableRealmIntegerShortConverter : SpecializedConverterBase<RealmInteger<long>, RealmInteger<short>?>
        {
            public override RealmInteger<short>? Convert(RealmInteger<long> value) => (short)value;
        }

        public class RealmIntegerLongNullableRealmIntegerIntConverter : SpecializedConverterBase<RealmInteger<long>, RealmInteger<int>?>
        {
            public override RealmInteger<int>? Convert(RealmInteger<long> value) => (int)value;
        }

        public class RealmIntegerLongNullableRealmIntegerLongConverter : SpecializedConverterBase<RealmInteger<long>, RealmInteger<long>?>
        {
            public override RealmInteger<long>? Convert(RealmInteger<long> value) => value;
        }

        public class RealmIntegerLongNullableFloatConverter : SpecializedConverterBase<RealmInteger<long>, float?>
        {
            public override float? Convert(RealmInteger<long> value) => value;
        }

        public class RealmIntegerLongNullableDoubleConverter : SpecializedConverterBase<RealmInteger<long>, double?>
        {
            public override double? Convert(RealmInteger<long> value) => value;
        }

        public class RealmIntegerLongNullableDecimalConverter : SpecializedConverterBase<RealmInteger<long>, decimal?>
        {
            public override decimal? Convert(RealmInteger<long> value) => value;
        }

        public class RealmIntegerLongNullableDecimal128Converter : SpecializedConverterBase<RealmInteger<long>, Decimal128?>
        {
            public override Decimal128? Convert(RealmInteger<long> value) => (long)value;
        }

        public class CharByteConverter : SpecializedConverterBase<char, byte>
        {
            public override byte Convert(char value) => (byte)value;
        }

        public class CharShortConverter : SpecializedConverterBase<char, short>
        {
            public override short Convert(char value) => (short)value;
        }

        public class CharIntConverter : SpecializedConverterBase<char, int>
        {
            public override int Convert(char value) => value;
        }

        public class CharLongConverter : SpecializedConverterBase<char, long>
        {
            public override long Convert(char value) => value;
        }

        public class CharRealmIntegerByteConverter : SpecializedConverterBase<char, RealmInteger<byte>>
        {
            public override RealmInteger<byte> Convert(char value) => (byte)value;
        }

        public class CharRealmIntegerShortConverter : SpecializedConverterBase<char, RealmInteger<short>>
        {
            public override RealmInteger<short> Convert(char value) => (short)value;
        }

        public class CharRealmIntegerIntConverter : SpecializedConverterBase<char, RealmInteger<int>>
        {
            public override RealmInteger<int> Convert(char value) => value;
        }

        public class CharRealmIntegerLongConverter : SpecializedConverterBase<char, RealmInteger<long>>
        {
            public override RealmInteger<long> Convert(char value) => value;
        }

        public class CharFloatConverter : SpecializedConverterBase<char, float>
        {
            public override float Convert(char value) => value;
        }

        public class CharDoubleConverter : SpecializedConverterBase<char, double>
        {
            public override double Convert(char value) => value;
        }

        public class CharDecimalConverter : SpecializedConverterBase<char, decimal>
        {
            public override decimal Convert(char value) => value;
        }

        public class CharDecimal128Converter : SpecializedConverterBase<char, Decimal128>
        {
            public override Decimal128 Convert(char value) => value;
        }

        public class ByteCharConverter : SpecializedConverterBase<byte, char>
        {
            public override char Convert(byte value) => (char)value;
        }

        public class ByteShortConverter : SpecializedConverterBase<byte, short>
        {
            public override short Convert(byte value) => value;
        }

        public class ByteIntConverter : SpecializedConverterBase<byte, int>
        {
            public override int Convert(byte value) => value;
        }

        public class ByteLongConverter : SpecializedConverterBase<byte, long>
        {
            public override long Convert(byte value) => value;
        }

        public class ByteRealmIntegerByteConverter : SpecializedConverterBase<byte, RealmInteger<byte>>
        {
            public override RealmInteger<byte> Convert(byte value) => value;
        }

        public class ByteRealmIntegerShortConverter : SpecializedConverterBase<byte, RealmInteger<short>>
        {
            public override RealmInteger<short> Convert(byte value) => value;
        }

        public class ByteRealmIntegerIntConverter : SpecializedConverterBase<byte, RealmInteger<int>>
        {
            public override RealmInteger<int> Convert(byte value) => value;
        }

        public class ByteRealmIntegerLongConverter : SpecializedConverterBase<byte, RealmInteger<long>>
        {
            public override RealmInteger<long> Convert(byte value) => value;
        }

        public class ByteFloatConverter : SpecializedConverterBase<byte, float>
        {
            public override float Convert(byte value) => value;
        }

        public class ByteDoubleConverter : SpecializedConverterBase<byte, double>
        {
            public override double Convert(byte value) => value;
        }

        public class ByteDecimalConverter : SpecializedConverterBase<byte, decimal>
        {
            public override decimal Convert(byte value) => value;
        }

        public class ByteDecimal128Converter : SpecializedConverterBase<byte, Decimal128>
        {
            public override Decimal128 Convert(byte value) => value;
        }

        public class ShortCharConverter : SpecializedConverterBase<short, char>
        {
            public override char Convert(short value) => (char)value;
        }

        public class ShortByteConverter : SpecializedConverterBase<short, byte>
        {
            public override byte Convert(short value) => (byte)value;
        }

        public class ShortIntConverter : SpecializedConverterBase<short, int>
        {
            public override int Convert(short value) => value;
        }

        public class ShortLongConverter : SpecializedConverterBase<short, long>
        {
            public override long Convert(short value) => value;
        }

        public class ShortRealmIntegerByteConverter : SpecializedConverterBase<short, RealmInteger<byte>>
        {
            public override RealmInteger<byte> Convert(short value) => (byte)value;
        }

        public class ShortRealmIntegerShortConverter : SpecializedConverterBase<short, RealmInteger<short>>
        {
            public override RealmInteger<short> Convert(short value) => value;
        }

        public class ShortRealmIntegerIntConverter : SpecializedConverterBase<short, RealmInteger<int>>
        {
            public override RealmInteger<int> Convert(short value) => value;
        }

        public class ShortRealmIntegerLongConverter : SpecializedConverterBase<short, RealmInteger<long>>
        {
            public override RealmInteger<long> Convert(short value) => value;
        }

        public class ShortFloatConverter : SpecializedConverterBase<short, float>
        {
            public override float Convert(short value) => value;
        }

        public class ShortDoubleConverter : SpecializedConverterBase<short, double>
        {
            public override double Convert(short value) => value;
        }

        public class ShortDecimalConverter : SpecializedConverterBase<short, decimal>
        {
            public override decimal Convert(short value) => value;
        }

        public class ShortDecimal128Converter : SpecializedConverterBase<short, Decimal128>
        {
            public override Decimal128 Convert(short value) => value;
        }

        public class IntCharConverter : SpecializedConverterBase<int, char>
        {
            public override char Convert(int value) => (char)value;
        }

        public class IntByteConverter : SpecializedConverterBase<int, byte>
        {
            public override byte Convert(int value) => (byte)value;
        }

        public class IntShortConverter : SpecializedConverterBase<int, short>
        {
            public override short Convert(int value) => (short)value;
        }

        public class IntLongConverter : SpecializedConverterBase<int, long>
        {
            public override long Convert(int value) => value;
        }

        public class IntRealmIntegerByteConverter : SpecializedConverterBase<int, RealmInteger<byte>>
        {
            public override RealmInteger<byte> Convert(int value) => (byte)value;
        }

        public class IntRealmIntegerShortConverter : SpecializedConverterBase<int, RealmInteger<short>>
        {
            public override RealmInteger<short> Convert(int value) => (short)value;
        }

        public class IntRealmIntegerIntConverter : SpecializedConverterBase<int, RealmInteger<int>>
        {
            public override RealmInteger<int> Convert(int value) => value;
        }

        public class IntRealmIntegerLongConverter : SpecializedConverterBase<int, RealmInteger<long>>
        {
            public override RealmInteger<long> Convert(int value) => value;
        }

        public class IntFloatConverter : SpecializedConverterBase<int, float>
        {
            public override float Convert(int value) => value;
        }

        public class IntDoubleConverter : SpecializedConverterBase<int, double>
        {
            public override double Convert(int value) => value;
        }

        public class IntDecimalConverter : SpecializedConverterBase<int, decimal>
        {
            public override decimal Convert(int value) => value;
        }

        public class IntDecimal128Converter : SpecializedConverterBase<int, Decimal128>
        {
            public override Decimal128 Convert(int value) => value;
        }

        public class LongCharConverter : SpecializedConverterBase<long, char>
        {
            public override char Convert(long value) => (char)value;
        }

        public class LongByteConverter : SpecializedConverterBase<long, byte>
        {
            public override byte Convert(long value) => (byte)value;
        }

        public class LongShortConverter : SpecializedConverterBase<long, short>
        {
            public override short Convert(long value) => (short)value;
        }

        public class LongIntConverter : SpecializedConverterBase<long, int>
        {
            public override int Convert(long value) => (int)value;
        }

        public class LongRealmIntegerByteConverter : SpecializedConverterBase<long, RealmInteger<byte>>
        {
            public override RealmInteger<byte> Convert(long value) => (byte)value;
        }

        public class LongRealmIntegerShortConverter : SpecializedConverterBase<long, RealmInteger<short>>
        {
            public override RealmInteger<short> Convert(long value) => (short)value;
        }

        public class LongRealmIntegerIntConverter : SpecializedConverterBase<long, RealmInteger<int>>
        {
            public override RealmInteger<int> Convert(long value) => (int)value;
        }

        public class LongRealmIntegerLongConverter : SpecializedConverterBase<long, RealmInteger<long>>
        {
            public override RealmInteger<long> Convert(long value) => value;
        }

        public class LongFloatConverter : SpecializedConverterBase<long, float>
        {
            public override float Convert(long value) => value;
        }

        public class LongDoubleConverter : SpecializedConverterBase<long, double>
        {
            public override double Convert(long value) => value;
        }

        public class LongDecimalConverter : SpecializedConverterBase<long, decimal>
        {
            public override decimal Convert(long value) => value;
        }

        public class LongDecimal128Converter : SpecializedConverterBase<long, Decimal128>
        {
            public override Decimal128 Convert(long value) => value;
        }

        public class RealmIntegerByteCharConverter : SpecializedConverterBase<RealmInteger<byte>, char>
        {
            public override char Convert(RealmInteger<byte> value) => (char)(byte)value;
        }

        public class RealmIntegerByteByteConverter : SpecializedConverterBase<RealmInteger<byte>, byte>
        {
            public override byte Convert(RealmInteger<byte> value) => value;
        }

        public class RealmIntegerByteShortConverter : SpecializedConverterBase<RealmInteger<byte>, short>
        {
            public override short Convert(RealmInteger<byte> value) => value;
        }

        public class RealmIntegerByteIntConverter : SpecializedConverterBase<RealmInteger<byte>, int>
        {
            public override int Convert(RealmInteger<byte> value) => value;
        }

        public class RealmIntegerByteLongConverter : SpecializedConverterBase<RealmInteger<byte>, long>
        {
            public override long Convert(RealmInteger<byte> value) => value;
        }

        public class RealmIntegerByteRealmIntegerShortConverter : SpecializedConverterBase<RealmInteger<byte>, RealmInteger<short>>
        {
            public override RealmInteger<short> Convert(RealmInteger<byte> value) => (short)value;
        }

        public class RealmIntegerByteRealmIntegerIntConverter : SpecializedConverterBase<RealmInteger<byte>, RealmInteger<int>>
        {
            public override RealmInteger<int> Convert(RealmInteger<byte> value) => (int)value;
        }

        public class RealmIntegerByteRealmIntegerLongConverter : SpecializedConverterBase<RealmInteger<byte>, RealmInteger<long>>
        {
            public override RealmInteger<long> Convert(RealmInteger<byte> value) => (long)value;
        }

        public class RealmIntegerByteFloatConverter : SpecializedConverterBase<RealmInteger<byte>, float>
        {
            public override float Convert(RealmInteger<byte> value) => value;
        }

        public class RealmIntegerByteDoubleConverter : SpecializedConverterBase<RealmInteger<byte>, double>
        {
            public override double Convert(RealmInteger<byte> value) => value;
        }

        public class RealmIntegerByteDecimalConverter : SpecializedConverterBase<RealmInteger<byte>, decimal>
        {
            public override decimal Convert(RealmInteger<byte> value) => value;
        }

        public class RealmIntegerByteDecimal128Converter : SpecializedConverterBase<RealmInteger<byte>, Decimal128>
        {
            public override Decimal128 Convert(RealmInteger<byte> value) => (byte)value;
        }

        public class RealmIntegerShortCharConverter : SpecializedConverterBase<RealmInteger<short>, char>
        {
            public override char Convert(RealmInteger<short> value) => (char)(short)value;
        }

        public class RealmIntegerShortByteConverter : SpecializedConverterBase<RealmInteger<short>, byte>
        {
            public override byte Convert(RealmInteger<short> value) => (byte)value;
        }

        public class RealmIntegerShortShortConverter : SpecializedConverterBase<RealmInteger<short>, short>
        {
            public override short Convert(RealmInteger<short> value) => value;
        }

        public class RealmIntegerShortIntConverter : SpecializedConverterBase<RealmInteger<short>, int>
        {
            public override int Convert(RealmInteger<short> value) => value;
        }

        public class RealmIntegerShortLongConverter : SpecializedConverterBase<RealmInteger<short>, long>
        {
            public override long Convert(RealmInteger<short> value) => value;
        }

        public class RealmIntegerShortRealmIntegerByteConverter : SpecializedConverterBase<RealmInteger<short>, RealmInteger<byte>>
        {
            public override RealmInteger<byte> Convert(RealmInteger<short> value) => (byte)value;
        }

        public class RealmIntegerShortRealmIntegerIntConverter : SpecializedConverterBase<RealmInteger<short>, RealmInteger<int>>
        {
            public override RealmInteger<int> Convert(RealmInteger<short> value) => (int)value;
        }

        public class RealmIntegerShortRealmIntegerLongConverter : SpecializedConverterBase<RealmInteger<short>, RealmInteger<long>>
        {
            public override RealmInteger<long> Convert(RealmInteger<short> value) => (long)value;
        }

        public class RealmIntegerShortFloatConverter : SpecializedConverterBase<RealmInteger<short>, float>
        {
            public override float Convert(RealmInteger<short> value) => value;
        }

        public class RealmIntegerShortDoubleConverter : SpecializedConverterBase<RealmInteger<short>, double>
        {
            public override double Convert(RealmInteger<short> value) => value;
        }

        public class RealmIntegerShortDecimalConverter : SpecializedConverterBase<RealmInteger<short>, decimal>
        {
            public override decimal Convert(RealmInteger<short> value) => value;
        }

        public class RealmIntegerShortDecimal128Converter : SpecializedConverterBase<RealmInteger<short>, Decimal128>
        {
            public override Decimal128 Convert(RealmInteger<short> value) => (short)value;
        }

        public class RealmIntegerIntCharConverter : SpecializedConverterBase<RealmInteger<int>, char>
        {
            public override char Convert(RealmInteger<int> value) => (char)value;
        }

        public class RealmIntegerIntByteConverter : SpecializedConverterBase<RealmInteger<int>, byte>
        {
            public override byte Convert(RealmInteger<int> value) => (byte)value;
        }

        public class RealmIntegerIntShortConverter : SpecializedConverterBase<RealmInteger<int>, short>
        {
            public override short Convert(RealmInteger<int> value) => (short)value;
        }

        public class RealmIntegerIntIntConverter : SpecializedConverterBase<RealmInteger<int>, int>
        {
            public override int Convert(RealmInteger<int> value) => value;
        }

        public class RealmIntegerIntLongConverter : SpecializedConverterBase<RealmInteger<int>, long>
        {
            public override long Convert(RealmInteger<int> value) => value;
        }

        public class RealmIntegerIntRealmIntegerByteConverter : SpecializedConverterBase<RealmInteger<int>, RealmInteger<byte>>
        {
            public override RealmInteger<byte> Convert(RealmInteger<int> value) => (byte)value;
        }

        public class RealmIntegerIntRealmIntegerShortConverter : SpecializedConverterBase<RealmInteger<int>, RealmInteger<short>>
        {
            public override RealmInteger<short> Convert(RealmInteger<int> value) => (short)value;
        }

        public class RealmIntegerIntRealmIntegerLongConverter : SpecializedConverterBase<RealmInteger<int>, RealmInteger<long>>
        {
            public override RealmInteger<long> Convert(RealmInteger<int> value) => (long)value;
        }

        public class RealmIntegerIntFloatConverter : SpecializedConverterBase<RealmInteger<int>, float>
        {
            public override float Convert(RealmInteger<int> value) => value;
        }

        public class RealmIntegerIntDoubleConverter : SpecializedConverterBase<RealmInteger<int>, double>
        {
            public override double Convert(RealmInteger<int> value) => value;
        }

        public class RealmIntegerIntDecimalConverter : SpecializedConverterBase<RealmInteger<int>, decimal>
        {
            public override decimal Convert(RealmInteger<int> value) => value;
        }

        public class RealmIntegerIntDecimal128Converter : SpecializedConverterBase<RealmInteger<int>, Decimal128>
        {
            public override Decimal128 Convert(RealmInteger<int> value) => (int)value;
        }

        public class RealmIntegerLongCharConverter : SpecializedConverterBase<RealmInteger<long>, char>
        {
            public override char Convert(RealmInteger<long> value) => (char)value;
        }

        public class RealmIntegerLongByteConverter : SpecializedConverterBase<RealmInteger<long>, byte>
        {
            public override byte Convert(RealmInteger<long> value) => (byte)value;
        }

        public class RealmIntegerLongShortConverter : SpecializedConverterBase<RealmInteger<long>, short>
        {
            public override short Convert(RealmInteger<long> value) => (short)value;
        }

        public class RealmIntegerLongIntConverter : SpecializedConverterBase<RealmInteger<long>, int>
        {
            public override int Convert(RealmInteger<long> value) => (int)value;
        }

        public class RealmIntegerLongLongConverter : SpecializedConverterBase<RealmInteger<long>, long>
        {
            public override long Convert(RealmInteger<long> value) => value;
        }

        public class RealmIntegerLongRealmIntegerByteConverter : SpecializedConverterBase<RealmInteger<long>, RealmInteger<byte>>
        {
            public override RealmInteger<byte> Convert(RealmInteger<long> value) => (byte)value;
        }

        public class RealmIntegerLongRealmIntegerShortConverter : SpecializedConverterBase<RealmInteger<long>, RealmInteger<short>>
        {
            public override RealmInteger<short> Convert(RealmInteger<long> value) => (short)value;
        }

        public class RealmIntegerLongRealmIntegerIntConverter : SpecializedConverterBase<RealmInteger<long>, RealmInteger<int>>
        {
            public override RealmInteger<int> Convert(RealmInteger<long> value) => (int)value;
        }

        public class RealmIntegerLongFloatConverter : SpecializedConverterBase<RealmInteger<long>, float>
        {
            public override float Convert(RealmInteger<long> value) => value;
        }

        public class RealmIntegerLongDoubleConverter : SpecializedConverterBase<RealmInteger<long>, double>
        {
            public override double Convert(RealmInteger<long> value) => value;
        }

        public class RealmIntegerLongDecimalConverter : SpecializedConverterBase<RealmInteger<long>, decimal>
        {
            public override decimal Convert(RealmInteger<long> value) => value;
        }

        public class RealmIntegerLongDecimal128Converter : SpecializedConverterBase<RealmInteger<long>, Decimal128>
        {
            public override Decimal128 Convert(RealmInteger<long> value) => (long)value;
        }

        #endregion Integral Converters

        #region Floating Point Converters

        public class FloatNullableFloatConverter : SpecializedConverterBase<float, float?>
        {
            public override float? Convert(float value) => value;
        }

        public class FloatNullableDoubleConverter : SpecializedConverterBase<float, double?>
        {
            public override double? Convert(float value) => value;
        }

        public class FloatNullableDecimalConverter : SpecializedConverterBase<float, decimal?>
        {
            public override decimal? Convert(float value) => (decimal)value;
        }

        public class FloatNullableDecimal128Converter : SpecializedConverterBase<float, Decimal128?>
        {
            public override Decimal128? Convert(float value) => (Decimal128)value;
        }

        public class DoubleNullableFloatConverter : SpecializedConverterBase<double, float?>
        {
            public override float? Convert(double value) => (float)value;
        }

        public class DoubleNullableDoubleConverter : SpecializedConverterBase<double, double?>
        {
            public override double? Convert(double value) => value;
        }

        public class DoubleNullableDecimalConverter : SpecializedConverterBase<double, decimal?>
        {
            public override decimal? Convert(double value) => (decimal)value;
        }

        public class DoubleNullableDecimal128Converter : SpecializedConverterBase<double, Decimal128?>
        {
            public override Decimal128? Convert(double value) => (Decimal128)value;
        }

        public class DecimalNullableFloatConverter : SpecializedConverterBase<decimal, float?>
        {
            public override float? Convert(decimal value) => (float)value;
        }

        public class DecimalNullableDoubleConverter : SpecializedConverterBase<decimal, double?>
        {
            public override double? Convert(decimal value) => (double)value;
        }

        public class DecimalNullableDecimalConverter : SpecializedConverterBase<decimal, decimal?>
        {
            public override decimal? Convert(decimal value) => value;
        }

        public class DecimalNullableDecimal128Converter : SpecializedConverterBase<decimal, Decimal128?>
        {
            public override Decimal128? Convert(decimal value) => value;
        }

        public class Decimal128NullableFloatConverter : SpecializedConverterBase<Decimal128, float?>
        {
            public override float? Convert(Decimal128 value) => (float)value;
        }

        public class Decimal128NullableDoubleConverter : SpecializedConverterBase<Decimal128, double?>
        {
            public override double? Convert(Decimal128 value) => (double)value;
        }

        public class Decimal128NullableDecimalConverter : SpecializedConverterBase<Decimal128, decimal?>
        {
            public override decimal? Convert(Decimal128 value) => (decimal)value;
        }

        public class Decimal128NullableDecimal128Converter : SpecializedConverterBase<Decimal128, Decimal128?>
        {
            public override Decimal128? Convert(Decimal128 value) => value;
        }

        public class FloatDoubleConverter : SpecializedConverterBase<float, double>
        {
            public override double Convert(float value) => value;
        }

        public class FloatDecimalConverter : SpecializedConverterBase<float, decimal>
        {
            public override decimal Convert(float value) => (decimal)value;
        }

        public class FloatDecimal128Converter : SpecializedConverterBase<float, Decimal128>
        {
            public override Decimal128 Convert(float value) => (Decimal128)value;
        }

        public class DoubleFloatConverter : SpecializedConverterBase<double, float>
        {
            public override float Convert(double value) => (float)value;
        }

        public class DoubleDecimalConverter : SpecializedConverterBase<double, decimal>
        {
            public override decimal Convert(double value) => (decimal)value;
        }

        public class DoubleDecimal128Converter : SpecializedConverterBase<double, Decimal128>
        {
            public override Decimal128 Convert(double value) => (Decimal128)value;
        }

        public class DecimalFloatConverter : SpecializedConverterBase<decimal, float>
        {
            public override float Convert(decimal value) => (float)value;
        }

        public class DecimalDoubleConverter : SpecializedConverterBase<decimal, double>
        {
            public override double Convert(decimal value) => (double)value;
        }

        public class DecimalDecimal128Converter : SpecializedConverterBase<decimal, Decimal128>
        {
            public override Decimal128 Convert(decimal value) => value;
        }

        public class Decimal128FloatConverter : SpecializedConverterBase<Decimal128, float>
        {
            public override float Convert(Decimal128 value) => (float)value;
        }

        public class Decimal128DoubleConverter : SpecializedConverterBase<Decimal128, double>
        {
            public override double Convert(Decimal128 value) => (double)value;
        }

        public class Decimal128DecimalConverter : SpecializedConverterBase<Decimal128, decimal>
        {
            public override decimal Convert(Decimal128 value) => (decimal)value;
        }

        #endregion Floating Point Converters

        #region Nullable Converters


        public class BoolNullableBoolConverter : SpecializedConverterBase<bool, bool?>
        {
            public override bool? Convert(bool value) => value;
        }

        public class DateTimeOffsetNullableDateTimeOffsetConverter : SpecializedConverterBase<DateTimeOffset, DateTimeOffset?>
        {
            public override DateTimeOffset? Convert(DateTimeOffset value) => value;
        }

        public class ObjectIdNullableObjectIdConverter : SpecializedConverterBase<ObjectId, ObjectId?>
        {
            public override ObjectId? Convert(ObjectId value) => value;
        }

        public class GuidNullableGuidConverter : SpecializedConverterBase<Guid, Guid?>
        {
            public override Guid? Convert(Guid value) => value;
        }

        #endregion
    }
}
