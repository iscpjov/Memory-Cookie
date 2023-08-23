using System;
using System.Text.Json;
using InCache.ManagerJson;

namespace InCache.Cookie
{
    internal class ObjCookie
    {
        private string key;
        private string type;
        private JsonElement value;

        public string Key { get => key; set => key = value; }
        public string Type { get => type; set => type = value; }
        public JsonElement Value { get => value; set => this.value = value; }




        public ObjCookie() { }
        public ObjCookie(string key, object value)
        {
            this.key = key;
            this.type = value.GetType().FullName;
            this.value = (JsonElement)Json.Deserialize<JsonElement>(Json.Serialize(value));
        }

        public override bool Equals(object obj)
        {
            if(obj == null && GetType() != obj.GetType()) 
                return false;

            ObjCookie OtherCookie = (ObjCookie)obj;
            if (this.key == OtherCookie.key && this.type == OtherCookie.type && this.value.GetRawText() == OtherCookie.value.GetRawText())
                return true;
            
            
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            var hashcode = new HashCode();
            hashcode.Add(this.key);
            hashcode.Add(this.type);
            hashcode.Add(this.value.GetRawText());
            return hashcode.ToHashCode();
        }

        public override string ToString()
        {
            return Json.Serialize(this);
        }
    }
}
