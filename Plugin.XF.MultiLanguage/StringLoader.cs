using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;

namespace Plugin.XF.MultiLanguage
{
    public class StringLoader
    {

        public StringLoader()
        {
            this.cultureInfo = System.Threading.Thread.CurrentThread.CurrentUICulture;
        }
        private ResourceManager manager;
        private CultureInfo cultureInfo;

        private readonly List<StringResource> resources = new List<StringResource>();

        private static StringLoader _instance { get; set; }
        public static StringLoader Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new StringLoader();
                return _instance;
            }
        }

        public void Init(ResourceManager stringResourceManager)
        {
            manager = stringResourceManager;
        }

        public StringResource this[string key]
        {
            get { return this.GetString(key); }
        }

        public StringResource GetString(string resourceName)
        {
            string stringRes = this.manager.GetString(resourceName, this.cultureInfo);
            var stringResource = new StringResource(resourceName, stringRes);
            this.resources.Add(stringResource);
            return stringResource;
        }

        public void SetCultureInfo(CultureInfo cultureInfo)
        {
            this.cultureInfo = cultureInfo;
            foreach (StringResource stringResource in this.resources.ToList())
            {
                stringResource.Value = this.manager.GetString(stringResource.Key, cultureInfo);
            }
        }

    }
}
