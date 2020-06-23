This is a small plugin to allow Xamarin Forms apply different language on the fly

#### Support
##### Android
##### iOS

#### How to use
1. Install the plugin to your Xamarin Form project (.net standard project only)
```
Install-Package Plugin.XF.MultiLanguage
```

2. Create your string resources file and define key and value
```XML
String.resx         //Default
String.es.resx      //Spanish
String.zh.resx      //Chinese
```

3. Init the library in App.cs with your ResourceManager
```C#
    public App()
        {
            InitializeComponent();
            Plugin.XF.MultiLanguage.StringLoader.Instance.Init(StringRes.ResourceManager);
            MainPage = new MainPage();
        }
```

4. Use in XAML
```XAML
<ContentPage xmlns="http://xamarin.com/schemas/2014/forms"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:d="http://xamarin.com/schemas/2014/forms/design"
             xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
             xmlns:multiLang="clr-namespace:Plugin.XF.MultiLanguage;assembly=Plugin.XF.MultiLanguage"
             mc:Ignorable="d"
             x:Class="SampleApp.MultiLangage.MainPage">
      <!-- Replace {ResourceKey} to the key, for example, [Hello].Value-->
      <Label  Text="{Binding [{ResourceKey}].Value, Source={x:Static multiLang:StringLoader.Instance}}" 
           HorizontalOptions="Center"
           VerticalOptions="CenterAndExpand"/>
           
</ContentPage>
```

5. Use in C#
```C#
//Replace ResourceKey to to key, for example, Hello
StringLoader.Instance.GetString("ResourceKey").Value;
```

#### Change App language
1. Call this below to change the app language in runtime
```#C
  Plugin.XF.MultiLanguage.StringLoader.Instance.SetCultureInfo(new CultureInfo(languageCode));
```

#### Important to know
As the plugin does not save the language preference, the app should set the language again while launching. Otherwise, it will take DeviceUICultureInfo as the culture info.


#### Reference
##### <a href="https://docs.microsoft.com/en-us/openspecs/windows_protocols/ms-lcid/70feba9f-294e-491e-b6eb-56532684c37f">LCID language code in HEX</a>
##### <a href="https://stackoverflow.com/questions/44410407/xamarin-forms-change-ui-language-at-runtime-xaml">Main logic of the plugin</a>
