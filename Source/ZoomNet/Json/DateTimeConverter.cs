using System;
using System.Text.Json;

namespace ZoomNet.Json
{
	/// <summary>
	/// Converts a <see cref="DateTime"/> to or from JSON.
	/// </summary>
	/// <seealso cref="ZoomNetJsonConverter{T}"/>
	internal class DateTimeConverter : ZoomNetJsonConverter<DateTime>
	{
		public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			switch (reader.TokenType)
			{
				case JsonTokenType.String:
					var stringValue = reader.GetString();
					return DateTime.Parse(stringValue);
				default:
					throw new Exception("Unable to convert to DateTime");
			}
		}

		public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToZoomFormat());
		}
	}
}
