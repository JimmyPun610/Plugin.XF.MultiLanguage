using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Plugin.XF.MultiLanguage
{
    public class StringResource : INotifyPropertyChanged
    {

        public StringResource(string key, string value)
        {
            this.Key = key;
            this.Value = value;
        }

        private string value;

        public string Key { get; }

        public string Value
        {
            get { return this.value; }
            set
            {
                this.value = value;
                this.OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
