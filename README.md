# EMPRESA-QBE
Creacion del Proyecto mvc en visual studio code

1. git clone https://github.com/AntonyFAC/EMPRESA-QBE.git
2. dotnet new mvc --auth Individual
3. dotnet tool install --global dotnet-aspnet-codegenerator --version 6.0.2
4. add .gitignore

Creacion del Crud de Producto

 dotnet aspnet-codegenerator controller -name ProductoController -m Producto -dc EMPRESA_QBE.Data.ApplicationDbContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries
