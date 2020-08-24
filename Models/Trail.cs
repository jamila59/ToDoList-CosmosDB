using System;
using Newtonsoft.Json;

namespace Hike.Models
{
    public class Trail
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "summary")]
        public string  Summary { get; set; }

        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        [JsonProperty(PropertyName = "imgsamlmed")]
        public string  ImgSmalMed { get; set; }

        [JsonProperty(PropertyName = "length")]
        public decimal? Length { get; set; }

        [JsonProperty(PropertyName = "low")]
        public int Low { get; set; }

        [JsonProperty(PropertyName = "ascent")]
        public int Ascent { get; set; }

        [JsonProperty(PropertyName = "longitude")]
        public long Longitude { get; set; }

        [JsonProperty(PropertyName = "myproperty")]
        public long MyProperty { get; set; }

        [JsonProperty(PropertyName = "difficulty")]
        public string Difficulty { get; set; }

        [JsonProperty(PropertyName = "imgsqsmall")]
        public string ImgSqSmall { get; set; }

        [JsonProperty(PropertyName = "stars")]
        public decimal Stars { get; set; }
        
        [JsonProperty(PropertyName = "conditionttatus")]
        public string ConditionStatus { get; set; }
        
        [JsonProperty(PropertyName = "conditiondetails")]

        public string ConditionDetails { get; set; }

        [JsonProperty(PropertyName = "conditiondate")]

        public DateTime ConditionDate { get; set; }
    }
}