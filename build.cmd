@ECHO OFF

if /i "%1" NEQ "" goto Generate

echo Generating grpc files...
echo.

for  %%f in (biometric_service\services\*) do (

echo Processing  %%f
echo.

::  cpp
protoc --grpc_out=.\cpp --plugin=protoc-gen-grpc=grpc_cpp_plugin.exe %%f --proto_path biometric_service
protoc --cpp_out=.\cpp %%f --proto_path biometric_service

:: csharp
protoc --grpc_out=.\csharp --plugin=protoc-gen-grpc=grpc_csharp_plugin.exe %%f --proto_path biometric_service
protoc --csharp_out=.\csharp %%f --proto_path biometric_service

:: go
REM ::protoc --go_out=plugins=grpc:golang %%f --proto_path biometric_service

echo.
)

for  %%f in (biometric_service\datatypes\*) do (

echo Processing  %%f
echo.

::  cpp
protoc --grpc_out=.\cpp --plugin=protoc-gen-grpc=grpc_cpp_plugin.exe %%f --proto_path biometric_service
protoc --cpp_out=.\cpp %%f --proto_path biometric_service

:: csharp
protoc --grpc_out=.\csharp --plugin=protoc-gen-grpc=grpc_csharp_plugin.exe %%f --proto_path biometric_service
protoc --csharp_out=.\csharp %%f --proto_path biometric_service

:: go
REM ::protoc --go_out=plugins=grpc:golang %%f --proto_path biometric_service

echo.
)
protoc --go_out=plugins=grpc:GoGrpc GoGrpc\biometric_service.proto --proto_path GoGrpc

echo Done
exit /b 0

:Generate

if not exist %1 (
    echo File "%1" doesn`t exist
    exit /b 100
)

echo Processing  %1 ...
echo.
::  cpp
protoc --grpc_out=.\cpp --plugin=protoc-gen-grpc=grpc_cpp_plugin.exe %1 --proto_path biometric_service
protoc --cpp_out=.\cpp %1 --proto_path biometric_service

:: csharp
protoc --grpc_out=.\csharp --plugin=protoc-gen-grpc=grpc_csharp_plugin.exe %1 --proto_path biometric_service
protoc --csharp_out=.\csharp %1 --proto_path biometric_service

:: go
REM ::protoc --go_out=plugins=grpc:GoGrpc GoGrpc\biometric_service.proto --proto_path GoGrpc

echo Done
exit /b 0