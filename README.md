# Azure.Storage.Table.GetTableReference

[![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst/azure-storage-table-gettablereference.svg?label=AppVeyor&style=for-the-badge)](https://ci.appveyor.com/project/cdorst/azure-storage-table-gettablereference)
[![NuGet package status](https://img.shields.io/nuget/v/CDorst.Azure.Storage.Table.GetTableReference.svg?label=NuGet&style=for-the-badge)](https://www.nuget.org/packages/CDorst.Azure.Storage.Table.GetTableReference)

## Description

Function returns a reference of a Microsoft Azure CloudTable using the given connection string and table name

## Environment Variables

This project depends on this environment variable:

Name | Description
---- | -----------
`LOCAL_NUGET_SOURCE_PATH` | *Required* to build the project, but not required during code execution. This is set to `c:\projects\nuget\cache` on the build server. On your development machine, set this to an empty, existing path. `dotnet restore` will inspect this folder prior to checking NuGet.

## Dependencies

Name | Status
---- | ------
[CDorst.Azure.Storage.Table.GetTableClient](https://github.com/CDorst/Azure.Storage.Table.GetTableClient) | [![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst/azure-storage-table-gettableclient.svg?label=AppVeyor&style=flat-square)](https://ci.appveyor.com/project/cdorst/azure-storage-table-gettableclient) [![NuGet package status](https://img.shields.io/nuget/v/CDorst.Azure.Storage.Table.GetTableClient.svg?label=NuGet&style=flat-square)](https://www.nuget.org/packages/CDorst.Azure.Storage.Table.GetTableClient)

## Dependents

The project below uses this repository as a direct dependency.

Name | Status
---- | ------
[Azure.Storage.Table.GetOrCreateTableReference](https://github.com/CDorst/Azure.Storage.Table.GetOrCreateTableReference) | [![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst/azure-storage-table-getorcreatetablereference.svg?label=AppVeyor&style=flat-square)](https://ci.appveyor.com/project/cdorst/azure-storage-table-getorcreatetablereference) [![NuGet package status](https://img.shields.io/nuget/v/CDorst.Azure.Storage.Table.GetOrCreateTableReference.svg?label=NuGet&style=flat-square)](https://www.nuget.org/packages/CDorst.Azure.Storage.Table.GetOrCreateTableReference)

## NuGet


This project is published as a NuGet package at [https://www.nuget.org/packages/CDorst.Azure.Storage.Table.GetTableReference](https://www.nuget.org/packages/CDorst.Azure.Storage.Table.GetTableReference)

## Version

4.0.10

## Metaproject

Azure.Storage.Table.GetTableReference is maintained by robots and exists because of a declarative template metaproject. View the metaproject's component directory at [https://github.com/CDorst/Project.Index](https://github.com/CDorst/Project.Index)

