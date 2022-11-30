# XamarinNLogExample

### Espa�ol
�Hola!

En este proyecto se utiliza NLog como la fuente para realizar los registros de eventos, errores y m�s datos en la aplicaci�n.

Para este caso se utiliza un target que comsume un m�todo en una clase est�tica. La configuraci�n de este es como sugiere la documentaci�n [aqu�](https://github.com/NLog/NLog/wiki/MethodCall-target 'Link a documentaci�n de Method Call').

En la documentaci�n especifica que el ensamblado puede llamar a diferentes clases dentro del proyecto, incluso entre otras capas si fuera el caso.

El m�todo que llama puede llevar la l�gica que se acople a tus necesidades, ya sea escribir un archivo de texto o conectarlo a una REST API.

### English
Hi!

In this project NLog is used as the source for logging events, errors and more data in the application.

For this case we use a target that assumes a method in a static class. The configuration of this is as suggested in the documentation [here](https://github.com/NLog/NLog/wiki/MethodCall-target 'Link to Method Call documentation').

The documentation specifies that the assembly can call different classes within the project, even between other layers if necessary.

The calling method can carry the logic that suits your needs, whether it's writing a text file or connecting to a REST API.

```xml
<targets>
	<target name="m" xsi:type="MethodCall" className="XamarinNLogExample.Helpers.NLogEventsHelper, XamarinNLogExample, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null" methodName="LogMethod">
		<parameter layout="${level}" />
		<parameter layout="${message}" />
		<parameter layout="${callsite:includeSourcePath=true}" />
		<parameter layout="${exception:format=ToString}" />
		<parameter layout="${longdate:universalTime=true}" />
		<parameter layout="${var:urlBase}" />
	</target>
<targets>
<rules>
	<logger name="*" writeTo="m"></logger>
</rules>
```

``` csharp
namespace XamarinNLogExample.Helpers
{
    public static class NLogEventsHelper
    {
        public static void LogMethod(string level, string message, string callsite, string exception, string longdate, string url = "")
        {
            //TODO: Here your logic
        }
    }
}
```

Note: I use the NLog version 4.7.15 para Xamarin.Forms.