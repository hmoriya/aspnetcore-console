# Using Serilog sample

# Add DI
```
dotnet add package Microsoft.Extensions.DependencyInjection
```
# Add Serilog Lib
```
dotnet add package Serilog
dotnet add package Serilog.Sinks.Literate
dotnet add package Serilog.Sinks.RollingFile
```

```
Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.LiterateConsole()
                .WriteTo.RollingFile("logs\\myapp-{Date}.txt")
                .CreateLogger();
```
