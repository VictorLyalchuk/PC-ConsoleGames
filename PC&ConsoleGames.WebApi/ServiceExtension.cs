using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Globalization;

namespace PC_ConsoleGames.WebApi
{
    public static class ServiceExtension
    {
        public static void AddSwaggerGenWithCustomSchema(this IServiceCollection service)
        {
            service.AddSwaggerGen();
        }
        public static void AddControllersWithCustomSchema(this IServiceCollection service)
        {
            service.AddControllers().AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
                options.JsonSerializerOptions.Converters.Add(new DateTimeConverter());
            });
        }

        public class DateTimeConverter : JsonConverter<DateTime>
        {
            public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                if (DateTime.TryParseExact(reader.GetString(), "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out var result))
                {
                    return result;
                }

                return DateTime.MinValue;
            }

            public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
            {
                writer.WriteStringValue(value.ToString("yyyy-MM-dd"));
            }
        }
    }
}