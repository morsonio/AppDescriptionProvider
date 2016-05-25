using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication2.ResponceModels;
using System.Reflection;
using Newtonsoft.Json.Linq;

namespace ConsoleApplication2
{
    public class JsonConverterExtension : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return typeof(AppDetailsContainer).GetTypeInfo().IsAssignableFrom(objectType.GetTypeInfo());
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType==JsonToken.Null)
            {
                return null;
            }

            JObject o = JObject.Load(reader);

            foreach (var x in o)
            {
                var data = x.Value["data"].ToObject<Data>();
                return data;
            }
            return null;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override bool CanWrite
        {
            get
            {
                return false;
            }
        }
    }
}
