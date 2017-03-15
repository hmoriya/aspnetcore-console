# Console App for EF

## Create Console Project
```
dotnet new console
```



## Add package Microsoft.EntityFrameworkCore.Design

```
dotnet add package Microsoft.EntityFrameworkCore.Design
```
ontains all the design-time logic for Entity Framework Core. It's the code that all of the various tools (PMC cmdlets like Add-Migration, dotnet ef & ef.exe) call into.

## Add Package for SQLite
```
dotnet add package Microsoft.EntityFrameworkCore.SQLite
```
## Add Tool for dotnet ef append .csproj file directory.

```
<ItemGroup>
 <DotNetCliToolReference
 Include="Microsoft.EntityFrameworkCore.Tools.DotNet"
 Version="1.0.0" />
</ItemGroup>
```

##.csproj

```
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>netcoreapp1.1</TargetFramework>
  </PropertyGroup>
  <ItemGroup>
    <PackageReference Include="Microsoft.EntityFrameworkCore.Sqlite" Version="1.1.1" />
    <PackageReference Include="Microsoft.EntityFrameworkCore.Design" Version="1.1.1" PrivateAssets="All" />
  </ItemGroup>
  <ItemGroup>
    <DotNetCliToolReference Include="Microsoft.EntityFrameworkCore.Tools.DotNet" Version="1.0.0" />
  </ItemGroup>
</Project>
```

## scaffold a migration to create the initial set of tables
'''
dotnet ef migrations add MyFirstMigration
dotnet ef database update
```

* 1番目
* 2番目
* 3番目
[hmoriya(http://github.com/hmoriya/)]

### 打ち消し線のサポート
~~打ち消し線~~

### 区切り文字で囲われたコードブロック

```
ソースコードをここに書く
```

### ソースコードブロックのシンタックスハイライト機能

```rb
num = 0
while num < 2 do
   print("num = ", num)
end
print("End")
```
