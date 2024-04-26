using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Ex2
{
    internal class Program
    {
        public class Init_param
        {
            [JsonProperty("configGlossary:installationAt")]
            public string configGlossary_installationAt;

            [JsonProperty("configGlossary:adminEmail")]
            public string configGlossary_adminEmail;
            [JsonProperty("configGlossary:poweredBy")]
            public string configGlossary_poweredBy;


            [JsonProperty("configGlossary:poweredByIcon")]
            public string configGlossary_poweredByIcon;
            [JsonProperty("configGlossary:staticPath")]
            public string configGlossary_staticPath;


            public string templateProcessorClass;
            public string templateLoaderClass;
            public string templatePath;
            public string templateOverridePath;
            public string defaultListTemplate;
            public string defaultFileTemplate;
            public bool useJSP;
            public string jspListTemplate;
            public string jspFileTemplate;
            public int cachePackageTagsTrack;
            public int cachePackageTagsStore;
            public int cachePackageTagsRefresh;
            public int cacheTemplatesTrack;
            public int cacheTemplatesStore;
            public int cacheTemplatesRefresh;


            public int cachePagesTrack;
            public int cachePagesStore;
            public int cachePagesRefresh;
            public int cachePagesDirtyRead;
            public string searchEngineListTemplate;
            public string searchEngineFileTemplate;
            public string searchEngineRobotsDb;
            public bool useDataStore;
            public string dataStoreClass;
            public string redirectionClass;
            public string dataStoreName;
            public string dataStoreDriver;
            public string dataStoreUrl;
            public string dataStoreUser;
            public string dataStorePassword;
            public string dataStoreTestQuery;
            public string dataStoreLogFile;
            public int dataStoreInitConns;
            public int dataStoreMaxConns;
            public int dataStoreConnUsageLimit;
            public string dataStoreLogLevel;
            public int maxUrlLength;

            public string mailHost;
            public string mailHostOverride;
            public int log;
            public string logLocation;
            public string logMaxSize;
            public int dataLog;
            public string dataLogLocation;
            public string dataLogMaxSize;
            public string removePageCache;
            public string removeTemplateCache;
            public string fileTransferFolder;
            public int lookInContext;
            public int adminGroupID;
            public bool betaServer;
        }
        public class Servlet
        {
            [JsonProperty("servlet-name")]
            public string servlet_name;
            [JsonProperty("servlet-class")]
            public string servlet_class;
            [JsonProperty("init-param")]
            public Init_param init_param;
        }
        public class Servlet_mapping
        {
            public string cofaxCDS;
            public string cofaxEmail;
            public string cofaxAdmin;
            public string fileServlet;
            public string cofaxTools;
        }
        public class Taglib
        {
            [JsonProperty("taglib-uri")]
            public string taglib_uri;
            [JsonProperty("taglib-location")]
            public string taglib_location;
        }
        public class Web_app
        {
            public List<Servlet> servlet { get; set; }
            [JsonProperty("servlet-mapping")]
            public Servlet_mapping servlet_mapping { get; set; }
            public Taglib taglib { get; set; }
        }
        public class Model
        {
            [JsonProperty("web-app")] // dùng để đặt tên biến, nếu biến không theo chuẩn của c#
            public Web_app web_app { get; set; }
        }
        static void Main(string[] args)
        {
            // Đường dẫn tới chỗ lưu file
            string jsonPath = System.IO.File.ReadAllText("D:\\Tự học\\ex2.json");
            // Chuyển từ chuỗi sang model có kiểu dữ liệu được truyền vào
            Model deserialized = JsonConvert.DeserializeObject<Model>(jsonPath);
            // Chuyển từ model sang chuỗi
            string serialized = JsonConvert.SerializeObject(deserialized);
            Console.WriteLine(serialized);
            Console.ReadKey();
        }
    }
}
