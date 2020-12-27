### Xamarin.Forms - Entry, Editor Custom Renderers</br>

Square | Round
------------ | -------------
<img src="/screenshots/default.jpg" width="350"/>|<img src="/screenshots/default_rounded.jpg" width="350"/>

### text handle and highlight color
<img src="/screenshots/selectred_text.jpg" width="200" height="80"/> <img src="/screenshots/text_handler.jpg" width="200" height="80"/>

## All properties
```xaml
<ContentPage.Resources>
    <Color x:Key="PrimaryColor">#0074D9</Color>

<!-- the same for XEditor -->
    <Style x:Key="XEntryStyle" TargetType="controls:XEntry">
        <Setter Property="XHandleColor" Value="{StaticResource PrimaryColor}"/>
        <Setter Property="XHighlightColor" Value="{StaticResource PrimaryColor}"/>
        <Setter Property="XBorderColor" Value="{StaticResource PrimaryColor}"/>
        <Setter Property="XBorderWidth" Value="4"/>
        <Setter Property="XCornerRadius" Value="12"/>
        <Setter Property="XPadding" Value="15,10"/>
    </Style>
</ContentPage.Resources>
```