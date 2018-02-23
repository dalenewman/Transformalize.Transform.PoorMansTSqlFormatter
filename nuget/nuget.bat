nuget pack Transformalize.Transform.PoorMansTSqlFormatter.nuspec -OutputDirectory "c:\temp\modules"
nuget pack Transformalize.Transform.PoorMansTSqlFormatter.Autofac.nuspec -OutputDirectory "c:\temp\modules"

nuget push "c:\temp\modules\Transformalize.Transform.PoorMansTSqlFormatter.0.3.3-beta.nupkg" -source https://api.nuget.org/v3/index.json
nuget push "c:\temp\modules\Transformalize.Transform.PoorMansTSqlFormatter.Autofac.0.3.3-beta.nupkg" -source https://api.nuget.org/v3/index.json






