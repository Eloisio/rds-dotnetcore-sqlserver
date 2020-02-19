#!/usr/bin/env sh

set -x

# Install scaffold and ef global tools
dotnet tool install --global dotnet-aspnet-codegenerator 
dotnet tool install --global dotnet-ef

# Make sure to register dotnet tools in yout path
export PATH=$HOME/.dotnet/tools:$PATH

# Generate Code scaffold
#dotnet aspnet-codegenerator controller -name MoviesController -m Movie -dc RdsContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries

# Create database migrations based on code
#dotnet ef migrations add MigrationName

# Run the migration
dotnet ef database update
