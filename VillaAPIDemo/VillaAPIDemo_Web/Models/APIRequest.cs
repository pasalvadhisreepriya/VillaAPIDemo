using Microsoft.AspNetCore.Mvc;
using static VillaAPIDemo_Utility.SD;

namespace VillaAPIDemo_Web
{
    public class APIRequest
    {
        public ApiType ApiType { get; set; } = ApiType.GET;
        public string Url { get; set; }
        public object Data { get; set; }
        
    }
}
