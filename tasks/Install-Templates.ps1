dotnet new uninstall AggregateGroot.DDD.Templates
dotnet pack ../src/TemplatePack/TemplatePack.csproj -c Release
dotnet new install ../src/TemplatePack/bin/Release/AggregateGroot.DDD.Templates.0.4.0.nupkg