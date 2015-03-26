using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace AngularJS.Models
{
    [MetadataType(typeof(CategoryMetaData))]
    public partial class Category { }

    public class CategoryMetaData
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }

        [JsonIgnore]
        public byte[] Picture { get; set; }
    }
}