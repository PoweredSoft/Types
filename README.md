## Download
Full Version | NuGet | NuGet Install
------------ | :-------------: | :-------------:
PoweredSoft.Types | <a href="https://www.nuget.org/packages/PoweredSoft.Types/" target="_blank">[![NuGet](https://img.shields.io/nuget/v/PoweredSoft.Types.svg?style=flat-square&label=nuget)](https://www.nuget.org/packages/PoweredSoft.Types/)</a> | ```PM> Install-Package PoweredSoft.Types```


## Reason of package

This package is for other packages of our company, but if you find usage for it, enjoy.

# Sample

```csharp
var codeStr = "123";
var code = codeStr.To(typeof(int));
Assert.Equal(123, code);
```

# Adding converters or replacing default converters

```csharp
class StringToIntConverter : ITypeConverter
{
	public bool CanConvert(Type source, Type destination) => source == typeof(string) && destination == typeof(int);
	public object Convert(object source, Type destination) => Convert.ToInt32(source);
}

Converter.RegisterConverter(new ConverterClass());
Converter.ReplaceConverter(new ConverterClass(), typeof(string), typeof(int));
```